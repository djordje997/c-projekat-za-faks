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
    public partial class RACUN : Form
    {
        public RACUN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            StreamReader racun = new StreamReader(@"racun.txt", false);
            while (!racun.EndOfStream)
            {
                richTextBox1.AppendText(racun.ReadToEnd());
            }
            racun.Close();
        }

        private void RACUN_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            StreamReader racun = new StreamReader(@"racun.txt", false);
            while (!racun.EndOfStream)
            {
                richTextBox1.AppendText(racun.ReadToEnd());
            }
            racun.Close();
        }
    }
}
