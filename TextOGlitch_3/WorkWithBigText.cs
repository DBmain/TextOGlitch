using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextGlitch;

namespace TextOGlitch_3
{
    public partial class WorkWithBigText : Form
    {
        static string output;
        static string workString;
        static Thread reverse;
        static Thread glitch;
        static Thread replace;
        static char[] work;
        static char[] reverseWork;
        static char[] unicodeSquares =
        {
            '\u0000', '\u0001', '\u0002', '\u0003', '\u0004', '\u0005', '\u0006', '\u0007', '\u0008', '\u0009', '\u000b', '\u000c', '\u000d', '\u000e', '\u000f',
            '\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017', '\u0018', '\u0019', '\u001a', '\u001b', '\u001c', '\u001d', '\u001e', '\u001f', '\u007f'
        };
        private void reversing()
        {
            CheckForIllegalCrossThreadCalls = false;
            ////for (int i = 0; i < work.Length; i++)
            ////{
            //if (work[i] != '\r')
            //{
            ////    reverseWork[reverseWork.Length - i - 1] = work[i];
            ////    label1.Text = "Реверснуто символов: " + (i + 1) + "/" + work.Length;
            //}
            //else
            //{
            //    reverseWork[reverseWork.Length - i - 1] = work[i + 1];
            //    reverseWork[reverseWork.Length - i - 2] = work[i];
            //    i++;
            //}
            ////label1.Update();
            ////}
            output = new string(work);
            output = output.Trim('\r');
            output = Reverse.Text(output);
            ////output = new string(reverseWork);
            richTextBox2.Text = output;
            label1.Text = "Готово!";
            richTextBox1.Enabled = true;
            glitchMass.Enabled = true;
            replaceMass.Enabled = true;
            reverseMass.Enabled = true;
            startMass.Enabled = true;
            paste.Enabled = true;
        }
        private void glitchingOneString()
        {
            CheckForIllegalCrossThreadCalls = false;
            richTextBox2.Text = "";
            workString = richTextBox1.Text;
            if (lightMass.Checked)
            {
                for (int i = 0; i < glitchOneStringCount.Value; i++)
                {
                    richTextBox2.Text = richTextBox2.Text + TextGlitch.Glitch.Text(workString, (int)numericUpDown1.Value, true) + "\n";
                    //tempOutput = tempOutput.Replace("\n", null);
                    //tempOutput = tempOutput.Replace("\r", null);
                    //output = output + tempOutput + "\n";
                    richTextBox2.Update();
                    label1.Text = (i + 1) + "/" + glitchOneStringCount.Value + " готово...";
                    label1.Update();
                }
            }
            else
            {
                for (int i = 0; i < glitchOneStringCount.Value; i++)
                {
                    richTextBox2.Text = richTextBox2.Text + TextGlitch.Glitch.Text(workString, (int)numericUpDown1.Value, false) + "\n";
                    //tempOutput = TextGlitch.Glitch.Text(workString, (int)numericUpDown1.Value, false);
                    //tempOutput = tempOutput.Replace("\n", null);
                    //tempOutput = tempOutput.Replace("\r", null);
                    //output = output + tempOutput + "\n";
                    richTextBox2.Update();
                    label1.Text = (i + 1) + "/" + glitchOneStringCount.Value + " готово...";
                    label1.Update();
                }
            }
            label1.Text = "Готово!";
            richTextBox1.Enabled = true;
            glitchMass.Enabled = true;
            reverseMass.Enabled = true;
            replaceMass.Enabled = true;
            lightMass.Enabled = true;
            glitchOneStringCheckBox.Enabled = true;
            glitchOneStringCount.Enabled = true;
            numericUpDown1.Enabled = true;
            startMass.Enabled = true;
            paste.Enabled = true;
            return;
        }
        private void glitching()
        {
            CheckForIllegalCrossThreadCalls = false;
            label1.Text = "Пожалуйста, подождите, идёт процесс глитча...";
            label1.Update();
            output = Glitch.Text(workString, Convert.ToInt32(numericUpDown1.Value), false);
            if (!lightMass.Checked)
            {
                richTextBox2.Text = output;
            }
            else if (lightMass.Checked)
            {
                //char[] light = output.ToCharArray();
                //int count = 0;
                //foreach(char b in light)
                //{
                //    if(b == '�' || unicodeSquares.Contains(b))
                //    {
                //        count++;
                //    }
                //}
                //char[] outputLight = new char[light.Length - count];
                //int i = 0;
                //foreach (char b in light)
                //{
                //    if(b != '�' && !unicodeSquares.Contains(b))
                //    {
                //        outputLight[i] = b;
                //        i++;
                //    }
                //    else
                //    {
                //        continue;
                //    }
                //}
                //output = new string(outputLight);
                richTextBox2.Text = Glitch.Text(richTextBox1.Text, Convert.ToInt32(numericUpDown1.Value), true);
            }
            label1.Text = "Готово!";
            richTextBox1.Enabled = true;
            glitchOneStringCheckBox.Enabled = true;
            glitchMass.Enabled = true;
            replaceMass.Enabled = true;
            reverseMass.Enabled = true;
            numericUpDown1.Enabled = true;
            lightMass.Enabled = true;
            startMass.Enabled = true;
            paste.Enabled = true;
        }

        private void replacing()
        {
            CheckForIllegalCrossThreadCalls = false;
            label1.Text = "Пожалуйста, подождите, идёт процесс замены...";
            label1.Update();
            output = Replace.Text(workString);
            label1.Text = "Готово!";
            richTextBox2.Text = output;
            richTextBox1.Enabled = true;
            glitchMass.Enabled = true;
            replaceMass.Enabled = true;
            reverseMass.Enabled = true;
            startMass.Enabled = true;
            paste.Enabled = true;
        }

        public WorkWithBigText()
        {
            InitializeComponent();
        }

        private void glitchMass_Click(object sender, EventArgs e)
        {
            lightMass.Enabled = true;
            numericUpDown1.Enabled = true;
        }

        private void replaceMass_Click(object sender, EventArgs e)
        {
            lightMass.Enabled = false;
            numericUpDown1.Enabled = false;
        }

        private void reverseMass_Click(object sender, EventArgs e)
        {
            lightMass.Enabled = false;
            numericUpDown1.Enabled = false;
        }

        private void startMass_Click(object sender, EventArgs e)
        {
            startMass.Enabled = false;
            paste.Enabled = false;
            output = null;
            if (glitchMass.Checked && glitchOneStringCheckBox.Checked)
            {
                if (Convert.ToInt32(numericUpDown1.Value) > richTextBox1.Text.Length)
                {
                    MessageBox.Show("Степень глитча не может быть больше длины текста, либо же поле для ввода пустое!", "Предупреждение");
                    startMass.Enabled = true;
                    paste.Enabled = true;
                    return;
                }
                else
                {
                richTextBox1.Enabled = false;
                glitchMass.Enabled = false;
                reverseMass.Enabled = false;
                replaceMass.Enabled = false;
                lightMass.Enabled = false;
                glitchOneStringCheckBox.Enabled = false;
                glitchOneStringCount.Enabled = false;
                numericUpDown1.Enabled = false;
                richTextBox2.Text = "";
                glitch = new Thread(glitchingOneString);
                glitch.IsBackground = true;
                glitch.Start();
                return;
                }
            }
            work = richTextBox1.Text.ToCharArray();
            reverseWork = new char[work.Length];
            workString = new string(work);
            if (glitchMass.Checked)
            {
                if (Convert.ToInt32(numericUpDown1.Value) > workString.Length)
                {
                    MessageBox.Show("Степень глитча не может быть больше длины текста, либо же поле для ввода пустое!", "Предупреждение");
                    startMass.Enabled = true;
                    paste.Enabled = true;
                    return;
                }
                else
                {
                    richTextBox1.Enabled = false;
                    glitchMass.Enabled = false;
                    replaceMass.Enabled = false;
                    reverseMass.Enabled = false;
                    numericUpDown1.Enabled = false;
                    lightMass.Enabled = false;
                    glitchOneStringCheckBox.Enabled = false;
                    richTextBox2.Text = "";
                    glitch = new Thread(glitching);
                    glitch.IsBackground = true;
                    glitch.Start();
                }
            }
            else if (replaceMass.Checked)
            {
                richTextBox1.Enabled = false;
                glitchMass.Enabled = false;
                replaceMass.Enabled = false;
                reverseMass.Enabled = false;
                richTextBox2.Text = "";
                replace = new Thread(replacing);
                replace.IsBackground = true;
                replace.Start();
            }
            else if (reverseMass.Checked)
            {
                richTextBox1.Enabled = false;
                glitchMass.Enabled = false;
                replaceMass.Enabled = false;
                reverseMass.Enabled = false;
                richTextBox2.Text = "";
                reverse = new Thread(reversing);
                reverse.IsBackground = true;
                reverse.Start();
            }
        }

        private void copy_Click(object sender, EventArgs e)
        {
            if(richTextBox2.Text != "")
            {
                Clipboard.SetText(richTextBox2.Text);
            }
        }

        private void paste_Click(object sender, EventArgs e)
        {
            if(Clipboard.GetText() != "")
            {
                richTextBox1.Text = Clipboard.GetText();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void glitchOneStringCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (glitchOneStringCheckBox.Checked)
            {
                richTextBox1.Text = "";
                richTextBox1.Multiline = false;
                //richTextBox1.Enabled = false;
                label2.Visible = true;
                glitchOneStringCount.Visible = true;
            }
            else
            {
                richTextBox1.Multiline = true;
                //richTextBox1.Enabled = true;
                label2.Visible = false;
                glitchOneStringCount.Visible = false;
            }
            }

        private void reverseMass_CheckedChanged(object sender, EventArgs e)
        {
            if (reverseMass.Checked)
            {
                glitchOneStringCheckBox.Checked = false;
                glitchOneStringCheckBox.Enabled = false;
            }
        }

        private void replaceMass_CheckedChanged(object sender, EventArgs e)
        {
            if (replaceMass.Checked)
            {
                glitchOneStringCheckBox.Checked = false;
                glitchOneStringCheckBox.Enabled = false;
            }
        }

        private void glitchMass_CheckedChanged(object sender, EventArgs e)
        {
            if (glitchMass.Checked) glitchOneStringCheckBox.Enabled = true;
        }

        private void WorkWithBigText_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(replace != null) if (replace.IsAlive) replace.Abort();
            if (glitch != null) if (glitch.IsAlive) glitch.Abort();
            if (reverse != null) if (reverse.IsAlive) reverse.Abort();

        }
    }   
    }
