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
    public partial class paginaProduto : Form
    {
        SqlCommand comand;
        SqlDataAdapter da;
        SqlConnection con;
        SqlDataReader dr;
        string str;
        public paginaProduto()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            paginaProduto paginaP = new paginaProduto();
           
            Form1 form1 = new Form1();
            form1.Show();
            paginaP.MdiParent = form1;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Hide();
            paginaEstoque paginaE = new paginaEstoque();
            paginaE.ShowDialog();
            paginaE.MdiParent = form1;
            this.Close();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Server=DESKTOP-SAULO;Database=LOJADBSTORE;User Id=sa;Password=Jo@o2005;");
                str = ("SELECT * FROM Produto WHERE nome=@Nome");
                comand = new SqlCommand(str, con);

                comand.Parameters.AddWithValue("@Nome",tbNomeProduto.Text);

                con.Open();

                dr = comand.ExecuteReader();

                while (dr.Read()) 
                {
                    tbIdProduto.Text = Convert.ToString(dr["produto_id"]);
                    tbMarcaProduto.Text = Convert.ToString(dr["marca_id"]);
                    tbNomeProduto.Text = Convert.ToString(dr["nome"]);
                    tbDataCadastro.Text = Convert.ToString(dr["data_inclusao"]);
                   
                }
                MessageBox.Show("Alterado com sucesso !");
                  
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Server=DESKTOP-SAULO;Database=LOJADBSTORE;User Id=sa;Password=Jo@o2005;");
                str = ("UPDATE Produto SET nome=@nome where produto_id=@produto_id");
                comand = new SqlCommand(str, con);
                              
                comand.Parameters.AddWithValue("@nonme",tbNomeProduto.Text);
            
                //Verificar para bloquear a exibição
                con.Open();

                comand.ExecuteNonQuery();

                MessageBox.Show("Alterado com sucesso Id "+tbIdProduto.ToString());                
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Server=DESKTOP-SAULO;Database=LOJADBSTORE;User Id=sa;Password=Jo@o2005;");
                str = "INSERT INTO Produto (nome) VALUES (@nome)";
                comand = new SqlCommand(str, con);

                comand.Parameters.AddWithValue("@nome",tbNomeProduto.Text);

                //tratar campo da marca do produto
                con.Open();

                comand.ExecuteNonQuery ();

                MessageBox.Show("Incluido com sucesso");

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
