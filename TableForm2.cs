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
        private SQLiteConnection sqlite;

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public TableForm2()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

            dgv1.CellBeginEdit += dgv_CellBeginEdit;    //cобытия
            dgv1.CellValidating += dgv_CellValidating;
            dgv1.CellEndEdit += dgv_CellEndEdit;

            UpdateToModel();
        }

        private void UpdateToModel(string search = null)
        {
            BindingSource SBind = new BindingSource();

            SBind.DataSource = Model.CurrentModel.SearchTasks(search);  // устанавливаем источник данных для адаптера

            dgv1.DataSource = SBind;
            dgv1.Refresh();   //обновляем
        }

        private void dgv_CellBeginEdit(Object sender, DataGridViewCellCancelEventArgs e)
        {
            //Здесь мы сохраняем текущее значение ячейки в какую-то переменную, которую потом мы можем сравнить с новым значением
            //Например, использование свойства dgv.Tag
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                this.dgv1.Tag = this.dgv1.CurrentCell.Value;
                //или передать отправителя в переменную DataGridView
                //->, чем этот обработчик может быть использован в другом представлении данных
            }
        }

        private void dgv_CellValidating(Object sender, DataGridViewCellValidatingEventArgs e)
        {
            //Здесь можем добавить всевозможные проверки для нового значения 
            //Например, просто сравнить со старым значением и проверить, больше ли оно 0
            if (this.dgv1.Tag == this.dgv1.CurrentCell.Value)
                e.Cancel = true;

            try
            {
                System.Convert.ToInt32(this.dgv1.CurrentCell.Value);
            }
            catch
            {
                e.Cancel = true;
            }
        }

        private void dgv_CellEndEdit(Object sender, DataGridViewCellEventArgs e)
        {
            //Поскольку событие CellEndEdit происходит после события CellValidating(если не отменено)
            ///Здесь вы можете обновить новое значение в базу данных
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Model.CurrentModel.addTask(timeTextBox.Text, reminderTextBox.Text);

                UpdateToModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(idTextBox.Text);
                Model.CurrentModel.deleteTask(id);

                UpdateToModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(materialTextBox1.Text);
                string time = Convert.ToString(timeTextBox.Text);
                Model.CurrentModel.updateTask(id, time, reminderTextBox.Text);

                UpdateToModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TableForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
