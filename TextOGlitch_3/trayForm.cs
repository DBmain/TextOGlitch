using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextGlitch;

namespace TextOGlitch_3
{
    public partial class trayForm : Form
    {
        [System.Runtime.InteropServices.DllImport("psapi.dll")]
        static extern int EmptyWorkingSet(IntPtr hwProc);
        string textOriginal;
        string textOutput;
        Thread name;
        private void nameChanging(object rename)
        {
            CheckForIllegalCrossThreadCalls = false;
            while (true)
            {
                int nameValue = Convert.ToInt32(numericUpDown1.Value);
                this.Text = Glitch.Text(Convert.ToString(rename), nameValue, false);
                Thread.Sleep(100);
            }
        }

        public trayForm()
        {
            InitializeComponent();
        }

        private void trayForm_Load(object sender, EventArgs e)
        {
            switch (TextOGlitchForm1.modeTray)
            {
                case 0:
                    this.Size = new Size(194, 66);
                    textBox1.ReadOnly = false;
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    numericUpDown1.Visible = true;
                    numericUpDown1.Size = new Size(31, 20);
                    numericUpDown1.Minimum = 1;
                    numericUpDown1.Maximum = 5;
                    numericUpDown1.Location = new Point(144, 3);
                    button1.Location = new Point(107, 2);
                    textBox1.Size = new Size(100, 20);
                    name = new Thread(nameChanging);
                    name.IsBackground = true;
                    name.Start("Glitch");
                    break;
                case 1:
                    this.Size = new Size(194, 66);
                    textBox1.ReadOnly = false;
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    numericUpDown1.Visible = true;
                    numericUpDown1.Size = new Size(31, 20);
                    numericUpDown1.Minimum = 1;
                    numericUpDown1.Maximum = 5;
                    numericUpDown1.Location = new Point(144, 3);
                    button1.Location = new Point(107, 2);
                    textBox1.Size = new Size(100, 20);
                    name = new Thread(nameChanging);
                    name.IsBackground = true;
                    name.Start("Light-glitch");
                    break;
                case 2:
                    this.Size = new Size(157, 66);
                    textBox1.ReadOnly = false;
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    numericUpDown1.Visible = false;
                    button1.Location = new Point(107, 2);
                    textBox1.Size = new Size(100, 20);
                    this.Text = "Replace";
                    break;
                case 3:
                    this.Size = new Size(157, 66);
                    textBox1.ReadOnly = false;
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    numericUpDown1.Visible = false;
                    button1.Location = new Point(107, 2);
                    textBox1.Size = new Size(100, 20);
                    this.Text = "Reverse";
                    break;
                case 4:
                    this.Size = new Size(246, 85);
                    textBox1.ReadOnly = true;
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    numericUpDown1.Visible = true;
                    numericUpDown1.Location = new Point(178, 3);
                    button1.Location = new Point(141, 2);
                    textBox1.Size = new Size(132, 20);
                    numericUpDown1.Size = new Size(48, 20);
                    numericUpDown1.Minimum = 1;
                    numericUpDown1.Maximum = 300;
                    this.Text = "Generate";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread a = new Thread(working);
            a.IsBackground = true;
            a.Start();
        }
        private void working()
        {
            CheckForIllegalCrossThreadCalls = false;
                switch (TextOGlitchForm1.modeTray)
                {
                    case 0:
                    if (textBox1.Text != "")
                    {
                        if (textOutput != textBox1.Text)
                        {
                            textOriginal = textBox1.Text;
                            textOutput = Glitch.Text(textOriginal, Convert.ToInt32(numericUpDown1.Value), false);
                            textBox1.Text = textOutput;
                        }
                        else
                        {
                            textOutput = Glitch.Text(textOriginal, Convert.ToInt32(numericUpDown1.Value), false);
                            textBox1.Text = textOutput;
                        }
                    }
                        break;
                case 1:
                    if (textOutput != textBox1.Text)
                    {
                        textOriginal = textBox1.Text;
                        textOutput = Glitch.Text(textOriginal, Convert.ToInt32(numericUpDown1.Value), true);
                        textBox1.Text = textOutput;
                    }
                    else
                    {
                        textOutput = Glitch.Text(textOriginal, Convert.ToInt32(numericUpDown1.Value), true);
                        textBox1.Text = textOutput;
                    }
                    break;
                case 2:
                    if (textBox1.Text != "")
                    {
                        if (textOutput != textBox1.Text)
                        {
                            textOriginal = textBox1.Text;
                            textOutput = Replace.Text(textOriginal);
                            textBox1.Text = textOutput;
                        }
                        else
                        {
                            textOutput = Replace.Text(textOriginal);
                            textBox1.Text = textOutput;
                        }
                    }
                        break;
                    case 3:
                    if (textBox1.Text != "")
                    {
                        textBox1.Text = Reverse.Text(textBox1.Text);
                    }
                        break;
                    case 4:
                        if (radioButton1.Checked)
                            {
                                textBox1.Text = Generate.TextAndNumbers(Convert.ToInt32(numericUpDown1.Value));
                            }
                        else if (radioButton2.Checked)
                            {
                                textBox1.Text = Generate.OnlyText(Convert.ToInt32(numericUpDown1.Value));
                            }
                        else if (radioButton3.Checked)
                        {
                        textBox1.Text = Generate.OnlyNumbers(Convert.ToInt32(numericUpDown1.Value));
                        }
                        break;
                    }
            try
            {
                EmptyWorkingSet(System.Diagnostics.Process.GetCurrentProcess().Handle);
            }
            catch
            {
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (textBox1.Text != "")
                {
                    Clipboard.SetText(textBox1.Text);
                }
            }
            else if (e.Button == MouseButtons.Middle)
            {
                textBox1.Text = Clipboard.GetText();
            }
        }

        private void trayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(TextOGlitchForm1.modeTray == 0 || TextOGlitchForm1.modeTray == 1)
            {
                name.Abort();
            }
        }
    }
}
