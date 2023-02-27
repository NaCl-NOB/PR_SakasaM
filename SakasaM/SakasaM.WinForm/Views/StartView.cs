using System;
using System.Windows.Forms;
using SakasaM.WinForm.Views;

namespace SakasaM.WinForm
{
    /// <summary>
    /// スタート画面
    /// </summary>
    public partial class StartView : Form
    {
        /// <summary>
        /// 起動時この画面が一番最初に呼び出される
        /// </summary>
        public StartView()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        //// スタートボタン
        private void StartButton_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (RadioButton radioButton in DigitGroupBox.Controls)
            {
                if (radioButton.Checked)
                {
                    count = Convert.ToInt32(radioButton.Text);
                }
            }

            QuestionView questionForm = new QuestionView(count);
            questionForm.Show();
            Hide();
        }

        //// 閉じるボタン
        private void EndButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
