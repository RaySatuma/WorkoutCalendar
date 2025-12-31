namespace finalProject
{
    partial class Form4
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
            this.F4_Back_Button = new System.Windows.Forms.Button();
            this.Exercise_Time_box = new System.Windows.Forms.TextBox();
            this.Exercise_Type_Choose = new System.Windows.Forms.ComboBox();
            this.Exercise_Time_Text = new System.Windows.Forms.Label();
            this.Exercise_Type_Text = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // F4_Back_Button
            // 
            this.F4_Back_Button.Location = new System.Drawing.Point(283, 726);
            this.F4_Back_Button.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.F4_Back_Button.Name = "F4_Back_Button";
            this.F4_Back_Button.Size = new System.Drawing.Size(191, 52);
            this.F4_Back_Button.TabIndex = 0;
            this.F4_Back_Button.Text = "Back";
            this.F4_Back_Button.UseVisualStyleBackColor = true;
            this.F4_Back_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exercise_Time_box
            // 
            this.Exercise_Time_box.Location = new System.Drawing.Point(358, 204);
            this.Exercise_Time_box.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Exercise_Time_box.Name = "Exercise_Time_box";
            this.Exercise_Time_box.Size = new System.Drawing.Size(329, 31);
            this.Exercise_Time_box.TabIndex = 13;
            this.Exercise_Time_box.TextChanged += new System.EventHandler(this.Exercise_Time_box_TextChanged);
            // 
            // Exercise_Type_Choose
            // 
            this.Exercise_Type_Choose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Exercise_Type_Choose.FormattingEnabled = true;
            this.Exercise_Type_Choose.Location = new System.Drawing.Point(358, 138);
            this.Exercise_Type_Choose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Exercise_Type_Choose.Name = "Exercise_Type_Choose";
            this.Exercise_Type_Choose.Size = new System.Drawing.Size(329, 32);
            this.Exercise_Type_Choose.TabIndex = 12;
            // 
            // Exercise_Time_Text
            // 
            this.Exercise_Time_Text.AutoSize = true;
            this.Exercise_Time_Text.Location = new System.Drawing.Point(98, 216);
            this.Exercise_Time_Text.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Exercise_Time_Text.Name = "Exercise_Time_Text";
            this.Exercise_Time_Text.Size = new System.Drawing.Size(67, 24);
            this.Exercise_Time_Text.TabIndex = 11;
            this.Exercise_Time_Text.Text = "label2";
            // 
            // Exercise_Type_Text
            // 
            this.Exercise_Type_Text.AutoSize = true;
            this.Exercise_Type_Text.Location = new System.Drawing.Point(98, 148);
            this.Exercise_Type_Text.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Exercise_Type_Text.Name = "Exercise_Type_Text";
            this.Exercise_Type_Text.Size = new System.Drawing.Size(67, 24);
            this.Exercise_Type_Text.TabIndex = 10;
            this.Exercise_Type_Text.Text = "label1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(117, 307);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(570, 373);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 802);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Exercise_Time_box);
            this.Controls.Add(this.Exercise_Type_Choose);
            this.Controls.Add(this.Exercise_Time_Text);
            this.Controls.Add(this.Exercise_Type_Text);
            this.Controls.Add(this.F4_Back_Button);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form4";
            this.Text = "Record";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button F4_Back_Button;
        private System.Windows.Forms.TextBox Exercise_Time_box;
        private System.Windows.Forms.ComboBox Exercise_Type_Choose;
        private System.Windows.Forms.Label Exercise_Time_Text;
        private System.Windows.Forms.Label Exercise_Type_Text;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}