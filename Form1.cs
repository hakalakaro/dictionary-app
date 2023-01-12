using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_dictionary
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> kirjasto = new Dictionary<string, string>();
        public Form1()
        {
            
            InitializeComponent();
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> kirjasto = new Dictionary<string, string>();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kirjasto.Add(textBox1.Text.ToString(), textBox2.Text.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = kirjasto[textBox3.Text.ToString()];
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
