namespace Zadaca_2___Selmir_Hasanovic__16926_
{
    partial class DodatniPodaciOLigi
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
            this.mojaKontrola1 = new Kontrola.MojaKontrola();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mojaKontrola1
            // 
            this.mojaKontrola1.dozvoliPrelazak = true;
            this.mojaKontrola1.izlazak = false;
            this.mojaKontrola1.klub1 = null;
            this.mojaKontrola1.klub2 = null;
            this.mojaKontrola1.klub3 = null;
            this.mojaKontrola1.klub4 = null;
            this.mojaKontrola1.Location = new System.Drawing.Point(12, 12);
            this.mojaKontrola1.Name = "mojaKontrola1";
            this.mojaKontrola1.Size = new System.Drawing.Size(356, 357);
            this.mojaKontrola1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Izađi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DodatniPodaciOLigi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mojaKontrola1);
            this.Name = "DodatniPodaciOLigi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodatni podaci o ligi";
            this.ResumeLayout(false);

        }

        #endregion

        private Kontrola.MojaKontrola mojaKontrola1;
        private System.Windows.Forms.Button button1;
    }
}