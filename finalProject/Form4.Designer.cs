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
            this.button1 = new System.Windows.Forms.Button();
            this.Exercise_Time_box = new System.Windows.Forms.TextBox();
            this.Exercise_Type_Choose = new System.Windows.Forms.ComboBox();
            this.Exercise_Time_Text = new System.Windows.Forms.Label();
            this.Exercise_Type_Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 155);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exercise_Time_box
            // 
            this.Exercise_Time_box.Location = new System.Drawing.Point(165, 102);
            this.Exercise_Time_box.Name = "Exercise_Time_box";
            this.Exercise_Time_box.Size = new System.Drawing.Size(154, 22);
            this.Exercise_Time_box.TabIndex = 13;
            // 
            // Exercise_Type_Choose
            // 
            this.Exercise_Type_Choose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Exercise_Type_Choose.FormattingEnabled = true;
            this.Exercise_Type_Choose.Location = new System.Drawing.Point(165, 69);
            this.Exercise_Type_Choose.Name = "Exercise_Type_Choose";
            this.Exercise_Type_Choose.Size = new System.Drawing.Size(154, 20);
            this.Exercise_Type_Choose.TabIndex = 12;
            // 
            // Exercise_Time_Text
            // 
            this.Exercise_Time_Text.AutoSize = true;
            this.Exercise_Time_Text.Location = new System.Drawing.Point(45, 108);
            this.Exercise_Time_Text.Name = "Exercise_Time_Text";
            this.Exercise_Time_Text.Size = new System.Drawing.Size(33, 12);
            this.Exercise_Time_Text.TabIndex = 11;
            this.Exercise_Time_Text.Text = "label2";
            // 
            // Exercise_Type_Text
            // 
            this.Exercise_Type_Text.AutoSize = true;
            this.Exercise_Type_Text.Location = new System.Drawing.Point(45, 74);
            this.Exercise_Type_Text.Name = "Exercise_Type_Text";
            this.Exercise_Type_Text.Size = new System.Drawing.Size(33, 12);
            this.Exercise_Type_Text.TabIndex = 10;
            this.Exercise_Type_Text.Text = "label1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 225);
            this.Controls.Add(this.Exercise_Time_box);
            this.Controls.Add(this.Exercise_Type_Choose);
            this.Controls.Add(this.Exercise_Time_Text);
            this.Controls.Add(this.Exercise_Type_Text);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Form4";
            this.Text = "Record";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Exercise_Time_box;
        private System.Windows.Forms.ComboBox Exercise_Type_Choose;
        private System.Windows.Forms.Label Exercise_Time_Text;
        private System.Windows.Forms.Label Exercise_Type_Text;
    }
}