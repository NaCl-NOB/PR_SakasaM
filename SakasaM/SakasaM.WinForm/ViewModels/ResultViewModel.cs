using System;

namespace SakasaM.WinForm.ViewModels
{
    /// <summary>
    /// ResultViewに出題数列と解答数列を渡す
    /// </summary>
    internal class ResultViewModel
    {
        /// <summary>
        /// 呼ばれたら二つの配列を格納する
        /// </summary>
        internal ResultViewModel()
        {
            SetResultLabel();
        }

        /// <summary>
        /// 出題配列
        /// </summary>
        internal int[] QuestionIntArray { get; private set; }

        /// <summary>
        /// 解答配列
        /// </summary>
        internal string[] AnswerStringArray { get; private set; }

        private void SetResultLabel()
        {
            var sQIA = Domain.SakasaM.ShowQuestionIntArray();
            var sASA = Domain.SakasaM.ShowAnswerStringArray();

            Array.Copy(sQIA, QuestionIntArray = new int[sQIA.Length], sQIA.Length);
            Array.Copy(sASA, AnswerStringArray = new string[sASA.Length], sASA.Length);
        }
    }
}
