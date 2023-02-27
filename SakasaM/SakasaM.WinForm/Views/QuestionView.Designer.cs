namespace SakasaM.WinForm.Views
{
    partial class QuestionView
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
            this.QFigureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QFigureLabel
            // 
            this.QFigureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QFigureLabel.Location = new System.Drawing.Point(12, 23);
            this.QFigureLabel.Margin = new System.Windows.Forms.Padding(0);
            this.QFigureLabel.Name = "QFigureLabel";
            this.QFigureLabel.Size = new System.Drawing.Size(320, 231);
            this.QFigureLabel.TabIndex = 0;
            this.QFigureLabel.Text = "0";
            this.QFigureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuestionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 361);
            this.Controls.Add(this.QFigureLabel);
            this.Name = "QuestionView";
            this.Text = "SakasaM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionView_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label QFigureLabel;
    }
}