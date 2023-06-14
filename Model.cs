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

        public static Model CurrentModel { get; private set; } // current model

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

                ad = new SQLiteDataAdapter(cmd);   //объект, в котором хранится ответ из бд (cmd)
                ad.Fill(dt);                    //заполняет таблицу 

            }
            catch (SQLiteException ex)
            {
                throw ex;
            }
            sqlite.Close();
            return dt;
        }

        public void ExecuteQuery(string query)
        {
            sqlite.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, sqlite);
            cmd.ExecuteNonQuery();
            sqlite.Close();
        }

        public void UpdateWithDT(DataTable dt, string tableName) {
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

            if (string.IsNullOrEmpty(search) || searchColumns == null) {
                var dataTableSelect = this.ExecuteQueryWithResponse($@"
                    SELECT *
                    FROM {tableName};      
                ");  //обращаемся к методу

                return dataTableSelect;
            }

            else {
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


        // НАПОМИНАНИЯ
        // TODO: удалить старые методы, переделать все формы
        public void addTask(string dateTime, string notify)
        {
            throw new NotImplementedException();

            string query = "INSERT INTO Напоминания( дата_и_время, напоминание) VALUES ('"
                + dateTime
                + "','"
                + notify + "')";

            this.ExecuteQuery(query);
        }
        public void deleteTask(int id)
        {
            throw new NotImplementedException();
            string query = $"DELETE FROM Напоминания WHERE id = {id}";

            this.ExecuteQuery(query);
        }
        public DataTable SearchTasks(string search = null)
        {
            throw new NotImplementedException();
            if (search == null || search == "")
            {
                var dataTableSelect = this.ExecuteQueryWithResponse(@"      
                    SELECT *
                    FROM Напоминания;
                ");  //обращаемся к методу

                return dataTableSelect;
            }

            else
            {
                string query = $"SELECT * FROM Напоминания " +
                    $"WHERE дата_и_время LIKE @search " +
                    $"OR напоминание LIKE @search; ";

                var dataTableSelect = this.ExecuteQueryWithResponse(query,
                    new Dictionary<string, object>() {
                        {"@search", $"%{search}%"},
                    });

                return dataTableSelect;
            }
        }

        public void updateTask(int id, string dateTime, string notify)
        {
            throw new NotImplementedException();
            string query = $"UPDATE Напоминания SET дата_и_время = @datetime," +
                           $"напоминание = @notify " +
                           $"WHERE id = {id}";

            this.ExecuteQueryWithResponse(query,
                new Dictionary<string, object>() {
                        {"@datetime", $"{dateTime}"},
                        {"@notify", $"{notify}"},
                });

        }



        // РАСПИСАНИЕ
        public void addTimetable(string dateTime, string notify)
        {
            throw new NotImplementedException();
            string query = "INSERT INTO Расписание( дата_и_время, задача) VALUES ('"
                + dateTime
                + "','"
                + notify + "')";

            this.ExecuteQuery(query);

        }
        public void deleteTimetable(int id)
        {
            throw new NotImplementedException();
            string query = $"DELETE FROM Расписание WHERE id = {id}";

            this.ExecuteQuery(query);
        }

        public void updateTimetable(int id, string dateTime, string notify)
        {
            throw new NotImplementedException();
            string query = $"UPDATE Расписание SET дата_и_время = @datetime," +
                           $"задача = @notify " +
                           $"WHERE id = {id}";

            this.ExecuteQueryWithResponse(query,
                new Dictionary<string, object>() {
                        {"@datetime", $"{dateTime}"},
                        {"@notify", $"{notify}"},
                });

        }

        public DataTable getTimetable(string search = null)
        {
            throw new NotImplementedException();

            if (search == null || search == "")
            {
                var dataTableSelect = this.ExecuteQueryWithResponse(@"      
                    SELECT *
                    FROM Расписание;
                ");  //обращаемся к методу

                return dataTableSelect;
            }

            else
            {
                string query = $"SELECT * FROM Расписание " +
                    $"WHERE дата_и_время LIKE @search " +
                    $"OR задача LIKE @search; ";

                var dataTableSelect = this.ExecuteQueryWithResponse(query,
                    new Dictionary<string, object>() {
                        {"@search", $"%{search}%"},
                    });

                return dataTableSelect;
            }
        }


        // ЗАМЕТКИ
        public void addNote(string note)
        {
            throw new NotImplementedException();
            string query = "INSERT INTO Заметки(Заметки) VALUES ('" + note + "')";

            this.ExecuteQuery(query);

        }
        public void deleteNote(int id)
        {
            throw new NotImplementedException();
            string query = $"DELETE FROM Заметки WHERE id = {id}";

            this.ExecuteQuery(query);
        }

        public void updateNote(int id, string note)
        {
            throw new NotImplementedException();
            string query = $"UPDATE Заметки SET Заметки = @note  " +
                           $"WHERE id = {id}";

            this.ExecuteQueryWithResponse(query,
                new Dictionary<string, object>() {
                        {"note", $"{note}"},
                });

        }
        public DataTable SearchNote(string search = null)
        {
            throw new NotImplementedException();
            if (search == null || search == "")
            {
                var dataTableSelect = this.ExecuteQueryWithResponse(@"      
                    SELECT *
                    FROM Заметки;
                ");  //обращаемся к методу

                return dataTableSelect;
            }

            else
            {
                string query = $"SELECT * FROM Заметки " +
                    $"WHERE Заметки LIKE @search; ";

                var dataTableSelect = this.ExecuteQueryWithResponse(query,
                    new Dictionary<string, object>() {
                        {"@search", $"%{search}%"},
                    });

                return dataTableSelect;
            }
        }


        // КОНТАКТЫ
        public void addContact(string name, string address, int phone, string email)
        {
            throw new NotImplementedException();
            string query = "INSERT INTO Контакты(Имя, Адрес, Номер_телефона, email_почта) VALUES ('"
                + name
                + "','"
                + address 
                + "','"
                + phone
                + "','"
                + email + "')";

            this.ExecuteQuery(query);
        }
        public void deleteContact(int id)
        {
            throw new NotImplementedException();
            string query = $"DELETE FROM Контакты WHERE id = {id}";

            this.ExecuteQuery(query);
        }

        public void updateContact(int id, string name, string address, int phone, string email)
        {
            throw new NotImplementedException();
            string query = $"UPDATE Контакты SET Имя = @name," +
                           $"Адрес = @address," +
                           $"Номер_телефона = @phone," +
                           $"email_почта = @email," +
                           $"WHERE id = {id}";

            this.ExecuteQueryWithResponse(query,
                new Dictionary<string, object>() {
                        {"@address", $"{address}"},
                        {"@phone", $"{phone}"},
                        {"@email", $"{email}"},
                        {"@name", $"{name}"},
                });

        }

        public DataTable SearchContact(string search = null)
        {
            throw new NotImplementedException();
            if (search == null || search == "")
            {
                var dataTableSelect = this.ExecuteQueryWithResponse(@"      
                    SELECT *
                    FROM Контакты;
                ");  //обращаемся к методу

                return dataTableSelect;
            }

            else
            {
                string query = $"SELECT * FROM Контакты " +
                    $"WHERE Имя LIKE @search " +
                    $"OR Адрес LIKE @search " +
                    $"OR Номер_телефона LIKE @search " +
                    $"OR email_почта LIKE @search; ";

                var dataTableSelect = this.ExecuteQueryWithResponse(query,
                    new Dictionary<string, object>() {
                        {"@search", $"%{search}%"},
                    });

                return dataTableSelect;
            }
        }
    }
}
