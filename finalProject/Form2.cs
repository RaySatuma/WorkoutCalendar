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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //int Language_index = 0;
        private void button2_Click(object sender, EventArgs e)
        {
           this.Close();
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            //Form1.Language_Check();//括號內要傳入Form3當下的語言(Language setting from Form3)
            this.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Home_Language_Choose.DropDownStyle = ComboBoxStyle.DropDownList;
            Username_invisible.Visible = false;
            

            if(Home_Language_Text.Text == "Language")
            {
                Home_Language_Choose.Items.AddRange(new object[] { "English", "Chinese", "Japanese" });
                Home_Language_Choose.SelectedIndex = 0;

            }
            else if(Home_Language_Text.Text == "語言")
            {
                Home_Language_Choose.Items.AddRange(new object[] { "英文", "中文", "日文" });
                Home_Language_Choose.SelectedIndex = 1;
            }
            else if(Home_Language_Text.Text == "言語")
            {
                Home_Language_Choose.Items.AddRange(new object[] { "英語", "中国語", "日本語" });
                Home_Language_Choose.SelectedIndex = 2;
            }
            
        }

        private void Home_Language_Choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Home_Language_Choose.SelectedIndex == 0)
            {
                if (Home_Language_Text.Text != "Language")
                {
                    Home_Language_Text.Text = "Language";
                    Home_Language_Choose.Items.Clear();
                    Home_Language_Choose.Items.AddRange(new object[] { "English", "Chinese", "Japanese" });
                }
            }
            else if (Home_Language_Choose.SelectedIndex == 1)
            {
                if (Home_Language_Text.Text != "語言")
                {
                    Home_Language_Text.Text = "語言";
                    Home_Language_Choose.Items.Clear();
                    Home_Language_Choose.Items.AddRange(new object[] { "英文", "中文", "日文" });
                }
            }
            else if (Home_Language_Choose.SelectedIndex == 2)
            {
                if (Home_Language_Text.Text != "言語")
                {
                    Home_Language_Text.Text = "言語";
                    Home_Language_Choose.Items.Clear();
                    Home_Language_Choose.Items.AddRange(new object[] { "英語", "中国語", "日本語" });
                }
            }
        }

        private void First_Time_Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
