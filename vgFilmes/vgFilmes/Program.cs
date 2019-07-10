using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace vgFilmes
{
    static class Program
    {

        public static string conexao = @"Password=1759Next;Persist Security Info=True;User ID=sa;Initial Catalog=filmes;Data Source=DESKTOP-DTHC4QP\SQLNEXT";
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
