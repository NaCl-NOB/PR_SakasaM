namespace SakasaM.Domain
{
    /// <summary>
    /// ファサード
    /// </summary>
    public static class SakasaM
    {
        /// <summary>
        /// 出題する数字配列を生成し, 表示する
        /// </summary>
        /// <param name="count">配列の長さ</param>
        /// <returns>数字配列</returns>
        public static int[] GetQuestionIntArray(int count)
        {
            Data.QIAData.RandomIntArray(count);
            return ShowQuestionIntArray();
        }

        /// <summary>
        /// 解答数字と答えを照らし合わせて合否を返す
        /// </summary>
        /// <param name="digit">判定する桁番号</param>
        /// <param name="answer">解答数字</param>
        /// <returns>合否結果, 最後の桁かどうか</returns>
        public static (bool, bool) ResultJudgeNumber(int digit, string answer)
        {
            return Data.QIAData.JudgeNumber(digit, answer);
        }

        /// <summary>
        /// 出題する数字配列を表示する
        /// </summary>
        /// <returns>数字配列</returns>
        public static int[] ShowQuestionIntArray()
        {
            return Data.QIAData.QuestionIntArray;
        }

        /// <summary>
        /// 解答された配列を表示する
        /// </summary>
        /// <returns>解答配列</returns>
        public static string[] ShowAnswerStringArray()
        {
            return Data.QIAData.AnswerStringArray;
        }
    }
}
