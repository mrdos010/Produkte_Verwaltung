namespace Produkte_Verwaltung.PL
{
    partial class Sorte_FRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxsorteNR = new System.Windows.Forms.TextBox();
            this.tbxbeschreibung = new System.Windows.Forms.TextBox();
            this.btnerste = new System.Windows.Forms.Button();
            this.btndavor = new System.Windows.Forms.Button();
            this.btndanach = new System.Windows.Forms.Button();
            this.btnltze = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.Aktionen = new System.Windows.Forms.GroupBox();
            this.btnneuesote = new System.Windows.Forms.Button();
            this.btnhinzufügen = new System.Windows.Forms.Button();
            this.btnlöschen = new System.Windows.Forms.Button();
            this.btnbearbeiten = new System.Windows.Forms.Button();
            this.datag = new System.Windows.Forms.DataGridView();
            this.btnausdrucken = new System.Windows.Forms.Button();
            this.btnalleaus = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnschließen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Aktionen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datag)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datag);
            this.groupBox1.Controls.Add(this.lblPosition);
            this.groupBox1.Controls.Add(this.btnltze);
            this.groupBox1.Controls.Add(this.btndanach);
            this.groupBox1.Controls.Add(this.btndavor);
            this.groupBox1.Controls.Add(this.btnerste);
            this.groupBox1.Controls.Add(this.tbxbeschreibung);
            this.groupBox1.Controls.Add(this.tbxsorteNR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorte Daten";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sorte Nummer: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sorte Beschreibung: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbxsorteNR
            // 
            this.tbxsorteNR.Location = new System.Drawing.Point(178, 32);
            this.tbxsorteNR.Name = "tbxsorteNR";
            this.tbxsorteNR.ReadOnly = true;
            this.tbxsorteNR.Size = new System.Drawing.Size(172, 20);
            this.tbxsorteNR.TabIndex = 2;
            // 
            // tbxbeschreibung
            // 
            this.tbxbeschreibung.Location = new System.Drawing.Point(178, 61);
            this.tbxbeschreibung.Multiline = true;
            this.tbxbeschreibung.Name = "tbxbeschreibung";
            this.tbxbeschreibung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxbeschreibung.Size = new System.Drawing.Size(226, 74);
            this.tbxbeschreibung.TabIndex = 3;
            // 
            // btnerste
            // 
            this.btnerste.Location = new System.Drawing.Point(178, 141);
            this.btnerste.Name = "btnerste";
            this.btnerste.Size = new System.Drawing.Size(36, 23);
            this.btnerste.TabIndex = 4;
            this.btnerste.Text = "||<<";
            this.btnerste.UseVisualStyleBackColor = true;
            // 
            // btndavor
            // 
            this.btndavor.Location = new System.Drawing.Point(230, 141);
            this.btndavor.Name = "btndavor";
            this.btndavor.Size = new System.Drawing.Size(32, 23);
            this.btndavor.TabIndex = 5;
            this.btndavor.Text = "<<";
            this.btndavor.UseVisualStyleBackColor = true;
            // 
            // btndanach
            // 
            this.btndanach.Location = new System.Drawing.Point(315, 141);
            this.btndanach.Name = "btndanach";
            this.btndanach.Size = new System.Drawing.Size(35, 23);
            this.btndanach.TabIndex = 6;
            this.btndanach.Text = ">>";
            this.btndanach.UseVisualStyleBackColor = true;
            // 
            // btnltze
            // 
            this.btnltze.Location = new System.Drawing.Point(368, 141);
            this.btnltze.Name = "btnltze";
            this.btnltze.Size = new System.Drawing.Size(36, 23);
            this.btnltze.TabIndex = 7;
            this.btnltze.Text = ">>||";
            this.btnltze.UseVisualStyleBackColor = true;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(268, 146);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(20, 15);
            this.lblPosition.TabIndex = 8;
            this.lblPosition.Text = "lbl";
            // 
            // Aktionen
            // 
            this.Aktionen.Controls.Add(this.btnschließen);
            this.Aktionen.Controls.Add(this.button5);
            this.Aktionen.Controls.Add(this.btnPDF);
            this.Aktionen.Controls.Add(this.btnalleaus);
            this.Aktionen.Controls.Add(this.btnausdrucken);
            this.Aktionen.Controls.Add(this.btnbearbeiten);
            this.Aktionen.Controls.Add(this.btnlöschen);
            this.Aktionen.Controls.Add(this.btnhinzufügen);
            this.Aktionen.Controls.Add(this.btnneuesote);
            this.Aktionen.Location = new System.Drawing.Point(12, 206);
            this.Aktionen.Name = "Aktionen";
            this.Aktionen.Size = new System.Drawing.Size(776, 126);
            this.Aktionen.TabIndex = 0;
            this.Aktionen.TabStop = false;
            this.Aktionen.Text = "Aktionen";
            // 
            // btnneuesote
            // 
            this.btnneuesote.Location = new System.Drawing.Point(28, 40);
            this.btnneuesote.Name = "btnneuesote";
            this.btnneuesote.Size = new System.Drawing.Size(75, 23);
            this.btnneuesote.TabIndex = 0;
            this.btnneuesote.Text = "neue Sorte";
            this.btnneuesote.UseVisualStyleBackColor = true;
            // 
            // btnhinzufügen
            // 
            this.btnhinzufügen.Location = new System.Drawing.Point(149, 40);
            this.btnhinzufügen.Name = "btnhinzufügen";
            this.btnhinzufügen.Size = new System.Drawing.Size(75, 23);
            this.btnhinzufügen.TabIndex = 1;
            this.btnhinzufügen.Text = "Hinzufügen";
            this.btnhinzufügen.UseVisualStyleBackColor = true;
            // 
            // btnlöschen
            // 
            this.btnlöschen.Location = new System.Drawing.Point(260, 40);
            this.btnlöschen.Name = "btnlöschen";
            this.btnlöschen.Size = new System.Drawing.Size(72, 23);
            this.btnlöschen.TabIndex = 2;
            this.btnlöschen.Text = "Löschen";
            this.btnlöschen.UseVisualStyleBackColor = true;
            // 
            // btnbearbeiten
            // 
            this.btnbearbeiten.Location = new System.Drawing.Point(368, 40);
            this.btnbearbeiten.Name = "btnbearbeiten";
            this.btnbearbeiten.Size = new System.Drawing.Size(75, 23);
            this.btnbearbeiten.TabIndex = 3;
            this.btnbearbeiten.Text = "Bearbeiten";
            this.btnbearbeiten.UseVisualStyleBackColor = true;
            // 
            // datag
            // 
            this.datag.AllowUserToAddRows = false;
            this.datag.AllowUserToDeleteRows = false;
            this.datag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datag.Location = new System.Drawing.Point(446, 32);
            this.datag.Name = "datag";
            this.datag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datag.Size = new System.Drawing.Size(291, 132);
            this.datag.TabIndex = 0;
            // 
            // btnausdrucken
            // 
            this.btnausdrucken.Location = new System.Drawing.Point(472, 40);
            this.btnausdrucken.Name = "btnausdrucken";
            this.btnausdrucken.Size = new System.Drawing.Size(79, 23);
            this.btnausdrucken.TabIndex = 4;
            this.btnausdrucken.Text = "ausdrucken";
            this.btnausdrucken.UseVisualStyleBackColor = true;
            // 
            // btnalleaus
            // 
            this.btnalleaus.Location = new System.Drawing.Point(601, 40);
            this.btnalleaus.Name = "btnalleaus";
            this.btnalleaus.Size = new System.Drawing.Size(136, 23);
            this.btnalleaus.TabIndex = 5;
            this.btnalleaus.Text = "alle Sorte ausdrucken";
            this.btnalleaus.UseVisualStyleBackColor = true;
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(231, 84);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(57, 23);
            this.btnPDF.TabIndex = 6;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(316, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "alle PDF";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnschließen
            // 
            this.btnschließen.Location = new System.Drawing.Point(419, 84);
            this.btnschließen.Name = "btnschließen";
            this.btnschließen.Size = new System.Drawing.Size(72, 23);
            this.btnschließen.TabIndex = 8;
            this.btnschließen.Text = "Schließen";
            this.btnschließen.UseVisualStyleBackColor = true;
            this.btnschließen.Click += new System.EventHandler(this.btnschließen_Click);
            // 
            // Sorte_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.Aktionen);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sorte_FRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorte Verwaltung";
            this.Load += new System.EventHandler(this.Sorte_FRM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Aktionen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxbeschreibung;
        private System.Windows.Forms.TextBox tbxsorteNR;
        private System.Windows.Forms.Button btnltze;
        private System.Windows.Forms.Button btndanach;
        private System.Windows.Forms.Button btndavor;
        private System.Windows.Forms.Button btnerste;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.GroupBox Aktionen;
        private System.Windows.Forms.Button btnausdrucken;
        private System.Windows.Forms.Button btnbearbeiten;
        private System.Windows.Forms.Button btnlöschen;
        private System.Windows.Forms.Button btnhinzufügen;
        private System.Windows.Forms.Button btnneuesote;
        private System.Windows.Forms.DataGridView datag;
        private System.Windows.Forms.Button btnschließen;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnalleaus;
    }
}