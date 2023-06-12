using MaterialSkin;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form3 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Form3()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Indigo500,
                MaterialSkin.Primary.Indigo700,
                MaterialSkin.Primary.Indigo100,
                MaterialSkin.Accent.Pink200,
                MaterialSkin.TextShade.WHITE
            );

            try
            {
                FillTableData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void chart_Click(object sender, EventArgs e)
        {
            
        }

        private void FillTableData()
        {
            var dt = Model.CurrentModel.ExecuteQueryWithResponse(
                "SELECT дата_и_время, COUNT(id) FROM Расписание" +
                " GROUP BY дата_и_время;"
            );

            string[] N = new string[dt.Rows.Count];
            int[] M = new int[dt.Rows.Count];

            // Set title.
            chart.Titles.Add("Самые загруженные дни");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Series series = chart.Series.Add(dt.Rows[i][0].ToString());
                series.Points.Add(System.Convert.ToInt32(dt.Rows[i][1]));
            }
        }
    }
}
