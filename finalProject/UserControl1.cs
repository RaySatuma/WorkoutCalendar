using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{

    public partial class ucDay : UserControl

    {
        string _day, date, weekday;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public ucDay(string day)
        {
            InitializeComponent();
            _day = day;
            label1.Text = day;
            date = Form3._month + "/" + _day + "/" + Form3._year;
           SturdaysAndSundays();
            
            label1.Click += ClickDay;
            panel1.Click += ClickDay;
        
        }

        private void ClickDay(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_day)) return;
            base.OnClick(e);
                }

        private void SturdaysAndSundays()
        {
            if (string.IsNullOrWhiteSpace(_day))
            {
                label1.ForeColor = Color.FromArgb(64, 64, 64);
                return;
            }

            if (!int.TryParse(_day, out int d))
                return;

            
            var dt = new DateTime(Form3._year, Form3._month, d);

            if (dt.DayOfWeek == DayOfWeek.Sunday)
                label1.ForeColor = Color.FromArgb(255, 128, 128);
            else if (dt.DayOfWeek == DayOfWeek.Saturday)
                label1.ForeColor = Color.FromArgb(128, 128, 255);
            else
                label1.ForeColor = Color.FromArgb(64, 64, 64);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
