namespace finalProject
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Home_Language_Choose = new System.Windows.Forms.ComboBox();
            this.Home_Language_Text = new System.Windows.Forms.Label();
            this.First_time = new System.Windows.Forms.Panel();
            this.Username_invisible = new System.Windows.Forms.Label();
            this.Exercise_Level_Choose = new System.Windows.Forms.ComboBox();
            this.Exercise_Level_Text = new System.Windows.Forms.Label();
            this.Confirm_button = new System.Windows.Forms.Button();
            this.First_Time_Text = new System.Windows.Forms.Label();
            this.First_Time_Back_Button = new System.Windows.Forms.Button();
            this.Weight_box = new System.Windows.Forms.TextBox();
            this.Height_box = new System.Windows.Forms.TextBox();
            this.Age_box = new System.Windows.Forms.TextBox();
            this.Sex_choose = new System.Windows.Forms.ComboBox();
            this.Weight_Text = new System.Windows.Forms.Label();
            this.Height_Text = new System.Windows.Forms.Label();
            this.Age_Text = new System.Windows.Forms.Label();
            this.Bio_sex_Text = new System.Windows.Forms.Label();
            this.Basic_Cal_cunsumption_Text = new System.Windows.Forms.Label();
            this.First_time.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 108);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 18);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calendar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 108);
            this.button2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 18);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(369, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Home_Language_Choose
            // 
            this.Home_Language_Choose.FormattingEnabled = true;
            this.Home_Language_Choose.Location = new System.Drawing.Point(223, 3);
            this.Home_Language_Choose.Name = "Home_Language_Choose";
            this.Home_Language_Choose.Size = new System.Drawing.Size(121, 20);
            this.Home_Language_Choose.TabIndex = 3;
            this.Home_Language_Choose.SelectedIndexChanged += new System.EventHandler(this.Home_Language_Choose_SelectedIndexChanged);
            // 
            // Home_Language_Text
            // 
            this.Home_Language_Text.AutoSize = true;
            this.Home_Language_Text.Location = new System.Drawing.Point(136, 7);
            this.Home_Language_Text.Name = "Home_Language_Text";
            this.Home_Language_Text.Size = new System.Drawing.Size(33, 12);
            this.Home_Language_Text.TabIndex = 4;
            this.Home_Language_Text.Text = "label1";
            // 
            // First_time
            // 
            this.First_time.Controls.Add(this.Username_invisible);
            this.First_time.Controls.Add(this.Exercise_Level_Choose);
            this.First_time.Controls.Add(this.Exercise_Level_Text);
            this.First_time.Controls.Add(this.Confirm_button);
            this.First_time.Controls.Add(this.First_Time_Text);
            this.First_time.Controls.Add(this.First_Time_Back_Button);
            this.First_time.Controls.Add(this.Weight_box);
            this.First_time.Controls.Add(this.Height_box);
            this.First_time.Controls.Add(this.Age_box);
            this.First_time.Controls.Add(this.Sex_choose);
            this.First_time.Controls.Add(this.Weight_Text);
            this.First_time.Controls.Add(this.Height_Text);
            this.First_time.Controls.Add(this.Age_Text);
            this.First_time.Controls.Add(this.Bio_sex_Text);
            this.First_time.Location = new System.Drawing.Point(0, 0);
            this.First_time.Name = "First_time";
            this.First_time.Size = new System.Drawing.Size(369, 228);
            this.First_time.TabIndex = 5;
            // 
            // Username_invisible
            // 
            this.Username_invisible.AutoSize = true;
            this.Username_invisible.Location = new System.Drawing.Point(12, 7);
            this.Username_invisible.Name = "Username_invisible";
            this.Username_invisible.Size = new System.Drawing.Size(33, 12);
            this.Username_invisible.TabIndex = 6;
            this.Username_invisible.Text = "label1";
            // 
            // Exercise_Level_Choose
            // 
            this.Exercise_Level_Choose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Exercise_Level_Choose.FormattingEnabled = true;
            this.Exercise_Level_Choose.Location = new System.Drawing.Point(148, 188);
            this.Exercise_Level_Choose.Name = "Exercise_Level_Choose";
            this.Exercise_Level_Choose.Size = new System.Drawing.Size(121, 20);
            this.Exercise_Level_Choose.TabIndex = 12;
            this.Exercise_Level_Choose.DropDown += new System.EventHandler(this.Exercise_Level_Choose_DropDown);
            this.Exercise_Level_Choose.DropDownClosed += new System.EventHandler(this.Exercise_Level_Choose_DropDownClosed);
            // 
            // Exercise_Level_Text
            // 
            this.Exercise_Level_Text.AutoSize = true;
            this.Exercise_Level_Text.Location = new System.Drawing.Point(28, 191);
            this.Exercise_Level_Text.Name = "Exercise_Level_Text";
            this.Exercise_Level_Text.Size = new System.Drawing.Size(33, 12);
            this.Exercise_Level_Text.TabIndex = 11;
            this.Exercise_Level_Text.Text = "label4";
            // 
            // Confirm_button
            // 
            this.Confirm_button.Location = new System.Drawing.Point(288, 167);
            this.Confirm_button.Name = "Confirm_button";
            this.Confirm_button.Size = new System.Drawing.Size(75, 23);
            this.Confirm_button.TabIndex = 10;
            this.Confirm_button.Text = "button3";
            this.Confirm_button.UseVisualStyleBackColor = true;
            this.Confirm_button.Click += new System.EventHandler(this.Confirm_button_Click);
            // 
            // First_Time_Text
            // 
            this.First_Time_Text.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.First_Time_Text.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.First_Time_Text.Location = new System.Drawing.Point(30, 9);
            this.First_Time_Text.Name = "First_Time_Text";
            this.First_Time_Text.Size = new System.Drawing.Size(314, 27);
            this.First_Time_Text.TabIndex = 9;
            this.First_Time_Text.Text = "label1";
            this.First_Time_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // First_Time_Back_Button
            // 
            this.First_Time_Back_Button.Location = new System.Drawing.Point(288, 196);
            this.First_Time_Back_Button.Name = "First_Time_Back_Button";
            this.First_Time_Back_Button.Size = new System.Drawing.Size(75, 23);
            this.First_Time_Back_Button.TabIndex = 8;
            this.First_Time_Back_Button.Text = "button3";
            this.First_Time_Back_Button.UseVisualStyleBackColor = true;
            this.First_Time_Back_Button.Click += new System.EventHandler(this.First_Time_Back_Button_Click);
            // 
            // Weight_box
            // 
            this.Weight_box.Location = new System.Drawing.Point(148, 154);
            this.Weight_box.Name = "Weight_box";
            this.Weight_box.Size = new System.Drawing.Size(121, 22);
            this.Weight_box.TabIndex = 7;
            this.Weight_box.TextChanged += new System.EventHandler(this.Weight_box_TextChanged);
            // 
            // Height_box
            // 
            this.Height_box.Location = new System.Drawing.Point(148, 122);
            this.Height_box.Name = "Height_box";
            this.Height_box.Size = new System.Drawing.Size(121, 22);
            this.Height_box.TabIndex = 6;
            this.Height_box.TextChanged += new System.EventHandler(this.Height_box_TextChanged);
            // 
            // Age_box
            // 
            this.Age_box.Location = new System.Drawing.Point(148, 88);
            this.Age_box.Name = "Age_box";
            this.Age_box.Size = new System.Drawing.Size(121, 22);
            this.Age_box.TabIndex = 5;
            this.Age_box.TextChanged += new System.EventHandler(this.Age_box_TextChanged);
            // 
            // Sex_choose
            // 
            this.Sex_choose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sex_choose.FormattingEnabled = true;
            this.Sex_choose.Location = new System.Drawing.Point(148, 55);
            this.Sex_choose.Name = "Sex_choose";
            this.Sex_choose.Size = new System.Drawing.Size(121, 20);
            this.Sex_choose.TabIndex = 4;
            // 
            // Weight_Text
            // 
            this.Weight_Text.AutoSize = true;
            this.Weight_Text.Location = new System.Drawing.Point(28, 159);
            this.Weight_Text.Name = "Weight_Text";
            this.Weight_Text.Size = new System.Drawing.Size(33, 12);
            this.Weight_Text.TabIndex = 3;
            this.Weight_Text.Text = "label4";
            // 
            // Height_Text
            // 
            this.Height_Text.AutoSize = true;
            this.Height_Text.Location = new System.Drawing.Point(28, 128);
            this.Height_Text.Name = "Height_Text";
            this.Height_Text.Size = new System.Drawing.Size(33, 12);
            this.Height_Text.TabIndex = 2;
            this.Height_Text.Text = "label3";
            // 
            // Age_Text
            // 
            this.Age_Text.AutoSize = true;
            this.Age_Text.Location = new System.Drawing.Point(28, 94);
            this.Age_Text.Name = "Age_Text";
            this.Age_Text.Size = new System.Drawing.Size(33, 12);
            this.Age_Text.TabIndex = 1;
            this.Age_Text.Text = "label2";
            // 
            // Bio_sex_Text
            // 
            this.Bio_sex_Text.AutoSize = true;
            this.Bio_sex_Text.Location = new System.Drawing.Point(28, 60);
            this.Bio_sex_Text.Name = "Bio_sex_Text";
            this.Bio_sex_Text.Size = new System.Drawing.Size(33, 12);
            this.Bio_sex_Text.TabIndex = 0;
            this.Bio_sex_Text.Text = "label1";
            // 
            // Basic_Cal_cunsumption_Text
            // 
            this.Basic_Cal_cunsumption_Text.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Basic_Cal_cunsumption_Text.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Basic_Cal_cunsumption_Text.Location = new System.Drawing.Point(108, 155);
            this.Basic_Cal_cunsumption_Text.Name = "Basic_Cal_cunsumption_Text";
            this.Basic_Cal_cunsumption_Text.Size = new System.Drawing.Size(142, 23);
            this.Basic_Cal_cunsumption_Text.TabIndex = 6;
            this.Basic_Cal_cunsumption_Text.Text = "label1";
            this.Basic_Cal_cunsumption_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 225);
            this.Controls.Add(this.First_time);
            this.Controls.Add(this.Home_Language_Text);
            this.Controls.Add(this.Home_Language_Choose);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Basic_Cal_cunsumption_Text);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Form2";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.First_time.ResumeLayout(false);
            this.First_time.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ComboBox Home_Language_Choose;
        public System.Windows.Forms.Label Home_Language_Text;
        public System.Windows.Forms.Panel First_time;
        private System.Windows.Forms.Label Weight_Text;
        private System.Windows.Forms.Label Height_Text;
        private System.Windows.Forms.Label Age_Text;
        private System.Windows.Forms.Label Bio_sex_Text;
        private System.Windows.Forms.Button First_Time_Back_Button;
        private System.Windows.Forms.TextBox Weight_box;
        private System.Windows.Forms.TextBox Height_box;
        private System.Windows.Forms.TextBox Age_box;
        private System.Windows.Forms.ComboBox Sex_choose;
        private System.Windows.Forms.Label First_Time_Text;
        public System.Windows.Forms.Label Username_invisible;
        private System.Windows.Forms.Button Confirm_button;
        private System.Windows.Forms.ComboBox Exercise_Level_Choose;
        private System.Windows.Forms.Label Exercise_Level_Text;
        private System.Windows.Forms.Label Basic_Cal_cunsumption_Text;
    }
}