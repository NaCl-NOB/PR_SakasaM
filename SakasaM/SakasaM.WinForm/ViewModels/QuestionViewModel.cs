namespace SakasaM.WinForm.ViewModels
{
    /// <summary>
    /// QuestionViewクラスへ, ランダム生成した数字配列を返す
    /// </summary>
    internal class QuestionViewModel
    {
        private int _count;

        /// <summary>
        /// 桁数をViewsクラスから取得し、配列を返す
        /// </summary>
        /// <param name="count">生成する数字配列の長さ</param>
        internal QuestionViewModel(int count)
        {
            _count = count;
        }

        /// <summary>
        /// 0~9までのランダムな数字を指定数生成し, 配列にして返す
        /// </summary>
        /// <returns>出題する数字配列</returns>
        internal int[] RandomIntArray()
        {
            return Domain.SakasaM.GetQuestionIntArray(_count);
        }
    }
}
