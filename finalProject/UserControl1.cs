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
        string _day,date,weekday;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public ucDay(string day)
        {
            InitializeComponent();
            day = _day;
            label1.Text = day;
            date = Form3._month + "/" + _day + "/" + Form3._year;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
