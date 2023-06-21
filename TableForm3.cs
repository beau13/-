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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace WindowsFormsApp1
{

    public partial class TableForm3 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private DataTable dt;
        private readonly string tableName = "Заметки";
        private readonly string[] searchColumns = { "Заметки"};

        public TableForm3()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

            UpdateToModel();
        }

        private void UpdateToModel(string search = null)
        {
            //BindingSource SBind = new BindingSource();

            dt = Model.CurrentModel.getTableData(tableName, searchColumns);  // устанавливаем источник данных для адаптера
            // SBind.DataSource = dt;
            dgv3.DataSource = dt;
            dgv3.Columns["id"].Visible = false;
            dgv3.Refresh();   //обновляем
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateToModel(searchTextBox3.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 

        private void TableForm3_Load(object sender, EventArgs e)
        {

        }

        private void preservebutton_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = (DataTable)dgv3.DataSource;
                Model.CurrentModel.UpdateWithDT(dt, tableName);
                MessageBox.Show("Заметки успешно сохранены");
            }
            catch
            {
                MessageBox.Show("Непраивльно введены данные");
            }
        }
    }
}
