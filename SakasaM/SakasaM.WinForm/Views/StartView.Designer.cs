namespace SakasaM.WinForm
{
    partial class StartView
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
            this.StartButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.DigitGroupBox = new System.Windows.Forms.GroupBox();
            this.DigitGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("源ノ角ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartButton.Location = new System.Drawing.Point(111, 210);
            this.StartButton.Margin = new System.Windows.Forms.Padding(0);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(119, 46);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "スタート";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Font = new System.Drawing.Font("源ノ角ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EndButton.Location = new System.Drawing.Point(111, 275);
            this.EndButton.Margin = new System.Windows.Forms.Padding(0);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(119, 46);
            this.EndButton.TabIndex = 2;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(87, 41);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 39);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "3";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(140, 41);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 39);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "5";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(193, 41);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(61, 39);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "10";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // DigitGroupBox
            // 
            this.DigitGroupBox.Controls.Add(this.radioButton3);
            this.DigitGroupBox.Controls.Add(this.radioButton2);
            this.DigitGroupBox.Controls.Add(this.radioButton1);
            this.DigitGroupBox.Font = new System.Drawing.Font("源ノ角ゴシック Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DigitGroupBox.Location = new System.Drawing.Point(12, 97);
            this.DigitGroupBox.Name = "DigitGroupBox";
            this.DigitGroupBox.Size = new System.Drawing.Size(320, 110);
            this.DigitGroupBox.TabIndex = 6;
            this.DigitGroupBox.TabStop = false;
            this.DigitGroupBox.Text = "桁数を指定してください";
            // 
            // StartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 361);
            this.Controls.Add(this.DigitGroupBox);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.StartButton);
            this.Name = "StartView";
            this.Text = "SakasaM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartView_FormClosing);
            this.DigitGroupBox.ResumeLayout(false);
            this.DigitGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox DigitGroupBox;
    }
}
