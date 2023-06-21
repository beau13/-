using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.Common;
using System.Data.Entity.Core;

namespace WindowsFormsApp1
{

    public class Model
    {
        private SQLiteConnection sqlite;  //cоздали класс sqlite для подключения к бд

        public static Model CurrentModel { get; private set; } 

        public Model()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Diaryy.db");
            sqlite = new SQLiteConnection("Data Source=" + path, true);  //cтрока подключения к бд

            CurrentModel = this;
        }

        public DataTable ExecuteQueryWithResponse(string query, Dictionary<string, object> parameters = null)
        {
            SQLiteDataAdapter ad;             //объект для получения и сохранения данных бд
            DataTable dt = new DataTable();   //cоздали новую таблицу dt
        
            try
            {
                SQLiteCommand cmd;              // скомпилированная команда к бд
                sqlite.Open();                  //соединение с бд
                cmd = sqlite.CreateCommand();   // 
                cmd.CommandText = query;        //хранит выполняемую команду бд

                if (parameters != null)
                    foreach (var kwpair in parameters)
                    {
                        cmd.Parameters.AddWithValue(kwpair.Key, kwpair.Value);
                    }

                ad = new SQLiteDataAdapter(cmd);   //объект, в котором отправляем и получаем ответ из бд (запрос cmd)
                ad.Fill(dt);                    //заполняет таблицу 

            }
            catch (SQLiteException ex)
            {
                throw ex;
            }
            sqlite.Close();
            return dt;
        }

        public void ExecuteQuery(string query)  //метод для выполнения запросов в бд
        {
            sqlite.Open(); 
            SQLiteCommand cmd = new SQLiteCommand(query, sqlite); // команда сmd с запросом query в бд
            cmd.ExecuteNonQuery();  //выполняет запрос в бд
            sqlite.Close();
        }
        public void UpdateWithDT(DataTable dt, string tableName) 
        {
            string desroySql = $"DELETE FROM {tableName};";
            ExecuteQuery(desroySql);

            // Нашла в интернете
            var columnNames = dt.Columns.OfType<DataColumn>().Select((col) => col.ColumnName).Where(name => name != "id").ToList();
            var values = dt.Rows.OfType<DataRow>()
                .Where(row => !row.ItemArray.Skip(1).All(item => string.IsNullOrEmpty(item.ToString())))
                .Select(row => row.ItemArray.Skip(1).Select(item => $"'{item}'").ToList())
                .Select(row => $"({string.Join(", ", row)})")
                .ToList();

            string sql = $"INSERT INTO {tableName} ({string.Join(", ", columnNames)}) VALUES {string.Join(", ", values)};";

            ExecuteQuery(sql);

        }

        public DataTable getTableData(string tableName, string[] searchColumns = null, string search = null) {

            if (string.IsNullOrEmpty(search) || searchColumns == null) 
            {
                var dataTableSelect = this.ExecuteQueryWithResponse($@"
                    SELECT *
                    FROM {tableName};      
                ");                    //обращаемся к методу

                return dataTableSelect;
            }

            else 
            {
                var first = searchColumns.Take(1).Select((col) => $"WHERE {col} LIKE @search").First();
                var other = searchColumns.Skip(1).Select((col) => $"OR {col} LIKE @search").ToList();

                string query = $"SELECT * FROM {tableName} {first} {string.Join(" ", other)};";
                var dataTableSelect = this.ExecuteQueryWithResponse(query,
                    new Dictionary<string, object>() {
                        {"@search", $"%{search}%"},
                    });

                return dataTableSelect;
            }
        }

    }
}
