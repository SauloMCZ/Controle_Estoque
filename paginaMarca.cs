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
    public partial class paginaMarca : Form
    {

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string str;
        public paginaMarca()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
           paginaMarca paginaM = new paginaMarca();
           Form1 form1= new Form1();
           form1.Show();
           paginaM.MdiParent = form1;
            this.Close();
            
        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Server=DESKTOP-SAULO;Database=LOJADBSTORE;User Id=sa;Password=Jo@o2005;");
            str = ("");
            cmd = new SqlCommand(str, conn);

            DataSet ds = new DataSet();
            da = new SqlDataAdapter(str, conn);
            conn.Open();

            da.Fill(ds);
            dgvProduto.DataSource = ds.Tables[0];
        }
    }
}
