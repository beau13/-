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
    
    public partial class TableForm2 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private DataTable dt;
        private readonly string tableName = "Напоминания";
        private readonly string[] searchColumns = { "дата_и_время", "напоминание" };

        public TableForm2()
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
            //BindingSource SBind = new BindingSource();

            dt = Model.CurrentModel.getTableData(tableName, searchColumns, query);  // устанавливаем источник данных для адаптера
            // SBind.DataSource = dt;
            dgv1.DataSource = dt;
            dgv1.Columns["id"].Visible = false;
            dgv1.Refresh();   //обновляем
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateToModel(searchTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = (DataTable)dgv1.DataSource;
                Model.CurrentModel.UpdateWithDT(dt, tableName);
                MessageBox.Show("Напоминание успешно сохранено");
            }
            catch
            {
                MessageBox.Show("Непраивльно введены данные");
            }
        }

        private void TableForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
