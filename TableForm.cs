using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Data.SQLite;
using System.IO;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MaterialSkin.Controls;

namespace WindowsFormsApp1
{
    public partial class TableForm : MaterialForm {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private DataTable dt;
        private readonly string tableName = "Расписание";
        private readonly string[] searchColumns = {"дата_и_время", "задача" };

        public TableForm()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

            UpdateToModel();
        }
        private void UpdateToModel(string query = null)
        {
            dt = Model.CurrentModel.getTableData(tableName, searchColumns, query);  // 
            dgv.DataSource = dt;
            dgv.Columns["id"].Visible = false;
            dgv.Refresh();   //обновляем
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateToModel(searchTextBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = (DataTable)dgv.DataSource;  //источник данных
                Model.CurrentModel.UpdateWithDT(dt, tableName); //вызываем метод для сохранения изменений
                MessageBox.Show("Расписание успешно сохранено"); 
            }
            catch
            {
                MessageBox.Show("Непраивльно введены данные");
            }
        }

        private void TableForm_Load(object sender, EventArgs e)
        {

        }

        private void dgv_SelectionChanged(object sender, EventArgs e) {

        }
    }
}
