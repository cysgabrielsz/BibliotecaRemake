using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaRemake
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {    
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormLogin entrando = new FormLogin();
            entrando.saida = false;
            Application.Run(entrando); // Sera necessario passar para os formularios
            if (entrando.saida)
            {
                entrando.Dispose();
                entrando.Close();
                Application.Run(new Telainicial());
            }
                
        }
    }
}
