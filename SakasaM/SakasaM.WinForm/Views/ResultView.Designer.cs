namespace SakasaM.WinForm.Views
{
    partial class ResultView
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
            this.EndButton = new System.Windows.Forms.Button();
            this.ReStartButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EndButton
            // 
            this.EndButton.Enabled = false;
            this.EndButton.Font = new System.Drawing.Font("源ノ角ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EndButton.Location = new System.Drawing.Point(111, 275);
            this.EndButton.Margin = new System.Windows.Forms.Padding(0);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(119, 46);
            this.EndButton.TabIndex = 4;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // ReStartButton
            // 
            this.ReStartButton.Enabled = false;
            this.ReStartButton.Font = new System.Drawing.Font("源ノ角ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ReStartButton.Location = new System.Drawing.Point(111, 210);
            this.ReStartButton.Margin = new System.Windows.Forms.Padding(0);
            this.ReStartButton.Name = "ReStartButton";
            this.ReStartButton.Size = new System.Drawing.Size(119, 46);
            this.ReStartButton.TabIndex = 3;
            this.ReStartButton.Text = "もう一度";
            this.ReStartButton.UseVisualStyleBackColor = true;
            this.ReStartButton.Click += new System.EventHandler(this.ReStartButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.Font = new System.Drawing.Font("源ノ角ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResultLabel.Location = new System.Drawing.Point(12, 9);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(320, 185);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ResultView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 361);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.ReStartButton);
            this.Name = "ResultView";
            this.Text = "SakasaM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultView_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button ReStartButton;
        private System.Windows.Forms.Label ResultLabel;
    }
}