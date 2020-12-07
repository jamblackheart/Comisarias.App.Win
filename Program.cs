
using System;
using System.Windows.Forms;
using Comisarias.App.Escritorio.Controllers;
using Comisarias.App.Escritorio.Models;

namespace Comisarias.App.Escritorio
{
    static class Program
    {

       public static ViewModelUserRole usuarioGlobal = new ViewModelUserRole();

        public static ViewModelParametroSistema parametroSistema = new ViewModelParametroSistema();


        [STAThread]
        static void Main()
        {
         //   AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Path.GetFullPath(AparametroSistema));

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

