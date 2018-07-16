namespace Produkte_Verwaltung.PL
{
    partial class Produkte_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produkte_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxsuchen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnexport = new System.Windows.Forms.Button();
            this.btnneuesprodukt = new System.Windows.Forms.Button();
            this.btnalleausdrucken = new System.Windows.Forms.Button();
            this.btnlöschen = new System.Windows.Forms.Button();
            this.btnbearbeiten = new System.Windows.Forms.Button();
            this.btnausdrucken = new System.Windows.Forms.Button();
            this.bnbild = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbxsuchen
            // 
            resources.ApplyResources(this.tbxsuchen, "tbxsuchen");
            this.tbxsuchen.Name = "tbxsuchen";
            this.tbxsuchen.TextChanged += new System.EventHandler(this.tbxsuchen_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnexport);
            this.groupBox2.Controls.Add(this.btnneuesprodukt);
            this.groupBox2.Controls.Add(this.btnalleausdrucken);
            this.groupBox2.Controls.Add(this.btnlöschen);
            this.groupBox2.Controls.Add(this.btnbearbeiten);
            this.groupBox2.Controls.Add(this.btnausdrucken);
            this.groupBox2.Controls.Add(this.bnbild);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnexport
            // 
            resources.ApplyResources(this.btnexport, "btnexport");
            this.btnexport.Name = "btnexport";
            this.btnexport.UseVisualStyleBackColor = true;
            // 
            // btnneuesprodukt
            // 
            resources.ApplyResources(this.btnneuesprodukt, "btnneuesprodukt");
            this.btnneuesprodukt.Name = "btnneuesprodukt";
            this.btnneuesprodukt.UseVisualStyleBackColor = true;
            this.btnneuesprodukt.Click += new System.EventHandler(this.btnneuesprodukt_Click);
            // 
            // btnalleausdrucken
            // 
            resources.ApplyResources(this.btnalleausdrucken, "btnalleausdrucken");
            this.btnalleausdrucken.Name = "btnalleausdrucken";
            this.btnalleausdrucken.UseVisualStyleBackColor = true;
            // 
            // btnlöschen
            // 
            resources.ApplyResources(this.btnlöschen, "btnlöschen");
            this.btnlöschen.Name = "btnlöschen";
            this.btnlöschen.UseVisualStyleBackColor = true;
            this.btnlöschen.Click += new System.EventHandler(this.btnlöschen_Click);
            // 
            // btnbearbeiten
            // 
            resources.ApplyResources(this.btnbearbeiten, "btnbearbeiten");
            this.btnbearbeiten.Name = "btnbearbeiten";
            this.btnbearbeiten.UseVisualStyleBackColor = true;
            this.btnbearbeiten.Click += new System.EventHandler(this.btnbearbeiten_Click);
            // 
            // btnausdrucken
            // 
            resources.ApplyResources(this.btnausdrucken, "btnausdrucken");
            this.btnausdrucken.Name = "btnausdrucken";
            this.btnausdrucken.UseVisualStyleBackColor = true;
            // 
            // bnbild
            // 
            resources.ApplyResources(this.bnbild, "bnbild");
            this.bnbild.Name = "bnbild";
            this.bnbild.UseVisualStyleBackColor = true;
            this.bnbild.Click += new System.EventHandler(this.bnbild_Click);
            // 
            // Produkte_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxsuchen);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Produkte_Form";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxsuchen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnalleausdrucken;
        private System.Windows.Forms.Button btnausdrucken;
        private System.Windows.Forms.Button bnbild;
        private System.Windows.Forms.Button btnbearbeiten;
        private System.Windows.Forms.Button btnlöschen;
        private System.Windows.Forms.Button btnneuesprodukt;
    }
}