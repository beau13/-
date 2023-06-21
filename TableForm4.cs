using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TableForm4: MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private DataTable dt;
        private readonly string tableName = "Контакты";
        private readonly string[] searchColumns = { "Имя", "Адрес", "Номер_телефона", "email_почта"};
        public TableForm4()
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

            dt = Model.CurrentModel.getTableData(tableName, searchColumns, search);  // устанавливаем источник данных для адаптера
            // SBind.DataSource = dt;
            dgv4.DataSource = dt;
            dgv4.Columns["id"].Visible = false;
            dgv4.Refresh();   //обновляем
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateToModel(searchTextBox4.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void TableForm4_Load(object sender, EventArgs e)
        {

        }

        private void preserveButton4_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = (DataTable)dgv4.DataSource;
                Model.CurrentModel.UpdateWithDT(dt, tableName);
                MessageBox.Show("Контакты успешно сохранены");
            }
            catch
            {
                MessageBox.Show("Непраивльно введены данные");
            }
        }
    }
}
