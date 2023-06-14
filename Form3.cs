using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;

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
            // https://learn.microsoft.com/en-us/previous-versions/dotnet/netframework-4.0/5hh873ya(v=vs.100)?redirectedfrom=MSDN
            // Для того, чтобы дни недели переводились на русский
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");

            var dt = Model.CurrentModel.ExecuteQueryWithResponse("SELECT дата_и_время, id FROM Расписание");

            string[] N = new string[dt.Rows.Count];
            int[] M = new int[dt.Rows.Count];

            var groupByDayOfWeek = dt.Rows.OfType<DataRow>()
                .GroupBy(row => DateTime.Parse(row.ItemArray.First().ToString()).ToString("dddd"));
            // Set title.
            chart.Titles.Add("Самые загруженные дни");
            foreach (var keyValuePair in groupByDayOfWeek) {
                Series series = chart.Series.Add(keyValuePair.Key);
                series.Points.Add(keyValuePair.Count());
            }
        }
    }
}
