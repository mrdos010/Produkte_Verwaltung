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
    public partial class haupt_form : Form
    {
        private static haupt_form haupt;

        static void haupt_closed(object sender, FormClosedEventArgs e)
        {
            haupt = null;

        }

        public static haupt_form gethauptform
        {
            get
            {
                if (haupt == null)
                {
                    haupt = new haupt_form();
                    haupt.FormClosed += new FormClosedEventHandler(haupt_closed);
                }
                return haupt;
            }
        }

        public haupt_form()
        {
            InitializeComponent();
            if (haupt == null)
                haupt = this;
                
            this.produkteToolStripMenuItem.Enabled = false;
            this.kundenToolStripMenuItem.Enabled = false;
            this.benutzerToolStripMenuItem.Enabled = false;
            this.backupErstellenToolStripMenuItem.Enabled = false;
            this.backupToolStripMenuItem.Enabled = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void neueSorteHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void anmeldungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anmeldung_Form anmelden = new Anmeldung_Form();
            anmelden.ShowDialog();
        }

        private void haupt_form_Load(object sender, EventArgs e)
        {

        }

        private void produktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            neues_Produkt_Form frm = new neues_Produkt_Form();

            frm.ShowDialog();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 1.0\nProgrammiert von: Anas Al Sayed\nEmail: anas.alsayed91@gmail.com","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void produkteVerwaltenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produkte_Form prd = new Produkte_Form();
            prd.ShowDialog();
        }
    }
}
