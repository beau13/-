using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using Microsoft.Data.Sqlite;
using MaterialSkin.Controls;

namespace WindowsFormsApp1
{

    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
            
            // Важная строчка - создаём модель
            new Model();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Form dlg1 = new TableForm();
            dlg1.ShowDialog();
        }
        private void materialButton2_Click(object sender, EventArgs e)
        {
            Form dlg2 = new TableForm2();
            dlg2.ShowDialog();
        }
        private void materialButton3_Click(object sender, EventArgs e)
        {
            Form dlg3 = new TableForm3();
            dlg3.ShowDialog();
        }
        private void materialButton4_Click(object sender, EventArgs e)
        {
            Form dlg4 = new TableForm4();
            dlg4.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form dlg5 = new Form2();
            dlg5.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form dlg6 = new Form3();
            dlg6.ShowDialog();
        }
    }
}
