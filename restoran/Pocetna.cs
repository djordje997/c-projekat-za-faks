using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace restoran
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            label1.Text = "Dobrodošli u naš restoran\nMolimo Vas upišite Vaše ime.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Molimo Vas unesite Vaše ime da bi ste nastavili dalje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBox1.Text != "")
            {
                MessageBox.Show("Dobrodošli, " + textBox1.Text + " pritisnite OK kako bi ste nastavili.", "Dobrodošli", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string  s = textBox1.Text;
                textBox1.Clear();
                Form1 form = new Form1(s);
                form.Show(this);
            }
        }

        private void Pocetna_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter wr = new StreamWriter(@"racun.txt", false);
            wr.Write("");
            wr.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
