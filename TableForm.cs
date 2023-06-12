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
    public partial class TableForm : MaterialForm
    {
        private SQLiteConnection sqlite;

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public TableForm()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);


            dgv.CellBeginEdit += dgv_CellBeginEdit;    //cобытия
            dgv.CellValidating += dgv_CellValidating;
            dgv.CellEndEdit += dgv_CellEndEdit;

            UpdateToModel();
        }
        private void UpdateToModel(string query = null)
        {
            BindingSource SBind = new BindingSource();

            SBind.DataSource = Model.CurrentModel.getTimetable(query);  // устанавливаем источник данных для адаптера

            dgv.DataSource = SBind;
            dgv.Refresh();   //обновляем
        }

        private void dgv_CellBeginEdit(Object sender, DataGridViewCellCancelEventArgs e)
        {
            //Здесь мы сохраняем текущее значение ячейки в какую-то переменную, которую потом мы можем сравнить с новым значением
            //Например, использование свойства dgv.Tag
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                this.dgv.Tag = this.dgv.CurrentCell.Value;
                //или передать отправителя в переменную DataGridView
                //->, чем этот обработчик может быть использован в другом представлении данных
            }
        }

        private void dgv_CellValidating(Object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (this.dgv.Tag == this.dgv.CurrentCell.Value)
                e.Cancel = true;    

            try
            {
                System.Convert.ToInt32(this.dgv.CurrentCell.Value);
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
                Model.CurrentModel.addTimetable(timeTextBox1.Text, addTextBox1.Text);

                UpdateToModel();

                MessageBox.Show("Запись была успешно добавлена в расписание");
            }
            catch
            {
                MessageBox.Show("Непраивльно введены данные");
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(idTextBox.Text);
                //Model.CurrentModel.deleteTimetable(id);

                UpdateToModel();

                MessageBox.Show("Запись была успешно удалена");
            }
            catch
            {
                MessageBox.Show("Непраивльно введены данные");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(materialTextBox.Text);
                string time = Convert.ToString(timeTextBox1.Text);
                Model.CurrentModel.updateTimetable(id, time, addTextBox1.Text);

                UpdateToModel();

                MessageBox.Show("Запись была успешно редактирована");
            }
            catch
            {
                MessageBox.Show("Непраивльно введены данные");
            }
        }

        private void TableForm_Load(object sender, EventArgs e)
        {

        }
    }
}
