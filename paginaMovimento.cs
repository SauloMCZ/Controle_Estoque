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
    public partial class paginaMovimento : Form
    {
        SqlCommand comand;
        SqlDataAdapter da;
        SqlConnection con;
        SqlDataReader dr;
        string str;
        public paginaMovimento()
        {
            InitializeComponent();
        }

        private void paginaMovimento_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
           
            Form1 form1 = new Form1();
            paginaMovimento pagina = new paginaMovimento();
            form1.Show();
            pagina.MdiParent = form1;
            this.Close();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Server=DESKTOP-SAULO;Database=LOJADBSTORE;User Id=sa;Password=Jo@o2005;");
                str = ("INSERT INTO Produto ");
                comand = new SqlCommand(str, con);

                con.Open();
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

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Server=DESKTOP-SAULO;Database=LOJADBSTORE;User Id=sa;Password=Jo@o2005;");
                str = "SELECT * FROM Produto";
                comand = new SqlCommand(str, con);

                DataSet ds = new DataSet();
                da = new SqlDataAdapter(str, con);
                da.Fill(ds);

                dgvPaginadeMovimento.DataSource = ds.Tables[0];

                con.Open();
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

        private void btnOperacoes_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDgvMovimento;

            DialogResult DialogResultprintDgv = printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmapDgv = new Bitmap(this.dgvPaginadeMovimento.Width,this.dgvPaginadeMovimento.Height);
            dgvPaginadeMovimento.DrawToBitmap(bitmapDgv, new Rectangle(0, 0, this.dgvPaginadeMovimento.Width, this.dgvPaginadeMovimento.Height));
            e.Graphics.DrawImage(bitmapDgv,0,0);

        }
    }
}
