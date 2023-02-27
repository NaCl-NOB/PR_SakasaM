using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using SakasaM.WinForm.ViewModels;

namespace SakasaM.WinForm.Views
{
    /// <summary>
    /// 結果画面
    /// </summary>
    internal partial class ResultView : Form
    {
        private ResultViewModel _resultViewModel;

        /// <summary>
        /// 画面を中央に配置し、ResultViewModelを具象化する
        /// </summary>
        /// <param name="isComplete">全問正解か、何桁まで正解か</param>
        internal ResultView(int isComplete)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _resultViewModel = new ResultViewModel();
            SetResultLabelAsync(isComplete);
        }

        private async void SetResultLabelAsync(int isComplete)
        {
            await Task.Delay(200);
            ResultLabel.Text += "答え\n";
            await Task.Delay(1000);
            ResultLabel.Text += $"[{string.Join(",", _resultViewModel.QuestionIntArray)}]";
            await Task.Delay(1000);
            ResultLabel.Text += "\nあなたの解答\n";
            await Task.Delay(1000);
            ResultLabel.Text += $"[{string.Join(",", _resultViewModel.AnswerStringArray)}]";
            await Task.Delay(1500);

            if (isComplete == -1)
            {
                ResultLabel.Text += "\n全問正解！！";
            }
            else if (isComplete == 0)
            {
                ResultLabel.Text += "\n全問不正解……";
            }
            else
            {
                ResultLabel.Text += $"\n{isComplete}桁まで正解";
            }

            ReStartButton.Enabled = true;
            EndButton.Enabled = true;
        }

        private void ReStartButton_Click(object sender, EventArgs e)
        {
            StartView startView = new StartView();
            startView.Show();
            Dispose();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ResultView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
