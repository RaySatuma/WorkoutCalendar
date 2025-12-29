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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Exercise_Type_Choose.Items.AddRange(new object[] { "慢走(4公里/小時)", "快走(6公里/小時)", "下樓梯", "上樓梯", "慢跑(8公里/小時)", "慢走(4公里/小時)", "快跑(16公里/小時)", "騎腳踏車(20公里/小時)", "瑜珈", "游泳(25公尺/60秒)" });//明天補齊
        }
    }
}
