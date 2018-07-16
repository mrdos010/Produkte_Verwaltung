using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Produkte_Verwaltung.PL
{
    public partial class neues_Produkt_Form : Form
    {
        BLL.neues_Produkt prd = new BLL.neues_Produkt();


        public neues_Produkt_Form()
        {
            InitializeComponent();
            cmbsorte.DataSource = prd.get_alle_sorte();
            cmbsorte.DisplayMember = "Sorte_Beschreibung";
            cmbsorte.ValueMember = "SorteNr";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnabbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbild_Click(object sender, EventArgs e)
        {

            // Bild hinzufügen

            OpenFileDialog bild = new OpenFileDialog();

            bild.Filter = "Bilder Datein | *.JPG; *.PNG; *.GIF; *.BMP";
            if (bild.ShowDialog() == DialogResult.OK)
            {
                pbild.Image = Image.FromFile(bild.FileName);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.produktnummer_üperprüfene(tbxprnr.Text);
            if (dt.Rows.Count > 0)

            {
                MessageBox.Show("Dieses Produkt ist schon vorhanden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxprnr.Focus();
                tbxprnr.SelectionStart = 0;
                tbxprnr.SelectionLength = tbxprnr.TextLength;
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pbild.Image.Save(ms, pbild.Image.RawFormat);
                byte[] byteimage = ms.ToArray();

                prd.produkt_hinzufügen(Convert.ToInt32(cmbsorte.SelectedValue), tbxpbeschreibung.Text, tbxprnr.Text,
                    Convert.ToInt32(tbxmenge.Text), tbxkosten.Text, byteimage);
                MessageBox.Show("Produkt wurde hinzugefügt", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }

           



        }

        private void tbxprnr_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.produktnummer_üperprüfene(tbxprnr.Text);
            if (dt.Rows.Count > 0)

            {
                MessageBox.Show("Dieses Produkt ist schon vorhanden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxprnr.Focus();
                tbxprnr.SelectionStart = 0;
                tbxprnr.SelectionLength = tbxprnr.TextLength;
            }
        }

    }
}
