using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Produkte_Verwaltung.PL
{
    public partial class Produkte_Form : Form
    {
        BLL.neues_Produkt produkte = new BLL.neues_Produkt();

        public Produkte_Form()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = produkte.get_alle_Produkte();
        }

        private void tbxsuchen_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = produkte.Produke_suchen(tbxsuchen.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void btnneuesprodukt_Click(object sender, EventArgs e)
        {
            neues_Produkt_Form frm = new neues_Produkt_Form();
            frm.ShowDialog();
          
        }

        private void btnlöschen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Produkt löschen?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                produkte.produkt_löschen(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Produkt wurde gelöscht", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = produkte.get_alle_Produkte();
            }
            else { MessageBox.Show("Produkt wurde nicht gelöscht", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void btnbearbeiten_Click(object sender, EventArgs e)
        {
            neues_Produkt_Form frm = new neues_Produkt_Form();
            frm.tbxprnr.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.tbxpbeschreibung.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.tbxmenge.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.tbxkosten.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cmbsorte.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = "Produkt beabeiten: " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btnadd.Text = "Aktualisieren";
            frm.state = "update";
            frm.tbxprnr.ReadOnly = true;
            frm.ShowDialog();
        }
    }
}
