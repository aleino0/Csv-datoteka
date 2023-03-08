
namespace CsvDatoteka
{
    partial class Form1
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
            this.ime = new System.Windows.Forms.TextBox();
            this.prezime = new System.Windows.Forms.TextBox();
            this.godRod = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.unos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ime
            // 
            this.ime.Location = new System.Drawing.Point(20, 16);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(100, 20);
            this.ime.TabIndex = 0;
            this.ime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // prezime
            // 
            this.prezime.Location = new System.Drawing.Point(20, 42);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(100, 20);
            this.prezime.TabIndex = 1;
            // 
            // godRod
            // 
            this.godRod.Location = new System.Drawing.Point(20, 68);
            this.godRod.Name = "godRod";
            this.godRod.Size = new System.Drawing.Size(100, 20);
            this.godRod.TabIndex = 2;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(20, 94);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 4;
            // 
            // unos
            // 
            this.unos.Location = new System.Drawing.Point(33, 165);
            this.unos.Name = "unos";
            this.unos.Size = new System.Drawing.Size(75, 23);
            this.unos.TabIndex = 5;
            this.unos.Text = "Unos";
            this.unos.UseVisualStyleBackColor = true;
            this.unos.Click += new System.EventHandler(this.unos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.unos);
            this.Controls.Add(this.email);
            this.Controls.Add(this.godRod);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.ime);
            this.Name = "Form1";
            this.Text = "CsvDatoteka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.TextBox prezime;
        private System.Windows.Forms.TextBox godRod;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button unos;
    }
}

