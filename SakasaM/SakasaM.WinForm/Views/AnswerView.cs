using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using SakasaM.WinForm.ViewModels;

namespace SakasaM.WinForm.Views
{
    /// <summary>
    /// 解答画面
    /// </summary>
    public partial class AnswerView : Form
    {
        private ResultView _resultView;
        private AnswerViewModel _answerViewModel;

        /// <summary>
        /// 画面を中央に配置して, AnswerViewModelを具象化する
        /// </summary>
        public AnswerView()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _answerViewModel = new AnswerViewModel();
        }

        //// ボタンをクリックしたときの動作。
        //// 独自のボタンクラス作った方がスマートだと思ふ
        private async void ClickLogicAsync(Button button)
        {
            var result = _answerViewModel.JudgeNumber(button.Text);

            if (result.Item2)
            {
                SeiakiLabel.Text = "正解!!";

                //// 全問正解
                if (result.Item3)
                {
                    MessageBox.Show("終了!!");
                    _resultView = new ResultView(-1);
                    _resultView.Show();
                    Hide();
                }

                await Task.Delay(200);
                SeiakiLabel.Text = string.Empty;

                DigitNumberLabel.Text = $"後ろから{result.Item1}桁目";
            }
            else
            {
                MessageBox.Show("不正解です");

                _resultView = new ResultView(result.Item1 - 2);
                _resultView.Show();
                Dispose();
            }
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            ClickLogicAsync((Button)sender);
        }

        //// FormBaseクラスで統一させた方が良い
        private void AnswerView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
