using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextOGlitch_3
{
    public partial class Randomizer : Form
    {
        public Randomizer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if(numericUpDown1.Value < numericUpDown2.Value) label1.Text = Convert.ToString(rand.Next((int)numericUpDown1.Value, (int)numericUpDown2.Value + 1));
            else label1.Text = Convert.ToString(rand.Next((int)numericUpDown2.Value, (int)numericUpDown1.Value + 1));
        }

        private void Randomizer_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
