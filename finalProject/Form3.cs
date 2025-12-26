using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{
    public partial class Form3 : Form
    {
        public static int _year,_month;
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(800, 600);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            this.Hide();
            form4.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tblCal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void showDays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year; 
             _month = month;

            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            lbMonth.Text = monthName.ToUpper() + " " + year;
            DateTime startodTheMonth = new DateTime(year, month,1);
            int day = DateTime.DaysInMonth(year,month);
            int week = Convert.ToInt32(startodTheMonth.DayOfWeek.ToString("d"));
            for(int i = 1; i< week; i++)
            {
                ucDay uc = new ucDay("");
                flowLayoutPanel1.Controls.Add(uc);
            }
            for (int i = 1; i < day; i++)
            {
                ucDay uc = new ucDay(i + "");
                flowLayoutPanel1.Controls.Add(uc);
            }
        } 

    }
}
