using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{
   
    public partial class Form2 : Form
    {
        private bool _isLanguageSelected = false;
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
        public int Exercise_Level;
        public double[] Exercise_Level_Multiplier = {1.2, 1.375, 1.55, 1.725, 1.9};
        int Age_temp;
        float Height_temp;
        float Weight_temp;
        bool Cal_Counted = false;

        public int Daily_Calorie_Cunsumption;

        private void F2Language_Setup()
        {
            _isLanguageSelected = true;

            Home_Language_Choose.Items.Clear();
            Sex_choose.Items.Clear();
            Exercise_Level_Choose.Items.Clear();

            if (Home_Language_Text.Text == "Language")
            {
                Home_Language_Choose.Items.AddRange(new object[] { "English", "Chinese", "Japanese" });
                Home_Language_Choose.SelectedIndex = 0;

                First_Time_Text.Text = "Fill your person data!";
                Sex_choose.Items.AddRange(new object[] { "Bio sex", "Male", "Female" });
                Bio_sex_Text.Text = "Bio sex";
                Age_Text.Text = "Age";
                Height_Text.Text = "Height(cm)";
                Weight_Text.Text = "Weight(kg)";
                Confirm_button.Text = "Confirm";
                First_Time_Back_Button.Text = "Back";
                Exercise_Level_Text.Text = "Weekly Activity Level";
                Exercise_Level_Choose.Items.AddRange(new object[] {
            "Sedentary\n(No extra exercise)",
            "Lightly active\n(exercise 1~3 times per week)",
            "Moderately active\n(exercise 4~5 times per week)",
            "Very active\n(exercise 6~7 times per week)",
            "Extra active\n(Intense daily exercise / physical labor)"
        });
                Basic_Cal_cunsumption_Text.Text = "Your daily calorie Cunsumption is " + Daily_Calorie_Cunsumption.ToString() + " kcal";
                To_Calendar_Button.Text = "Calendar";
                Back_To_Start_Button.Text = "Back";
            }
            else if (Home_Language_Text.Text == "語言")
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
                Exercise_Level_Text.Text = "每周活動量";
                Exercise_Level_Choose.Items.AddRange(new object[] {
            "久坐不動\n(幾乎不動)",
            "輕度活動\n(每週運動1~3天)",
            "中度活動\n(每週運動4~5天)",
            "高度活動\n(每週運動6~7天)",
            "超級活躍\n(每天激烈運動/體力勞動)"
        });
                Basic_Cal_cunsumption_Text.Text = "您的今日卡路里消耗為 " + Daily_Calorie_Cunsumption.ToString() + " 大卡";
                To_Calendar_Button.Text = "日曆";
                Back_To_Start_Button.Text = "返回";
            }
            else if (Home_Language_Text.Text == "言語")
            {
                Home_Language_Choose.Items.AddRange(new object[] { "英語", "中国語", "日本語" });
                Home_Language_Choose.SelectedIndex = 2;

                First_Time_Text.Text = "あなたの個人データを入力してください！";
                Sex_choose.Items.AddRange(new object[] { "生物学的性別", "男性", "女性" });
                Bio_sex_Text.Text = "生物学的性別";
                Age_Text.Text = "年齢";
                Height_Text.Text = "身長(cm)";
                Weight_Text.Text = "体重(kg)";
                Confirm_button.Text = "確認する";
                First_Time_Back_Button.Text = "戻る";
                Exercise_Level_Text.Text = "週間活動レベル";
                Exercise_Level_Choose.Items.AddRange(new object[] {
            "座りがち\n(ほとんど運動しない)",
             "軽度に活動的\n(週に1〜3回運動する)",
            "適度に活動的\n(週に4〜5回運動する)",
            "非常に活動的\n(週に6〜7回運動する)",
            "非常に活発\n(毎日激しい運動/肉体労働)"
        });
                Basic_Cal_cunsumption_Text.Text = "1日のカロリー必要量は " + Daily_Calorie_Cunsumption.ToString() + " カロリーです";
                To_Calendar_Button.Text = "カレンダー";
                Back_To_Start_Button.Text = "戻る";
            }

            _isLanguageSelected = false; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Language_temp = Home_Language_Text.Text;
            form3.Cal_temp = Daily_Calorie_Cunsumption;
            form3.Weight_temp = weight;
            this.Hide();
            form3.ShowDialog();
            Daily_Calorie_Cunsumption = form3.Cal_temp;
            if (Home_Language_Text.Text == "Language")
            {
                Basic_Cal_cunsumption_Text.Text = "Your daily calorie Cunsumption is " + Daily_Calorie_Cunsumption.ToString() + " kcal";
            }
            else if (Home_Language_Text.Text == "語言")
            {
                Basic_Cal_cunsumption_Text.Text = "您的今日卡路里消耗為 " + Daily_Calorie_Cunsumption.ToString() + " 大卡";
            }
            else if (Home_Language_Text.Text == "言語")
            {
                Basic_Cal_cunsumption_Text.Text = "1日のカロリー必要量は " + Daily_Calorie_Cunsumption.ToString() + " カロリーです";
            }
            this.Show();

            Cal_Counted = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Home_Language_Choose.DropDownStyle = ComboBoxStyle.DropDownList;
            Username_invisible.Visible = false;

            var (name, lang, sex, age, h, w, ex) = AppStorage.Load();

            Home_Language_Text.Text = lang;

            First_time.Location = new Point(0, 0);
            First_time.Show();

            F2Language_Setup();
            
            Age_box.Text = age == 0 ? "" : age.ToString();
            Height_box.Text = h == 0 ? "" : h.ToString(CultureInfo.InvariantCulture);
            Weight_box.Text = w == 0 ? "" : w.ToString(CultureInfo.InvariantCulture);

            if (sex >= 0 && sex < Sex_choose.Items.Count) Sex_choose.SelectedIndex = sex;
            if (ex >= 0 && ex < Exercise_Level_Choose.Items.Count) Exercise_Level_Choose.SelectedIndex = ex;
        }



        private void Daily_Calorie()
        {
            if(Sex == 1)
            {
                Daily_Calorie_Cunsumption = (int)((10 * weight) + (6.25 * height) - (5 * Age) + 5);
            }
            else if(Sex == 2)
            {
                Daily_Calorie_Cunsumption = (int)((10 * weight) + (6.25 * height) - (5 * Age) - 161);
            }
            Daily_Calorie_Cunsumption = (int)(Daily_Calorie_Cunsumption * Exercise_Level_Multiplier[Exercise_Level]);

        }
        private void Home_Language_Choose_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (_isLanguageSelected) return;
            if (Home_Language_Choose.SelectedIndex == 0)
            {
                if (Home_Language_Text.Text != "Language")
                {
                    Home_Language_Text.Text = "Language";
                }
            }
            else if (Home_Language_Choose.SelectedIndex == 1)
            {
                if (Home_Language_Text.Text != "語言")
                {
                    Home_Language_Text.Text = "語言";
                }
            }
            else if (Home_Language_Choose.SelectedIndex == 2)
            {
                if (Home_Language_Text.Text != "言語")
                {
                    Home_Language_Text.Text = "言語";
                }
            }
            F2Language_Setup();
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
                if (Age_box.Text != "" && Height_box.Text != "" && Weight_box.Text != "")
                {
                    Exercise_Level = Exercise_Level_Choose.SelectedIndex;
                    AppStorage.SaveBody(Sex, Age, height, weight, Exercise_Level);
                    AppStorage.SaveProfile(Username_invisible.Text, Home_Language_Text.Text);

                    if (Cal_Counted == false)
                    {
                        Daily_Calorie();
                        Cal_Counted = true;
                    }

                    if (Home_Language_Text.Text == "Language")
                    {
                        Basic_Cal_cunsumption_Text.Text = "Your daily calorie Cunsumption is " + Daily_Calorie_Cunsumption.ToString() + " kcal";
                    }
                    else if (Home_Language_Text.Text == "語言")
                    {
                        Basic_Cal_cunsumption_Text.Text = "您的今日卡路里消耗為 " + Daily_Calorie_Cunsumption.ToString() + " 大卡";
                    }
                    else if (Home_Language_Text.Text == "言語")
                    {
                        Basic_Cal_cunsumption_Text.Text = "1日のカロリー必要量は " + Daily_Calorie_Cunsumption.ToString() + " カロリーです";
                    }
                    First_time.Hide();
                    //button1_Click(sender, e);
                }
                else
                {
                    if (Home_Language_Text.Text == "Language")//AI told me, but it seems ok here .w.
                    {
                        MessageBox.Show("Please fill in all the blanks", "fill in all blanks", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (Home_Language_Text.Text == "語言")
                    {
                        MessageBox.Show("請填寫所有空格", "填寫所有空格", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (Home_Language_Text.Text == "言語")
                    {
                        MessageBox.Show("すべての空欄に記入してください", "すべての空欄に記入してください", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (Home_Language_Text.Text == "Language")
                {
                    MessageBox.Show("Please select your biological sex", "select bio sex", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Home_Language_Text.Text == "語言")
                {
                    MessageBox.Show("請選擇您的生理性別", "選擇生理性別", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Home_Language_Text.Text == "言語")
                {
                    MessageBox.Show("あなたの生物学的性別を選択してください", "生物学的性別を選択してください", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Age_box_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Age_box.Text, out Age) == false && Age_box.Text != "")
            {
                if (Home_Language_Text.Text == "Language")
                {
                    MessageBox.Show("Please type your age in number", "age in number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Home_Language_Text.Text == "語言")
                {
                    MessageBox.Show("請以阿拉伯數字填寫年齡", "用數字輸入年齡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Home_Language_Text.Text == "言語")
                {
                    MessageBox.Show("年齢を数字で入力してください", "数字で年齢を入力してください", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Age_box.Text = Age_temp.ToString();
            }
            else if (int.TryParse(Age_box.Text, out Age) == true && Age_box.Text != "")
            {
                Age_temp = int.Parse(Age_box.Text);
            }
        }

        private void Height_box_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(Height_box.Text, out height) == false && Height_box.Text !="")
            {
                if (Home_Language_Text.Text == "Language")
                {
                    MessageBox.Show("Please type your height in number(cm)", "Height in number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Home_Language_Text.Text == "語言")
                {
                    MessageBox.Show("請以阿拉伯數字填寫身高(公分)", "用數字輸入身高", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Home_Language_Text.Text == "言語")
                {
                    MessageBox.Show("身長を数字で入力してください（cm）", "数字で身長を入力してください", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Height_box.Text = Height_temp.ToString();
            }
            else if(float.TryParse(Height_box.Text, out height) == true && Height_box.Text != "")
            {
                Height_temp = float.Parse(Height_box.Text);
            } 
        }

        private void Weight_box_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(Weight_box.Text, out weight) == false && Weight_box.Text != "")
            {
                if (Home_Language_Text.Text == "Language")
                {
                    MessageBox.Show("Please type your weight in number(Kg)", "weight in number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Home_Language_Text.Text == "語言")
                {
                    MessageBox.Show("請以阿拉伯數字填寫體重(公斤)", "用數字輸入體重", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Home_Language_Text.Text == "言語")
                {
                    MessageBox.Show("体重を数字で入力してください（kg）", "数字で体重を入力してください", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Weight_box.Text = Weight_temp.ToString();
            }
            else if(float.TryParse(Weight_box.Text, out weight) == false && Weight_box.Text != "")
            {
                Weight_temp = float.Parse(Weight_box.Text);
            } 
        }

        private void Exercise_Level_Choose_DropDown(object sender, EventArgs e)
        {
            // 何もしなくてOK
        }

        private void Exercise_Level_Choose_DropDownClosed(object sender, EventArgs e)
        {
            // 何もしなくてOK
        }

    }

}
