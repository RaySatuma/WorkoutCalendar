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
            this.Bio_sex_Text = new System.Windows.Forms.Label();
            this.Age_Text = new System.Windows.Forms.Label();
            this.Height_Text = new System.Windows.Forms.Label();
            this.Weight_Text = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.First_Time_Back_Button = new System.Windows.Forms.Button();
            this.First_Time_Text = new System.Windows.Forms.Label();
            this.Username_invisible = new System.Windows.Forms.Label();
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
            this.First_time.Controls.Add(this.First_Time_Text);
            this.First_time.Controls.Add(this.First_Time_Back_Button);
            this.First_time.Controls.Add(this.textBox3);
            this.First_time.Controls.Add(this.textBox2);
            this.First_time.Controls.Add(this.textBox1);
            this.First_time.Controls.Add(this.comboBox1);
            this.First_time.Controls.Add(this.Weight_Text);
            this.First_time.Controls.Add(this.Height_Text);
            this.First_time.Controls.Add(this.Age_Text);
            this.First_time.Controls.Add(this.Bio_sex_Text);
            this.First_time.Location = new System.Drawing.Point(358, 219);
            this.First_time.Name = "First_time";
            this.First_time.Size = new System.Drawing.Size(369, 228);
            this.First_time.TabIndex = 5;
            // 
            // Bio_sex_Text
            // 
            this.Bio_sex_Text.AutoSize = true;
            this.Bio_sex_Text.Location = new System.Drawing.Point(60, 60);
            this.Bio_sex_Text.Name = "Bio_sex_Text";
            this.Bio_sex_Text.Size = new System.Drawing.Size(33, 12);
            this.Bio_sex_Text.TabIndex = 0;
            this.Bio_sex_Text.Text = "label1";
            // 
            // Age_Text
            // 
            this.Age_Text.AutoSize = true;
            this.Age_Text.Location = new System.Drawing.Point(60, 100);
            this.Age_Text.Name = "Age_Text";
            this.Age_Text.Size = new System.Drawing.Size(33, 12);
            this.Age_Text.TabIndex = 1;
            this.Age_Text.Text = "label2";
            // 
            // Height_Text
            // 
            this.Height_Text.AutoSize = true;
            this.Height_Text.Location = new System.Drawing.Point(60, 140);
            this.Height_Text.Name = "Height_Text";
            this.Height_Text.Size = new System.Drawing.Size(33, 12);
            this.Height_Text.TabIndex = 2;
            this.Height_Text.Text = "label3";
            // 
            // Weight_Text
            // 
            this.Weight_Text.AutoSize = true;
            this.Weight_Text.Location = new System.Drawing.Point(60, 180);
            this.Weight_Text.Name = "Weight_Text";
            this.Weight_Text.Size = new System.Drawing.Size(33, 12);
            this.Weight_Text.TabIndex = 3;
            this.Weight_Text.Text = "label4";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 22);
            this.textBox3.TabIndex = 7;
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
            // First_Time_Text
            // 
            this.First_Time_Text.AutoSize = true;
            this.First_Time_Text.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.First_Time_Text.Location = new System.Drawing.Point(146, 12);
            this.First_Time_Text.Name = "First_Time_Text";
            this.First_Time_Text.Size = new System.Drawing.Size(71, 27);
            this.First_Time_Text.TabIndex = 9;
            this.First_Time_Text.Text = "label1";
            // 
            // Username_invisible
            // 
            this.Username_invisible.AutoSize = true;
            this.Username_invisible.Location = new System.Drawing.Point(13, 201);
            this.Username_invisible.Name = "Username_invisible";
            this.Username_invisible.Size = new System.Drawing.Size(33, 12);
            this.Username_invisible.TabIndex = 6;
            this.Username_invisible.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 225);
            this.Controls.Add(this.Username_invisible);
            this.Controls.Add(this.First_time);
            this.Controls.Add(this.Home_Language_Text);
            this.Controls.Add(this.Home_Language_Choose);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label First_Time_Text;
        public System.Windows.Forms.Label Username_invisible;
    }
}