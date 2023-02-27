using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using SakasaM.WinForm.ViewModels;

namespace SakasaM.WinForm.Views
{
    /// <summary>
    /// 出題画面
    /// </summary>
    public partial class QuestionView : Form
    {
        private QuestionViewModel _questionViewModel;

        /// <summary>
        /// 画面を中央に配置し、QuestionViewModelを具象化する
        /// </summary>
        /// <param name="count">桁数</param>
        public QuestionView(int count)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //// 桁数を指定してインスタンスを生成し, ShowLabelに投げる
            //// 今は桁数をべた書きしているが, 将来的にはスタート画面から取ってくる
            _questionViewModel = new QuestionViewModel(count);
            ShowLabelAsync();
        }

        //// 非同期処理で一文字ずつ表示する
        private async void ShowLabelAsync()
        {
            int[] qIntArray = _questionViewModel.RandomIntArray();

            for (int i = 0; i < qIntArray.Length; i++)
            {
                QFigureLabel.Text = qIntArray[i].ToString();
                await Task.Delay(1000);

                //// 切り替わったのが分かりやすいようにしている
                QFigureLabel.Text = string.Empty;
                await Task.Delay(200);
            }

            //// AnswerViewを開き、このフォームを閉じる
            AnswerView answerView = new AnswerView();
            answerView.Show();
            Dispose();
        }

        private void QuestionView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
