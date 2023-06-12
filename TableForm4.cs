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
        private SQLiteConnection sqlite;

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public TableForm4()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

            dgv4.CellBeginEdit += dgv_CellBeginEdit;    //cобытия
            dgv4.CellValidating += dgv_CellValidating;
            dgv4.CellEndEdit += dgv_CellEndEdit;

            UpdateToModel();
        }
        private void UpdateToModel(string search = null)
        {
            BindingSource SBind = new BindingSource();

            SBind.DataSource = Model.CurrentModel.SearchContact(search);  // устанавливаем источник данных для адаптера

            dgv4.DataSource = SBind;
            dgv4.Refresh();   //обновляем
        }

        private void dgv_CellBeginEdit(Object sender, DataGridViewCellCancelEventArgs e)
        {
            //Здесь мы сохраняем текущее значение ячейки в какую-то переменную, которую потом мы можем сравнить с новым значением
            //Например, использование свойства dgv.Tag
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                this.dgv4.Tag = this.dgv4.CurrentCell.Value;
                //или передать отправителя в переменную DataGridView
                //->, чем этот обработчик может быть использован в другом представлении данных
            }
        }

        private void dgv_CellValidating(Object sender, DataGridViewCellValidatingEventArgs e)
        {
            //Здесь можем добавить всевозможные проверки для нового значения 
            //Например, просто сравнить со старым значением и проверить, больше ли оно 0
            if (this.dgv4.Tag == this.dgv4.CurrentCell.Value)
                e.Cancel = true;

            try
            {
                System.Convert.ToInt32(this.dgv4.CurrentCell.Value);
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
                int phone = Convert.ToInt32(phoneTextBox.Text);
                Model.CurrentModel.addContact(nameTextBox.Text, addressTextBox.Text, phone , mailTextBox.Text);

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
                Model.CurrentModel.deleteContact(id);

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
                UpdateToModel(searchTextBox4.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void updateButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(materialTextBox1.Text);
                int phone = Convert.ToInt32(phoneTextBox.Text);
                Model.CurrentModel.updateContact(id, nameTextBox.Text, addressTextBox.Text, phone, mailTextBox.Text);

                UpdateToModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
