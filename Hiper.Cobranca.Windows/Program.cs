using System;
using System.Windows.Forms;
using Hiper.Cobranca.Negocio;

namespace Hiper.Cobranca.Windows
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //inicializar o banco e criar se não estiver criado 
            using (DBInitializerBO dBInitializer = new DBInitializerBO())
            {
                dBInitializer.InitializeBD();
            }

            Application.Run(new FormPrincipal());
        }
    }
}
