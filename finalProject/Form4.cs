using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace finalProject
{
    public partial class Form4 : Form
    {
        public DateTime SelectedDate;
        public Form4()
        {
            InitializeComponent();
        }
        int Exe_temp;
        int Exercise_Time = 0;
        public double F4_User_Weight;
        public double Exercise_Calorie;
        public int cal_from_F2;
        public string F4_Language;
        private void button1_Click(object sender, EventArgs e)
        {
            switch (Exercise_Type_Choose.SelectedIndex)
            {
                case 0:
                    {
                        Exercise_Calorie = Math.Round(3.5 * Exercise_Time / 60 * F4_User_Weight);
                        break;
                    }
                case 1:
                    {
                        Exercise_Calorie = Math.Round(5.5 * Exercise_Time / 60 * F4_User_Weight);
                        break;
                    }
                case 2:
                    {
                        Exercise_Calorie = Math.Round(3.2 * Exercise_Time / 60 * F4_User_Weight);
                        break;
                    }
                case 3:
                    {
                        Exercise_Calorie = Math.Round(8.4 * Exercise_Time / 60 * F4_User_Weight);
                        break;
                    }
                case 4:
                    {
                        Exercise_Calorie = Math.Round(8.2 * Exercise_Time / 60 * F4_User_Weight);
                        break;
                    }
                case 5:
                    {
                        Exercise_Calorie = Math.Round(16.8 * Exercise_Time / 60 * F4_User_Weight);
                        break;
                    }
                case 6:
                    {
                        Exercise_Calorie = Math.Round(8.4 * Exercise_Time / 60 * F4_User_Weight);
                        break;
                    }
                case 7:
                    {
                        Exercise_Calorie = Math.Round(3 * Exercise_Time / 60 * F4_User_Weight);
                        break;
                    }
                case 8:
                    {
                        Exercise_Calorie = Math.Round(6.3 * Exercise_Time / 60 * F4_User_Weight);
                        break;
                    }
                case 9:
                    {
                        Exercise_Calorie = Math.Round(6.6 * Exercise_Time / 60 * F4_User_Weight);
                        break;
                    }
            }
            cal_from_F2 = cal_from_F2 + (int)Exercise_Calorie;
            //this.Close();
            SaveMemo();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Exercise_Type_Choose.Items.Clear();
            Exercise_Time_Text.Text = "";
            
            if (F4_Language == "Language")
            {
                Exercise_Type_Choose.Items.AddRange(new object[] { "Walking (4 km/h)", "Brisk walking (6 km/h)", "Going downstairs", "Going upstairs", "Jogging (8 km/h)", "Running (16 km/h)", "Cycling (20 km/h)", "Yoga", "Swimming (25 meters/60 seconds)", "Tennis" });
                Exercise_Type_Text.Text = "Exercise Type";
                Exercise_Time_Text.Text = "Exercise Duration(min)";
                F4_Back_Button.Text = "Back";
                
            }
            else if (F4_Language == "語言")
            {
                Exercise_Type_Choose.Items.AddRange(new object[] { "慢走(4公里/小時)", "快走(6公里/小時)", "下樓梯", "上樓梯", "慢跑(8公里/小時)", "快跑(16公里/小時)", "騎腳踏車(20公里/小時)", "瑜珈", "游泳(25公尺/60秒)", "網球" });
                Exercise_Type_Text.Text = "運動類型";
                Exercise_Time_Text.Text = "運動時長(分)";
                F4_Back_Button.Text = "返回";
                
            }
            else if (F4_Language == "言語")
            {
                Exercise_Type_Choose.Items.AddRange(new object[] { "ウォーキング (4 km/h)", "速歩 (6 km/h)", "階段を降りる", "階段を上る", "ジョギング (8 km/h)", "ランニング (16 km/h)", "サイクリング (20 km/h)", "ヨガ", "水泳 (25メートル/60秒)", "テニス" });
                Exercise_Type_Text.Text = "運動の種類";
                Exercise_Time_Text.Text = "運動時間(分)";
                F4_Back_Button.Text = "戻る";
                
            }
            this.Text = $"Record - {SelectedDate:yyyy-MM-dd}";
            //this.Close();
            if (File.Exists(MemoPath()))
            {
                richTextBox1.Text = File.ReadAllText(MemoPath());
            }
        }

        private void F4_Confirm_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void Exercise_Time_box_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Exercise_Time_box.Text, out Exe_temp) == false && Exercise_Time_box.Text !="")
            {
                if (F4_Language == "Language")
                {
                    MessageBox.Show("Please type your age in number", "age in number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (F4_Language == "語言")
                {
                    MessageBox.Show("請以阿拉伯數字填寫年齡", "用數字輸入年齡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (F4_Language == "言語")
                {
                    MessageBox.Show("年齢を数字で入力してください", "数字で年齢を入力してください", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Exercise_Time_box.Text = Exe_temp.ToString();
            }
            else if (int.TryParse(Exercise_Time_box.Text, out Exe_temp) == true && Exercise_Time_box.Text != "")
            {
                Exercise_Time = int.Parse(Exercise_Time_box.Text);
            }
            
        }

        private string MemoPath()
        {
            var dir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "finalProject",
                "memos"
            );
            Directory.CreateDirectory(dir);
            return Path.Combine(dir, $"{SelectedDate:yyyy-MM-dd}.txt");
        }

        private void SaveMemo()
        {
            var path = MemoPath();


            if (IsAllEmpty())

            {
                if (File.Exists(path))
                    File.Delete(path);
                return;
            }

           
            File.WriteAllText(path, richTextBox1.Text ?? "");
        }

        private void F4_Back_Button_Click(object sender, EventArgs e)
        {
            SaveMemo();
            this.Close();
        }

        private bool IsAllEmpty()
        {
           
            bool memoEmpty = string.IsNullOrWhiteSpace(richTextBox1.Text);

            bool timeEmpty = string.IsNullOrWhiteSpace(Exercise_Time_box.Text);
            bool typeEmpty = (Exercise_Type_Choose.SelectedIndex < 0);

            
                                                                         

            return memoEmpty && timeEmpty && typeEmpty;
        }

    }
}
