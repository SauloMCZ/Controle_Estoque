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
    public partial class paginaEstoque : Form
    {
        SqlCommand comand;
        SqlDataAdapter da;
        SqlConnection con;
        SqlDataReader dr;
        string str;
        public paginaEstoque()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            paginaEstoque paginaE = new paginaEstoque();
            Form1 form1 = new Form1();
            form1.Show();
            paginaE.MdiParent = form1;
            this.Close();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Server=DESKTOP-SAULO;Database=LOJADBSTORE;User Id=sa;Password=Jo@o2005;");
                str = "SELECT * FROM PRODUTO";
                comand = new SqlCommand(str, con);

                DataSet ds = new DataSet();
                da = new SqlDataAdapter(str, con);
                con.Open();

                da.Fill(ds);
                dgvEstoque.DataSource = ds.Tables[0];
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
            PrintDialog printDialogEstoque = new PrintDialog(); // chamo e instancio a função Print dialog new ()
            printDialogEstoque.Document = printDgvEstoque; //Passo que eu quero um *.Document trazendo do dado de impressão do DGV

            DialogResult dialogResultEstoque = printDialogEstoque.ShowDialog();//chamo e instancia a dialogResult = passando a instancia acima mandando mostrar
        }

        private void printDgvEstoque_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmpEstoque = new Bitmap(this.dgvEstoque.Width,this.dgvEstoque.Height);//instancio um bitmap e passos valores de largura e altura usando this.*chamo o nome do dgv
            dgvEstoque.DrawToBitmap(bmpEstoque, new Rectangle(0,0,this.dgvEstoque.Width,this.dgvEstoque.Height));
            //acima foi criado um do dgv passando comando para impriir e instanciando os valores(Nome da isntancia bitmap crainao new recta (0,0 e os this))    
            e.Graphics.DrawImage(bmpEstoque,0,0);//comanddo para chamar os graficos de impressão passando o bitmap zerado(bitmap,0,0,)
        }   
    }
}
