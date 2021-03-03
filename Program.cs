
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
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
           // GetConnectionStrings();

            try
            {
                Application.Run(new FrmLogin());
            }
            catch (Exception e)
            {
                MessageBox.Show("Hemos detectado un problema en el sistema,  si el problema continua comuniquese con el administrador del sistema" + e.Message, "Error sistema");
                Application.Run(new FrmLogin());
            }
        }


        static void GetConnectionStrings()
        {
            var xmlStr = File.ReadAllText("fileName.xml");


            var str = XElement.Parse(xmlStr);

            var result = str.Elements("word").
            Where(x => x.Element("connectionString").Value.Equals("conn"));

            Console.WriteLine(result);
        }

        


    }
}

