namespace Produkte_Verwaltung.PL
{
    partial class neues_Produkt_Form
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
            this.btnabbrechen = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnbild = new System.Windows.Forms.Button();
            this.pbild = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxkosten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxmenge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxpbeschreibung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxprnr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbsorte = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbild)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnabbrechen);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.btnbild);
            this.groupBox1.Controls.Add(this.pbild);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxkosten);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxmenge);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxpbeschreibung);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxprnr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbsorte);
            this.groupBox1.Location = new System.Drawing.Point(13, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produkt Daten:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnabbrechen
            // 
            this.btnabbrechen.Image = global::Produkte_Verwaltung.Properties.Resources.if_Delete_132746;
            this.btnabbrechen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnabbrechen.Location = new System.Drawing.Point(112, 396);
            this.btnabbrechen.Name = "btnabbrechen";
            this.btnabbrechen.Size = new System.Drawing.Size(91, 23);
            this.btnabbrechen.TabIndex = 6;
            this.btnabbrechen.Text = "Abbrechen";
            this.btnabbrechen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnabbrechen.UseVisualStyleBackColor = true;
            this.btnabbrechen.Click += new System.EventHandler(this.btnabbrechen_Click);
            // 
            // btnadd
            // 
            this.btnadd.Image = global::Produkte_Verwaltung.Properties.Resources.if_Apply_132742;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadd.Location = new System.Drawing.Point(10, 396);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(93, 23);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Hinzufügen";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnbild
            // 
            this.btnbild.Image = global::Produkte_Verwaltung.Properties.Resources.if_Create_132699;
            this.btnbild.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbild.Location = new System.Drawing.Point(228, 380);
            this.btnbild.Name = "btnbild";
            this.btnbild.Size = new System.Drawing.Size(117, 23);
            this.btnbild.TabIndex = 4;
            this.btnbild.Text = "Bild auswählen";
            this.btnbild.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbild.UseVisualStyleBackColor = true;
            this.btnbild.Click += new System.EventHandler(this.btnbild_Click);
            // 
            // pbild
            // 
            this.pbild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbild.Image = global::Produkte_Verwaltung.Properties.Resources.no_image_icon_23483;
            this.pbild.Location = new System.Drawing.Point(176, 238);
            this.pbild.Name = "pbild";
            this.pbild.Size = new System.Drawing.Size(230, 136);
            this.pbild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbild.TabIndex = 11;
            this.pbild.TabStop = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Produkt Bild";
            // 
            // tbxkosten
            // 
            this.tbxkosten.Location = new System.Drawing.Point(176, 207);
            this.tbxkosten.Name = "tbxkosten";
            this.tbxkosten.Size = new System.Drawing.Size(230, 20);
            this.tbxkosten.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kosten";
            // 
            // tbxmenge
            // 
            this.tbxmenge.Location = new System.Drawing.Point(176, 181);
            this.tbxmenge.Name = "tbxmenge";
            this.tbxmenge.Size = new System.Drawing.Size(230, 20);
            this.tbxmenge.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Menge im Lager";
            // 
            // tbxpbeschreibung
            // 
            this.tbxpbeschreibung.Location = new System.Drawing.Point(176, 100);
            this.tbxpbeschreibung.Multiline = true;
            this.tbxpbeschreibung.Name = "tbxpbeschreibung";
            this.tbxpbeschreibung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxpbeschreibung.Size = new System.Drawing.Size(230, 75);
            this.tbxpbeschreibung.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Produkt Beschreibung:";
            // 
            // tbxprnr
            // 
            this.tbxprnr.Location = new System.Drawing.Point(176, 74);
            this.tbxprnr.Name = "tbxprnr";
            this.tbxprnr.Size = new System.Drawing.Size(230, 20);
            this.tbxprnr.TabIndex = 0;
            this.tbxprnr.Validated += new System.EventHandler(this.tbxprnr_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Produkt Numme:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produkt Sorte:";
            // 
            // cmbsorte
            // 
            this.cmbsorte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsorte.FormattingEnabled = true;
            this.cmbsorte.Location = new System.Drawing.Point(176, 41);
            this.cmbsorte.Name = "cmbsorte";
            this.cmbsorte.Size = new System.Drawing.Size(230, 21);
            this.cmbsorte.TabIndex = 9;
            // 
            // neues_Produkt_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 459);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "neues_Produkt_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "neues Produkt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxpbeschreibung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxprnr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbsorte;
        private System.Windows.Forms.TextBox tbxkosten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxmenge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbild;
        private System.Windows.Forms.Button btnbild;
        private System.Windows.Forms.Button btnabbrechen;
        private System.Windows.Forms.Button btnadd;
    }
}