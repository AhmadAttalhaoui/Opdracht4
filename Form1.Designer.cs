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
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbTitel = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.tbTitel = new System.Windows.Forms.TextBox();
            this.cbTijd = new System.Windows.Forms.CheckBox();
            this.btOpslaan = new System.Windows.Forms.Button();
            this.btVolgendeTaak = new System.Windows.Forms.Button();
            this.btVerwijderTaak = new System.Windows.Forms.Button();
            this.btZetAchteraan = new System.Windows.Forms.Button();
            this.btMessage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtpTijd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(54, 171);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(62, 15);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "Informatie";
            // 
            // lbTitel
            // 
            this.lbTitel.AutoSize = true;
            this.lbTitel.Location = new System.Drawing.Point(54, 58);
            this.lbTitel.Name = "lbTitel";
            this.lbTitel.Size = new System.Drawing.Size(29, 15);
            this.lbTitel.TabIndex = 1;
            this.lbTitel.Text = "Titel";
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(54, 189);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(366, 186);
            this.tbInfo.TabIndex = 3;
            // 
            // tbTitel
            // 
            this.tbTitel.Location = new System.Drawing.Point(54, 76);
            this.tbTitel.Name = "tbTitel";
            this.tbTitel.Size = new System.Drawing.Size(270, 23);
            this.tbTitel.TabIndex = 4;
            // 
            // cbTijd
            // 
            this.cbTijd.AutoSize = true;
            this.cbTijd.Location = new System.Drawing.Point(54, 131);
            this.cbTijd.Name = "cbTijd";
            this.cbTijd.Size = new System.Drawing.Size(45, 19);
            this.cbTijd.TabIndex = 6;
            this.cbTijd.Text = "Tijd";
            this.cbTijd.UseVisualStyleBackColor = true;
            this.cbTijd.CheckedChanged += new System.EventHandler(this.cbTijd_CheckedChanged);
            // 
            // btOpslaan
            // 
            this.btOpslaan.Location = new System.Drawing.Point(54, 402);
            this.btOpslaan.Name = "btOpslaan";
            this.btOpslaan.Size = new System.Drawing.Size(154, 36);
            this.btOpslaan.TabIndex = 7;
            this.btOpslaan.Text = "Opslaan";
            this.btOpslaan.UseVisualStyleBackColor = true;
            this.btOpslaan.Click += new System.EventHandler(this.btOpslaan_Click);
            // 
            // btVolgendeTaak
            // 
            this.btVolgendeTaak.Location = new System.Drawing.Point(558, 210);
            this.btVolgendeTaak.Name = "btVolgendeTaak";
            this.btVolgendeTaak.Size = new System.Drawing.Size(100, 23);
            this.btVolgendeTaak.TabIndex = 8;
            this.btVolgendeTaak.Text = "Volgende Taak";
            this.btVolgendeTaak.UseVisualStyleBackColor = true;
            this.btVolgendeTaak.Click += new System.EventHandler(this.btVolgendeTaak_Click);
            // 
            // btVerwijderTaak
            // 
            this.btVerwijderTaak.Location = new System.Drawing.Point(558, 145);
            this.btVerwijderTaak.Name = "btVerwijderTaak";
            this.btVerwijderTaak.Size = new System.Drawing.Size(100, 23);
            this.btVerwijderTaak.TabIndex = 9;
            this.btVerwijderTaak.Text = "Verwijder Taak";
            this.btVerwijderTaak.UseVisualStyleBackColor = true;
            this.btVerwijderTaak.Click += new System.EventHandler(this.btVerwijderTaak_Click);
            // 
            // btZetAchteraan
            // 
            this.btZetAchteraan.Location = new System.Drawing.Point(558, 89);
            this.btZetAchteraan.Name = "btZetAchteraan";
            this.btZetAchteraan.Size = new System.Drawing.Size(100, 23);
            this.btZetAchteraan.TabIndex = 10;
            this.btZetAchteraan.Text = "Zet Achteraan";
            this.btZetAchteraan.UseVisualStyleBackColor = true;
            this.btZetAchteraan.Click += new System.EventHandler(this.btZetAchteraan_Click);
            // 
            // btMessage
            // 
            this.btMessage.Location = new System.Drawing.Point(558, 282);
            this.btMessage.Name = "btMessage";
            this.btMessage.Size = new System.Drawing.Size(100, 47);
            this.btMessage.TabIndex = 11;
            this.btMessage.Text = "Delen Message";
            this.btMessage.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 53);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dtpTijd
            // 
            this.dtpTijd.Location = new System.Drawing.Point(105, 127);
            this.dtpTijd.Name = "dtpTijd";
            this.dtpTijd.Size = new System.Drawing.Size(200, 23);
            this.dtpTijd.TabIndex = 13;
            this.dtpTijd.Value = new System.DateTime(2021, 10, 21, 21, 13, 9, 0);
            this.dtpTijd.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpTijd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btMessage);
            this.Controls.Add(this.btZetAchteraan);
            this.Controls.Add(this.btVerwijderTaak);
            this.Controls.Add(this.btVolgendeTaak);
            this.Controls.Add(this.btOpslaan);
            this.Controls.Add(this.cbTijd);
            this.Controls.Add(this.tbTitel);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.lbTitel);
            this.Controls.Add(this.lbInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbTitel;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.TextBox tbTitel;
        private System.Windows.Forms.CheckBox cbTijd;
        private System.Windows.Forms.Button btOpslaan;
        private System.Windows.Forms.Button btVolgendeTaak;
        private System.Windows.Forms.Button btVerwijderTaak;
        private System.Windows.Forms.Button btZetAchteraan;
        private System.Windows.Forms.Button btMessage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpTijd;
    }
}

