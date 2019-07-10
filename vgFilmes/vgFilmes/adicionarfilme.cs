using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vgFilmes
{
    public partial class adicionarfilme : Form
    {
        public adicionarfilme()
        {
            InitializeComponent();
        }

        public void cboGeneroFill()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conexao;
            conexao.Open();
            string pesquisarGenero = string.Concat("SELECT * FROM tb_genero");
            SqlCommand pesquisarUFSQL = new SqlCommand(pesquisarGenero, conexao);

            SqlDataAdapter sdaGen = new SqlDataAdapter(pesquisarUFSQL);
            DataTable dt = new DataTable();

            sdaGen.Fill(dt);

            cboGenero.DataSource = dt;
            cboGenero.DisplayMember = "nmGenero";
            cboGenero.ValueMember = "id";           

            conexao.Close();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conexao;
            try
            {
                conexao.Open();
                string cadastroSQL = "insert into tb_filme (idGenero, nmFilme) values("+ cboGenero.SelectedItem + ", '" + txtFilme.Text + "')";
                SqlCommand cadFilme = new SqlCommand(cadastroSQL, conexao);
                cadFilme.ExecuteNonQuery();
                conexao.Close();
                this.Close();
            }
            catch
            {
               
            }
        }

        private void BtnOutro_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Adicionarfilme_Load(object sender, EventArgs e)
        {
            cboGeneroFill();
        }
    }
}
