namespace Wejsciówka
{
    partial class adminPanel
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
            this.buttonDodajPyt = new System.Windows.Forms.Button();
            this.boxPytanie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxPoprOdp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxDrugaOdp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxTrzeciaOdp = new System.Windows.Forms.TextBox();
            this.boxCzwartaOdp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDodajPyt
            // 
            this.buttonDodajPyt.Location = new System.Drawing.Point(179, 204);
            this.buttonDodajPyt.Name = "buttonDodajPyt";
            this.buttonDodajPyt.Size = new System.Drawing.Size(75, 42);
            this.buttonDodajPyt.TabIndex = 0;
            this.buttonDodajPyt.Text = "Dodaj pytanie";
            this.buttonDodajPyt.UseVisualStyleBackColor = true;
            this.buttonDodajPyt.Click += new System.EventHandler(this.buttonDodajPyt_Click);
            // 
            // boxPytanie
            // 
            this.boxPytanie.Location = new System.Drawing.Point(41, 51);
            this.boxPytanie.Name = "boxPytanie";
            this.boxPytanie.Size = new System.Drawing.Size(532, 20);
            this.boxPytanie.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Treść dodawanego pytania:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odpowiedzi: ";
            // 
            // boxPoprOdp
            // 
            this.boxPoprOdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.boxPoprOdp.Location = new System.Drawing.Point(104, 112);
            this.boxPoprOdp.Name = "boxPoprOdp";
            this.boxPoprOdp.Size = new System.Drawing.Size(136, 20);
            this.boxPoprOdp.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Poprawna odp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "druga odp";
            // 
            // boxDrugaOdp
            // 
            this.boxDrugaOdp.Location = new System.Drawing.Point(378, 112);
            this.boxDrugaOdp.Name = "boxDrugaOdp";
            this.boxDrugaOdp.Size = new System.Drawing.Size(136, 20);
            this.boxDrugaOdp.TabIndex = 7;
            this.boxDrugaOdp.TextChanged += new System.EventHandler(this.boxDrugaOdp_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "trzecia odp";
            // 
            // boxTrzeciaOdp
            // 
            this.boxTrzeciaOdp.Location = new System.Drawing.Point(104, 164);
            this.boxTrzeciaOdp.Name = "boxTrzeciaOdp";
            this.boxTrzeciaOdp.Size = new System.Drawing.Size(136, 20);
            this.boxTrzeciaOdp.TabIndex = 9;
            // 
            // boxCzwartaOdp
            // 
            this.boxCzwartaOdp.Location = new System.Drawing.Point(378, 164);
            this.boxCzwartaOdp.Name = "boxCzwartaOdp";
            this.boxCzwartaOdp.Size = new System.Drawing.Size(136, 20);
            this.boxCzwartaOdp.TabIndex = 10;
            this.boxCzwartaOdp.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "czwarta odp";
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.Location = new System.Drawing.Point(439, 223);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.Size = new System.Drawing.Size(75, 23);
            this.buttonZamknij.TabIndex = 12;
            this.buttonZamknij.Text = "Zamknij";
            this.buttonZamknij.UseVisualStyleBackColor = true;
            this.buttonZamknij.Click += new System.EventHandler(this.buttonZamknij_Click);
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(624, 281);
            this.Controls.Add(this.buttonZamknij);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxCzwartaOdp);
            this.Controls.Add(this.boxTrzeciaOdp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxDrugaOdp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxPoprOdp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxPytanie);
            this.Controls.Add(this.buttonDodajPyt);
            this.Name = "adminPanel";
            this.Text = "adminPanel";
            this.Load += new System.EventHandler(this.adminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodajPyt;
        private System.Windows.Forms.TextBox boxPytanie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxPoprOdp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxDrugaOdp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxTrzeciaOdp;
        private System.Windows.Forms.TextBox boxCzwartaOdp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonZamknij;
    }
}