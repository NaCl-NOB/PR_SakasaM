namespace SakasaM.WinForm.ViewModels
{
    /// <summary>
    /// 押された数字のボタンと, 数字配列を比較させる
    /// </summary>
    internal class AnswerViewModel
    {
        //// 桁番号
        private int _digitNumber;

        /// <summary>
        /// 解答する桁番号
        /// </summary>
        internal AnswerViewModel()
        {
            _digitNumber = 1;
        }

        /// <summary>
        /// 成否を判定し、次の桁番号, 判定結果, 最後の桁かどうかを返す
        /// </summary>
        /// <param name="answer">Viewから受け取った解答数字</param>
        /// <returns>次の桁番号, 判定結果, 最後の桁かどうか</returns>
        internal (int, bool, bool) JudgeNumber(string answer)
        {
            var resultJudgeNumber = Domain.SakasaM.ResultJudgeNumber(_digitNumber, answer);
            return (++_digitNumber, resultJudgeNumber.Item1, resultJudgeNumber.Item2);
        }
    }
}
