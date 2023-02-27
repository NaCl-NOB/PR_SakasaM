using System;
using System.Windows.Forms;

namespace SakasaM.WinForm
{
    /// <summary>
    /// First
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartView());
        }
    }
}
