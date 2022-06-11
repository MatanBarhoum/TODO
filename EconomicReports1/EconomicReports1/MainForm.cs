using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EconomicReports1.Engine;

namespace EconomicReports1
{
    public partial class MainForm : Form
    {
        Random random = new Random();
        public int Month { get; set; }
        public MainForm()
        {
            var randNumber = random.Next(5000, 7500);
           // Thread m = new Thread(new ThreadStart(StartForm));
           // m.Start();
           // Thread.Sleep(randNumber);
            InitializeComponent();
           // m.Abort();
            
        }

        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("WorkingHours", "שעות עבודה (מחשבים)");
            dataGridView1.Columns.Add("TotalCost", "סך הכל לתשלום");
            dataGridView1.Columns.Add("SavingHours", "שעות שנחסכו");
            dataGridView1.Columns.Add("TotalSavings", "סך הכל חיסכון כספי");
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            DBConnector dbconnector = new DBConnector();
            var Month = Convert.ToInt32(MonthSelect.Text);
            var Year = Convert.ToInt32(YearSelect.Value.ToString());
            dbconnector.MonthPicker(Month, Year);
            dataGridView1.Rows.Add(dbconnector.totalHours);
        }

        private void MonthSwitch()
        {
            switch(MonthSelect.Text)
            {
                case "ינואר":
                    Month = 1;
                    break;
                case "פברואר":
                    Month = 2;
                    break;
                case "מרץ":
                    Month = 3;
                    break;
                case "אפריל":
                    Month = 4;
                    break;
                case "מאי":
                    Month = 5;
                    break;
                case "יוני":
                    Month = 6;
                    break;
                case "יולי":
                    Month = 7;
                    break;
                case "אוגוסט":
                    Month = 8;
                    break;
                case "ספטמבר":
                    Month = 9;
                    break;
                case "אוקטובר":
                    Month = 1;
                    break;
                case "נובמבר":
                    Month = 11;
                    break;
                case "דצמבר":
                    Month = 12;
                    break;
                default:
                    Month = 0;
                    break;
            }
        }
    }
}
