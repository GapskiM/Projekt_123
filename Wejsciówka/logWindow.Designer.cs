﻿namespace Wejsciówka
{
    partial class logWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nazwaUzyt = new System.Windows.Forms.TextBox();
            this.passwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(88, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "zaloguj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.loginButton);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "wyjście";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nazwaUzyt
            // 
            this.nazwaUzyt.AccessibleName = "userName";
            this.nazwaUzyt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nazwaUzyt.Location = new System.Drawing.Point(88, 66);
            this.nazwaUzyt.Name = "nazwaUzyt";
            this.nazwaUzyt.Size = new System.Drawing.Size(100, 20);
            this.nazwaUzyt.TabIndex = 2;
            // 
            // passwd
            // 
            this.passwd.AccessibleName = "passwd";
            this.passwd.Location = new System.Drawing.Point(88, 107);
            this.passwd.Name = "passwd";
            this.passwd.Size = new System.Drawing.Size(100, 20);
            this.passwd.TabIndex = 3;
            this.passwd.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "nazwa użytkownika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "hasło";
            // 
            // logWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.nazwaUzyt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "logWindow";
            this.Text = "Wejściówka - Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nazwaUzyt;
        private System.Windows.Forms.TextBox passwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

