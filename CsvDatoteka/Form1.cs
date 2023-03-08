using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvDatoteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void unos_Click(object sender, EventArgs e)
        {
            List<Osoba> listOsoba = new List<Osoba>();

            try 
            {
                Osoba osoba = new Osoba(ime.Text,prezime.Text,email.Text,Convert.ToInt16(godRod.Text));
                ime.Clear();
                prezime.Clear();
                email.Clear();
                godRod.Clear();

                DialogResult upit = 
                    MessageBox.Show("Želite li unesti još podatka", "Unos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (upit)
                {
                    case DialogResult.Yes:
                    {
                         listOsoba.Add(osoba);
                         break;
                    }
                    case DialogResult.No:
                    {
                        listOsoba.Add(osoba);
                        break;
                    }
                }
            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message,"Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            String file = @"C:\CsvIspis\Output.csv";
        }







        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
