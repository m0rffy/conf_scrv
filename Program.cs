using OfficeOpenXml;
using System.Text;

namespace Uetm_2_0
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {

            // Установка лицензии EPPlus 8 при старте приложения
            ExcelPackage.License.SetNonCommercialPersonal("UETM Configurator");

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Auth());
        }
    }
}