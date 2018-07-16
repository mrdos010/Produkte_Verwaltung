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

    public partial class Anmeldung_Form : Form
    {
        BLL.Anmeldung anmeldekl = new BLL.Anmeldung();

        public Anmeldung_Form()
        {
            InitializeComponent();
        }

        private void Anmeldung_Load(object sender, EventArgs e)
        {

        }

        private void btnabbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            DataTable dt = anmeldekl.anmelden(tbxuser.Text, tbxpass.Text);

            if (dt.Rows.Count > 0)
            {
                //MessageBox.Show("Login Success", "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);

                haupt_form.gethauptform.produkteToolStripMenuItem.Enabled = true;
                haupt_form.gethauptform.kundenToolStripMenuItem.Enabled = true;
                haupt_form.gethauptform.benutzerToolStripMenuItem.Enabled = true;
                haupt_form.gethauptform.backupErstellenToolStripMenuItem.Enabled = true;
                haupt_form.gethauptform.backupToolStripMenuItem.Enabled = true;
                this.Close();
               
            }else
            {
                MessageBox.Show("Login Falsch", "Info",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }
    }
}
