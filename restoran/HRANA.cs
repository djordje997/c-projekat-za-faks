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
    public partial class HRANA : Form
    {
        Osoba o;
        Gost g;
        public HRANA(string s)
        {
            InitializeComponent();
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button1.Visible = false;
            o = new Osoba(s);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            button1.Visible = true;

            textBox1.AppendText("CEVAPI");
            textBox2.AppendText("200 din");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            button1.Visible = true;

            textBox1.AppendText("SARMA");
            textBox2.AppendText("250 din");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            button1.Visible = true;

            textBox1.AppendText("PECENjE");
            textBox2.AppendText("260 din");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            a = int.Parse(textBox3.Text);

            if (textBox1.Text == "CEVAPI")
                b = 200;
            else if (textBox1.Text == "SARMA")
                b = 250;
            else if (textBox1.Text == "PECENjE")
                b = 260;
            else
                b = 0;

            int c = a * b;
            textBox4.Visible = true;
            textBox4.AppendText("Vas racun iznosi: " + c + " Konobar stize za 10 min! :)");
            g = new Gost(o.Ime, c);
            g.UpisiRacun(textBox1.Text, textBox2.Text, g.Ime);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HRANA_Load(object sender, EventArgs e)
        {

        }
    }
}
