using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Opdracht4
{
    public partial class Form1 : Form
    {
        public delegate void Zien(object Rij);
        Rij<TeDoen> list = new Rij<TeDoen>();
        private Rij<System.Timers.Timer> Tijd = new Rij<System.Timers.Timer>();
        private Rij<TeDoen> getimed = new Rij<TeDoen>();
        private Rij<DateTime> gewoonTijd = new Rij<DateTime>();
        public Form1()
        {
            InitializeComponent();
        }


        private void cbTijd_CheckedChanged(object sender, EventArgs e)
        {
            if(cbTijd.Checked == true)
            {
               dtpTijd.Visible = true;
            }
            else
            {
                dtpTijd.Visible = false;
            }
        }

        public int doeTijd()
        {
            TimeSpan wachttijd = dtpTijd.Value - DateTime.Now;
            System.Threading.Thread.Sleep((int)wachttijd.TotalMinutes);
            return (int)wachttijd.TotalMilliseconds;
        }

        public void InTijd()
        {
            Tijd = new System.Timers.Timer(doeTijd());

        }


        private void btOpslaan_Click(object sender, EventArgs e)
        {
            
            if(cbTijd.Checked == true)
            {
                if(dtpTijd.Value > DateTime.Now)
                {
                    TeDoen doen = new TeDoen(tbTitel.Text, dtpTijd.Value , tbInfo.Lines);
                    getimed.addLijst(doen);
                    /*TimeOnly.Add(dtpTijd.Value);*/
                    InTijd();
                    tbTitel.Text = "";
                    tbInfo.Text = "";

                }
                else
                {
                    MessageBox.Show("foute invoer");
                }

            }
            else
            {
                list.addLijst(new TeDoen(tbTitel.Text,tbInfo.Lines));
                tbTitel.Text = "";
                tbInfo.Text = "";
            }
                dtpTijd.Value = DateTime.Now;
        }

        private void btVolgendeTaak_Click(object sender, EventArgs e)
        {
           /* string laatZien = list.Toon();
            if(laatZien != "")
            {
                MessageBox.Show(laatZien);
            }*/
        }

        private void btVerwijderTaak_Click(object sender, EventArgs e)
        {
            list.RemoveLijst();
        }
        private void btZetAchteraan_Click(object sender, EventArgs e)
        {
           
        }


    }
}
