using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Controle_Estoque
{
    public partial class Form1 : Form
    {
        SqlCommand comand;
        SqlDataAdapter da;
        SqlConnection con;
        SqlDataReader dr;
        string str;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paginaProduto paginaProdutos = new paginaProduto();
            paginaProdutos.ShowDialog();
             Form1 f1 = new Form1();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paginaMarca paginaMarcas = new paginaMarca();
            paginaMarcas.ShowDialog();
            Form1 f1 = new Form1();
            this.Hide();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            paginaEstoque paginaEstoques = new paginaEstoque();
            paginaEstoques.ShowDialog();
            Form1 f1 = new Form1();
            this.Hide();
        }

        private void btnMovimento_Click(object sender, EventArgs e)
        {
            paginaMovimento paginaMovimentos = new paginaMovimento();
            paginaMovimentos.ShowDialog();
            Form1 f1 = new Form1();
            this.Hide();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection();
                str = ("");
                comand = new SqlCommand(str, con);

                DataSet ds = new DataSet();
                da = new SqlDataAdapter(str, con);
                con.Open();

                da.Fill(ds);
                dgvListaProdutos.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            { 
                con.Close();
                comand = null;
            }
            
        }
    }
}
