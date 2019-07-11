using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DtpNascimento_ValueChanged(object sender, EventArgs e)
        {
            DateTime nascimento = dtpNascimento.Value;
            int idade = DateTime.Now.Year - nascimento.Year;
            lblIdade.Text = idade.ToString();
        }
    }
}
