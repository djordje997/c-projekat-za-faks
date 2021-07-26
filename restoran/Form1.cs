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

    public partial class Form1 : Form
    {
        System.Media.SoundPlayer pesma = new System.Media.SoundPlayer();
        Osoba o;
        public Form1(string s)
        {
            InitializeComponent();
            pesma.SoundLocation = "Haris_Dzinovic_-_Poznaces_Me_I_Po_Mraku.wav";
            richTextBox1.Visible = false;
            button2.Visible = false;
            o = new Osoba(s);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HRANA hrans = new HRANA(o.Ime);
            hrans.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PICE pice = new PICE(o.Ime);
            pice.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RACUN rac = new RACUN();
            rac.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pesma.Play();
            label4.Text = "Dobrodošli : " + o.Ime;
        }

        private void iNFORMACIJEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            button2.Visible = true;
            richTextBox1.Clear();
            StreamReader info = new StreamReader(@"info.txt", false);
            while (!info.EndOfStream)
            {
                richTextBox1.AppendText(info.ReadToEnd());
            }
            info.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            button2.Visible = false;
        }

        private void rADNOVREMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            button2.Visible = true;
            richTextBox1.Clear();
            StreamReader rv = new StreamReader(@"radnovreme.txt", false);
            while (!rv.EndOfStream)
            {
                richTextBox1.AppendText(rv.ReadToEnd());
            }
            rv.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter wr = new StreamWriter(@"racun.txt", false);
            wr.Write("");
            wr.Close();
        }
    }
}
