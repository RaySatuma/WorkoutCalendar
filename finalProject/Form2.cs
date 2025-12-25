using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
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

        public int Sex;
        public int Age;
        public float height;
        public float weight;
        int Age_temp;
        int Height_temp;
        int Weight_temp;

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

            First_time.Location = new Point(0, 0);
            First_time.Show();

            if (Home_Language_Text.Text == "Language")
            {
                Home_Language_Choose.Items.AddRange(new object[] { "English", "Chinese", "Japanese" });
                Home_Language_Choose.SelectedIndex = 0;

                First_Time_Text.Text = "Fill your person data!";
                Sex_choose.Items.AddRange(new object[] { "Bio sex","Male", "Female"});
                Bio_sex_Text.Text = "Bio sex";
                Age_Text.Text = "Age";
                Height_Text.Text = "Height(cm)";
                Weight_Text.Text = "Weight(kg)";
                Confirm_button.Text = "Confirm";
                First_Time_Back_Button.Text = "Back";
                
            }
            else if(Home_Language_Text.Text == "語言")
            {
                Home_Language_Choose.Items.AddRange(new object[] { "英文", "中文", "日文" });
                Home_Language_Choose.SelectedIndex = 1;

                First_Time_Text.Text = "請填寫您的個人資料！";
                Sex_choose.Items.AddRange(new object[] { "生理性別", "男性", "女性" });
                Bio_sex_Text.Text = "生理性別";
                Age_Text.Text = "年齡";
                Height_Text.Text = "身高(cm)";
                Weight_Text.Text = "體重(kg)";
                Confirm_button.Text = "確認";
                First_Time_Back_Button.Text = "返回";
            }
            else if(Home_Language_Text.Text == "言語")
            {
                Home_Language_Choose.Items.AddRange(new object[] { "英語", "中国語", "日本語" });
                Home_Language_Choose.SelectedIndex = 2;

                First_Time_Text.Text = "あなたの個人データを入力してください！";//(GitHub Copilot translation )
                Sex_choose.Items.AddRange(new object[] { "生物学的性別", "男性", "女性" });
                Bio_sex_Text.Text = "生物学的性別";
                Age_Text.Text = "年齢";
                Height_Text.Text = "身長(cm)";
                Weight_Text.Text = "体重(kg)";
                Confirm_button.Text = "確認する";
                First_Time_Back_Button.Text = "戻る";
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

        private void Confirm_button_Click(object sender, EventArgs e)
        {
            //string temp;
            if(Sex_choose.SelectedIndex != 0)
            {
                Sex = Sex_choose.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Please select your biological sex", "select bio sex", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if(int.TryParse(Age_box.Text, out Age) == false)
            {
                MessageBox.Show("Please select your biological sex", "select bio sex", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void Age_box_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Age_box.Text, out Age) == false)
            {
                MessageBox.Show("Please type your age in number", "age in number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Age_box.Text = Age_temp.ToString();
            }
            Age_temp = int.Parse(Age_box.Text);
        }

        private void Height_box_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Height_box.Text, out Age) == false)
            {
                MessageBox.Show("Please type your height in number", "Height in number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Height_box.Text = Height_temp.ToString();
            }
            Height_temp = int.Parse(Height_box.Text);
        }

        private void Weight_box_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Weight_box.Text, out Age) == false)
            {
                MessageBox.Show("Please type your weight in number", "Weight in number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Weight_box.Text = Weight_temp.ToString();
            }
            Weight_temp = int.Parse(Weight_box.Text);
        }
    }
}
