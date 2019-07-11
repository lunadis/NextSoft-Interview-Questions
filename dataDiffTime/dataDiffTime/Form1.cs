using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataDiffTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            DateTime datainicial = dtpData.Value;
            DateTime ultimoDia = datainicial.AddDays(-30);
            lbldate.Text = ultimoDia.ToShortDateString();
        }

        private void DtpData_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime datainicial = dtpData.Value;
            DateTime ultimoDia = datainicial.AddDays(-30);
            lbldate.Text = DateTime.DaysInMonth(ultimoDia.Year, ultimoDia.Month).ToString();
        }
    }
}
