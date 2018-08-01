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

namespace Produkte_Verwaltung.PL
{
    public partial class Sorte_FRM : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Server=.\SQLEXPRESS; Database=ProdukteDB; Integrated Security=true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();


        public Sorte_FRM()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select SorteNr as 'Nummer', Sorte_Beschreibung as 'Beschreibung' from Sorte", sqlcon);
            da.Fill(dt);
            datag.DataSource = dt;         
            tbxsorteNR.DataBindings.Add("text", dt, "Nummer");
            tbxbeschreibung.DataBindings.Add("text",dt, "Beschreibung");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnschließen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Sorte_FRM_Load(object sender, EventArgs e)
        {

        }
    }
}
