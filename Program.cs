namespace TrabalhoBan
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }

        public static void MostrarErro(Exception ex)
        {
            if (ex is AggregateException agregado && agregado.InnerException != null)
                ex = agregado.InnerException;

            MessageBox.Show($"Ocorreu um erro:\n\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MostrarErro(e.Exception);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is Exception ex)
                MostrarErro(ex);
        }

        private static void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        {
            e.SetObserved();
            MostrarErro(e.Exception);
        }
    }
}
