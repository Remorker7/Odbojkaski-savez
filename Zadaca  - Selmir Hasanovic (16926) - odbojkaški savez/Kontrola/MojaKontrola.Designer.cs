namespace Kontrola
{
    partial class MojaKontrola
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IspisKlubova = new Kontrola.KontrolaZaIspis();
            this.button1 = new System.Windows.Forms.Button();
            this.CBKlubovi = new System.Windows.Forms.CheckBox();
            this.TBID = new System.Windows.Forms.TextBox();
            this.TBNazivLige = new System.Windows.Forms.TextBox();
            this.TBDržava = new System.Windows.Forms.TextBox();
            this.NUDKola = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPOsnivanje = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDKola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IspisKlubova);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.CBKlubovi);
            this.groupBox1.Controls.Add(this.TBID);
            this.groupBox1.Controls.Add(this.TBNazivLige);
            this.groupBox1.Controls.Add(this.TBDržava);
            this.groupBox1.Controls.Add(this.NUDKola);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DTPOsnivanje);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o ligi";
            // 
            // IspisKlubova
            // 
            this.IspisKlubova.CetvrtiKlub = "label4";
            this.IspisKlubova.DrugiKlub = "label2";
            this.IspisKlubova.Location = new System.Drawing.Point(99, 239);
            this.IspisKlubova.Name = "IspisKlubova";
            this.IspisKlubova.PrviKlub = "label1";
            this.IspisKlubova.Size = new System.Drawing.Size(174, 131);
            this.IspisKlubova.TabIndex = 12;
            this.IspisKlubova.TreciKlub = "label3";
            this.IspisKlubova.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Spasi podatke";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBKlubovi
            // 
            this.CBKlubovi.AutoSize = true;
            this.CBKlubovi.Location = new System.Drawing.Point(99, 182);
            this.CBKlubovi.Name = "CBKlubovi";
            this.CBKlubovi.Size = new System.Drawing.Size(155, 17);
            this.CBKlubovi.TabIndex = 10;
            this.CBKlubovi.Text = "Prikaži spisak klubova u ligi";
            this.CBKlubovi.UseVisualStyleBackColor = true;
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(99, 156);
            this.TBID.Name = "TBID";
            this.TBID.Size = new System.Drawing.Size(100, 20);
            this.TBID.TabIndex = 9;
            this.TBID.Validating += new System.ComponentModel.CancelEventHandler(this.TBID_Validating);
            this.TBID.Validated += new System.EventHandler(this.TBID_Validated);
            // 
            // TBNazivLige
            // 
            this.TBNazivLige.Location = new System.Drawing.Point(99, 51);
            this.TBNazivLige.Name = "TBNazivLige";
            this.TBNazivLige.Size = new System.Drawing.Size(200, 20);
            this.TBNazivLige.TabIndex = 8;
            this.TBNazivLige.Validating += new System.ComponentModel.CancelEventHandler(this.TBNazivLige_Validating);
            this.TBNazivLige.Validated += new System.EventHandler(this.TBNazivLige_Validated);
            // 
            // TBDržava
            // 
            this.TBDržava.Location = new System.Drawing.Point(99, 129);
            this.TBDržava.Name = "TBDržava";
            this.TBDržava.Size = new System.Drawing.Size(200, 20);
            this.TBDržava.TabIndex = 7;
            this.TBDržava.Validating += new System.ComponentModel.CancelEventHandler(this.TBDržava_Validating);
            this.TBDržava.Validated += new System.EventHandler(this.TBDržava_Validated);
            // 
            // NUDKola
            // 
            this.NUDKola.Location = new System.Drawing.Point(99, 103);
            this.NUDKola.Maximum = new decimal(new int[] {
            38,
            0,
            0,
            0});
            this.NUDKola.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDKola.Name = "NUDKola";
            this.NUDKola.Size = new System.Drawing.Size(42, 20);
            this.NUDKola.TabIndex = 6;
            this.NUDKola.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Broj kôla: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Naziv lige: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Država: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID lige:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum osnivanja: ";
            // 
            // DTPOsnivanje
            // 
            this.DTPOsnivanje.Location = new System.Drawing.Point(99, 77);
            this.DTPOsnivanje.Name = "DTPOsnivanje";
            this.DTPOsnivanje.Size = new System.Drawing.Size(200, 20);
            this.DTPOsnivanje.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MojaKontrola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "MojaKontrola";
            this.Size = new System.Drawing.Size(358, 387);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDKola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CBKlubovi;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.TextBox TBNazivLige;
        private System.Windows.Forms.TextBox TBDržava;
        private System.Windows.Forms.NumericUpDown NUDKola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTPOsnivanje;
        private KontrolaZaIspis IspisKlubova;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
