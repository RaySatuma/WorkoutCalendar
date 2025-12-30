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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //int Language_index = 0;

        public void Language_Check(string lang)
        {
            if (lang == "Language")
            {
                UserName_Text.Text = "Username";
                Language_text.Text = "Language";
                Start_Button.Text = "Start";
                Language_Choose.Items.Clear();
                Language_Choose.Items.AddRange(new object[] { "English", "Chinese", "Japanese" });
                Language_Choose.SelectedIndex = 0;
            }
            else if (lang == "語言")
            {
                UserName_Text.Text = "用戶名";
                Language_text.Text = "語言";
                Start_Button.Text = "開始使用";
                Language_Choose.Items.Clear();
                Language_Choose.Items.AddRange(new object[] { "英文", "中文", "日文" });
                Language_Choose.SelectedIndex = 1;
            }
            else if (lang == "言語")
            {
                UserName_Text.Text = "ユーザー名";//Translated by GitHub Copilot
                Language_text.Text = "言語";
                Start_Button.Text = "スタート";
                Language_Choose.Items.Clear();
                Language_Choose.Items.AddRange(new object[] { "英語", "中国語", "日本語" });
                Language_Choose.SelectedIndex = 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Home_Page = new Form2();
            this.Hide();

            AppStorage.SaveProfile(Username_Box.Text, Language_text.Text);
            Home_Page.Home_Language_Text.Text = Language_text.Text;
            Home_Page.Username_invisible.Text = Username_Box.Text;
            //從儲存文件讀取使用者名稱，如果有的話就直接進入主畫面；如果沒有就進入First_Time的畫面
            
            Home_Page.ShowDialog();
            Language_Check(Home_Page.Home_Language_Text.Text);
            this.Show();
            AppStorage.SaveProfile(Username_Box.Text, Language_text.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var (name, lang, sex, age, h, w, ex) = AppStorage.Load();

            Language_Check(lang); 

            
            Username_Box.Text = name ?? "";

            Language_Choose.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Languaue_Choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Language_text.Text = Languaue_Choose.SelectedIndex.ToString();

            if (Language_Choose.SelectedIndex == 0)
            {
                if (Language_text.Text != "Language")
                {
                    UserName_Text.Text = "Username";
                    Language_text.Text = "Language";
                    Start_Button.Text = "Start";
                    //Language_index = 0;
                    Language_Choose.Items.Clear();
                    Language_Choose.Items.AddRange(new object[] { "English", "Chinese", "Japanese" });
                    Language_Choose.SelectedIndex = 0;
                }   
            }
            else if (Language_Choose.SelectedIndex == 1)
            {
                if (Language_text.Text != "語言")
                {
                    UserName_Text.Text = "用戶名";
                    Language_text.Text = "語言";
                    Start_Button.Text = "開始使用";
                    //Language_index = 1;
                    Language_Choose.Items.Clear();
                    Language_Choose.Items.AddRange(new object[] { "英文", "中文", "日文" });
                    Language_Choose.SelectedIndex = 1;
                }
            }
            else if (Language_Choose.SelectedIndex == 2)
            {
                if(Language_text.Text != "言語")
                {
                    UserName_Text.Text = "ユーザー名";//Translated by GitHub Copilot
                    Language_text.Text = "言語";
                    Start_Button.Text = "スタート";
                    //Language_index = 2;
                    Language_Choose.Items.Clear();
                    Language_Choose.Items.AddRange(new object[] { "英語", "中国語", "日本語" });
                    Language_Choose.SelectedIndex = 2;
                }
            }
            AppStorage.SaveProfile(Username_Box.Text, Language_text.Text);
        }
    }
}
