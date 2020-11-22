
using System;
using System.Windows.Forms;
using static Comisarias.App.Escritorio.Models.AuthUser;

namespace Comisarias.App.Escritorio
{
    static class Program
    {
        public static RegisterDesktopViewModel usuarioGlobal = new RegisterDesktopViewModel();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new FrmLogin());
            }
            catch (Exception e)
            {
                MessageBox.Show("Hemos detectado un problema en el sistema, verifique la conexión de internet y reintente el proceso, si el problema continua comuniquese con el administrador del sistema" + e.Message, "Error sistema");
                Application.Run(new FrmLogin());
            }
        }
    }
}

