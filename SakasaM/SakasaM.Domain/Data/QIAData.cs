using System;

namespace SakasaM.Domain.Data
{
    /// <summary>
    /// QuestionIntArrayをstaticに管理するクラス
    /// </summary>
    internal static class QIAData
    {
        /// <summary>
        /// 出題する数字配列
        /// </summary>
        internal static int[] QuestionIntArray { get; private set; }

        /// <summary>
        /// 解答した数字配列(str型後ろ詰め)
        /// </summary>
        internal static string[] AnswerStringArray { get; private set; }

        /// <summary>
        /// 桁数をViewsクラスから取得し、配列を返す
        /// </summary>
        /// <param name="count">生成する数字配列の長さ</param>
        internal static void RandomIntArray(int count)
        {
            Random random = new Random();
            QuestionIntArray = new int[count];
            AnswerStringArray = new string[count];

            for (int i = 0; i < QuestionIntArray.Length; i++)
            {
                QuestionIntArray[i] = random.Next(0, 10);
                AnswerStringArray[i] = "n";
            }
        }

        /// <summary>
        /// 数字配列の後ろから, 解答数字と比較して合否を返す
        /// </summary>
        /// <param name="digit">比較する桁番号</param>
        /// <param name="answer">解答数字</param>
        /// <returns>合否結果, 最後の桁かどうか</returns>
        internal static (bool, bool) JudgeNumber(int digit, string answer)
        {
            bool isLast = digit == QuestionIntArray.Length;

            AnswerStringArray[AnswerStringArray.Length - digit] = answer;
            return (QuestionIntArray[QuestionIntArray.Length - digit] == Convert.ToInt32(answer), isLast);
        }
    }
}
