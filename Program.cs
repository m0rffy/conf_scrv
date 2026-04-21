using OfficeOpenXml;
using System.Threading;
using System.Text;
using System.Drawing.Text;

namespace Uetm_2_0
{
    internal static class Program
    {
        private const string MutexName = @"Global\{B0911876-8AD2-4F72-9720-AE1CCB135D94}";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // Более надёжный способ: создаём мьютекс и сразу узнаём, создан ли он впервые
            using Mutex mutex = new Mutex(true, MutexName, out bool createdNew);

            if (createdNew)
            {
                // Установка лицензии EPPlus 8 при старте приложения
                ExcelPackage.License.SetNonCommercialPersonal("UETM Configurator");
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                ApplicationConfiguration.Initialize();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Auth());
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("Программа уже запущена!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Принудительно завершаем процесс
                Environment.Exit(0);
            }
        }
    }
}