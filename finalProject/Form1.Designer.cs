namespace finalProject
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Start_Button = new System.Windows.Forms.Button();
            this.UserName_Text = new System.Windows.Forms.Label();
            this.Username_Box = new System.Windows.Forms.TextBox();
            this.Language_Choose = new System.Windows.Forms.ComboBox();
            this.Language_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start_Button
            // 
            this.Start_Button.Location = new System.Drawing.Point(146, 99);
            this.Start_Button.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(79, 26);
            this.Start_Button.TabIndex = 0;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserName_Text
            // 
            this.UserName_Text.AutoSize = true;
            this.UserName_Text.Location = new System.Drawing.Point(49, 59);
            this.UserName_Text.Name = "UserName_Text";
            this.UserName_Text.Size = new System.Drawing.Size(33, 12);
            this.UserName_Text.TabIndex = 1;
            this.UserName_Text.Text = "label1";
            // 
            // Username_Box
            // 
            this.Username_Box.Location = new System.Drawing.Point(135, 56);
            this.Username_Box.Name = "Username_Box";
            this.Username_Box.Size = new System.Drawing.Size(100, 22);
            this.Username_Box.TabIndex = 2;
            // 
            // Language_Choose
            // 
            this.Language_Choose.FormattingEnabled = true;
            this.Language_Choose.Location = new System.Drawing.Point(125, 142);
            this.Language_Choose.Name = "Language_Choose";
            this.Language_Choose.Size = new System.Drawing.Size(121, 20);
            this.Language_Choose.TabIndex = 3;
            this.Language_Choose.SelectedIndexChanged += new System.EventHandler(this.Languaue_Choose_SelectedIndexChanged);
            // 
            // Language_text
            // 
            this.Language_text.AutoSize = true;
            this.Language_text.Location = new System.Drawing.Point(49, 145);
            this.Language_text.Name = "Language_text";
            this.Language_text.Size = new System.Drawing.Size(33, 12);
            this.Language_text.TabIndex = 4;
            this.Language_text.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 225);
            this.Controls.Add(this.Language_text);
            this.Controls.Add(this.Language_Choose);
            this.Controls.Add(this.Username_Box);
            this.Controls.Add(this.UserName_Text);
            this.Controls.Add(this.Start_Button);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Form1";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Label UserName_Text;
        private System.Windows.Forms.TextBox Username_Box;
        private System.Windows.Forms.ComboBox Language_Choose;
        private System.Windows.Forms.Label Language_text;
    }
}

