namespace Opdracht4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTijd = new System.Windows.Forms.Label();
            this.lbTitel = new System.Windows.Forms.Label();
            this.lbInformatie = new System.Windows.Forms.Label();
            this.tbTijd = new System.Windows.Forms.TextBox();
            this.tbTitel = new System.Windows.Forms.TextBox();
            this.tbInformatie = new System.Windows.Forms.TextBox();
            this.cbTijd = new System.Windows.Forms.CheckBox();
            this.btOpslaan = new System.Windows.Forms.Button();
            this.btVolgendeTaak = new System.Windows.Forms.Button();
            this.btVerwijderTaak = new System.Windows.Forms.Button();
            this.btZetAchteraan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTijd
            // 
            this.lbTijd.AutoSize = true;
            this.lbTijd.Location = new System.Drawing.Point(54, 96);
            this.lbTijd.Name = "lbTijd";
            this.lbTijd.Size = new System.Drawing.Size(26, 15);
            this.lbTijd.TabIndex = 0;
            this.lbTijd.Text = "Tijd";
            // 
            // lbTitel
            // 
            this.lbTitel.AutoSize = true;
            this.lbTitel.Location = new System.Drawing.Point(202, 96);
            this.lbTitel.Name = "lbTitel";
            this.lbTitel.Size = new System.Drawing.Size(29, 15);
            this.lbTitel.TabIndex = 1;
            this.lbTitel.Text = "Titel";
            // 
            // lbInformatie
            // 
            this.lbInformatie.AutoSize = true;
            this.lbInformatie.Location = new System.Drawing.Point(350, 96);
            this.lbInformatie.Name = "lbInformatie";
            this.lbInformatie.Size = new System.Drawing.Size(62, 15);
            this.lbInformatie.TabIndex = 2;
            this.lbInformatie.Text = "Informatie";
            // 
            // tbTijd
            // 
            this.tbTijd.Location = new System.Drawing.Point(26, 126);
            this.tbTijd.Name = "tbTijd";
            this.tbTijd.Size = new System.Drawing.Size(100, 23);
            this.tbTijd.TabIndex = 3;
            // 
            // tbTitel
            // 
            this.tbTitel.Location = new System.Drawing.Point(175, 126);
            this.tbTitel.Name = "tbTitel";
            this.tbTitel.Size = new System.Drawing.Size(100, 23);
            this.tbTitel.TabIndex = 4;
            // 
            // tbInformatie
            // 
            this.tbInformatie.Location = new System.Drawing.Point(320, 126);
            this.tbInformatie.Name = "tbInformatie";
            this.tbInformatie.Size = new System.Drawing.Size(100, 23);
            this.tbInformatie.TabIndex = 5;
            // 
            // cbTijd
            // 
            this.cbTijd.AutoSize = true;
            this.cbTijd.Location = new System.Drawing.Point(454, 130);
            this.cbTijd.Name = "cbTijd";
            this.cbTijd.Size = new System.Drawing.Size(45, 19);
            this.cbTijd.TabIndex = 6;
            this.cbTijd.Text = "Tijd";
            this.cbTijd.UseVisualStyleBackColor = true;
            // 
            // btOpslaan
            // 
            this.btOpslaan.Location = new System.Drawing.Point(202, 199);
            this.btOpslaan.Name = "btOpslaan";
            this.btOpslaan.Size = new System.Drawing.Size(75, 23);
            this.btOpslaan.TabIndex = 7;
            this.btOpslaan.Text = "Opslaan";
            this.btOpslaan.UseVisualStyleBackColor = true;
            // 
            // btVolgendeTaak
            // 
            this.btVolgendeTaak.Location = new System.Drawing.Point(28, 264);
            this.btVolgendeTaak.Name = "btVolgendeTaak";
            this.btVolgendeTaak.Size = new System.Drawing.Size(98, 23);
            this.btVolgendeTaak.TabIndex = 8;
            this.btVolgendeTaak.Text = "Volgende Taak";
            this.btVolgendeTaak.UseVisualStyleBackColor = true;
            // 
            // btVerwijderTaak
            // 
            this.btVerwijderTaak.Location = new System.Drawing.Point(175, 264);
            this.btVerwijderTaak.Name = "btVerwijderTaak";
            this.btVerwijderTaak.Size = new System.Drawing.Size(100, 23);
            this.btVerwijderTaak.TabIndex = 9;
            this.btVerwijderTaak.Text = "Verwijder Taak";
            this.btVerwijderTaak.UseVisualStyleBackColor = true;
            // 
            // btZetAchteraan
            // 
            this.btZetAchteraan.Location = new System.Drawing.Point(320, 264);
            this.btZetAchteraan.Name = "btZetAchteraan";
            this.btZetAchteraan.Size = new System.Drawing.Size(100, 23);
            this.btZetAchteraan.TabIndex = 10;
            this.btZetAchteraan.Text = "Zet Achteraan";
            this.btZetAchteraan.UseVisualStyleBackColor = true;
            this.btZetAchteraan.Click += new System.EventHandler(this.btZetAchteraan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btZetAchteraan);
            this.Controls.Add(this.btVerwijderTaak);
            this.Controls.Add(this.btVolgendeTaak);
            this.Controls.Add(this.btOpslaan);
            this.Controls.Add(this.cbTijd);
            this.Controls.Add(this.tbInformatie);
            this.Controls.Add(this.tbTitel);
            this.Controls.Add(this.tbTijd);
            this.Controls.Add(this.lbInformatie);
            this.Controls.Add(this.lbTitel);
            this.Controls.Add(this.lbTijd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTijd;
        private System.Windows.Forms.Label lbTitel;
        private System.Windows.Forms.Label lbInformatie;
        private System.Windows.Forms.TextBox tbTijd;
        private System.Windows.Forms.TextBox tbTitel;
        private System.Windows.Forms.TextBox tbInformatie;
        private System.Windows.Forms.CheckBox cbTijd;
        private System.Windows.Forms.Button btOpslaan;
        private System.Windows.Forms.Button btVolgendeTaak;
        private System.Windows.Forms.Button btVerwijderTaak;
        private System.Windows.Forms.Button btZetAchteraan;
    }
}

