using System;
using System.Threading;
using System.Windows.Forms;
using CodingTest.UI.Services;

namespace CodingTest.UI
{
    internal static class Program
    {
        private static readonly LoggerService Logger = new LoggerService();

        [STAThread]
        static void Main()
        {
            // Catch UI thread exceptions
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += OnThreadException;

            // Catch non-UI thread exceptions
            AppDomain.CurrentDomain.UnhandledException += OnDomainUnhandledException;

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                ReportAndLog(ex);
            }
        }

        private static void OnThreadException(object sender, ThreadExceptionEventArgs e) => ReportAndLog(e.Exception);

        private static void OnDomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception ?? new Exception("Unhandled non-Exception object thrown");
            ReportAndLog(ex);
        }

        private static void ReportAndLog(Exception ex)
        {
            try { Logger.LogError(ex.ToString()); } catch { /* silent */ }

            try
            {
                MessageBox.Show(ex.ToString(), "Unhandled exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch { /* avoid crash loop */ }
        }
    }
}
