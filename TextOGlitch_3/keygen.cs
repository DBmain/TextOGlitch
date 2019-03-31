using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using TextGlitch;
using TextOGlitch;

namespace TextOGlitch_3
{
    public partial class keygen : Form
    {
        public keygen()
        {
            InitializeComponent();
        }

        private void copyOne_Click(object sender, EventArgs e)
        {
            if(keyOneOut.Text != "")
            {
                Clipboard.SetText(keyOneOut.Text);
            }
        }

        private void keyGeneration(object number)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            for (int i = 1; i < Convert.ToInt32(numericUpDown1.Value) + 1; i++)
            {
                if (i != Convert.ToInt32(numericUpDown1.Value))
                {
                    massKeyOut.Text += Keygen.Create(Convert.ToInt32(symbols.Value), Convert.ToInt32(blocks.Value)) + "\r";
                }
                else
                {
                    massKeyOut.Text += Keygen.Create(Convert.ToInt32(symbols.Value), Convert.ToInt32(blocks.Value));
                }
                massKeyOut.Update();
                generationProcess.Text = Translate.keysGenerated + i + "/" + Convert.ToInt32(numericUpDown1.Value) + ".";
                generationProcess.Update();
            }
            symbols.Enabled = true;
            blocks.Enabled = true;
            numericUpDown1.Enabled = true;
            saving.Enabled = true;
            startMassGen.Enabled = true;
            generationProcess.Text = Translate.done;
        }
        private void oneKey(object sender)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            keyOneOut.Text = Keygen.Create(Convert.ToInt32(symbols.Value), Convert.ToInt32(blocks.Value));
        }

        Thread key;
        public void generateOneKey_Click(object sender, EventArgs e)
        {
            key = new Thread(oneKey);
            key.IsBackground = true;
            key.Start(sender);
        }
        Thread masskey;
        public void startMassGen_Click(object sender, EventArgs e)
        {
                massKeyOut.Text = string.Empty;
                startMassGen.Enabled = false;
                symbols.Enabled = false;
                blocks.Enabled = false;
                numericUpDown1.Enabled = false;
                saving.Enabled = false;
                masskey = new Thread(keyGeneration);
                masskey.IsBackground = true;
                masskey.Start();
        }

        private void saving_Click(object sender, EventArgs e)
        {
            var result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                StreamWriter a = new StreamWriter(filePath, false);
                a.WriteLine(massKeyOut.Text);
                a.Close();
            }
        }

        private void keygen_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void keygen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (masskey != null) if (masskey.IsAlive) masskey.Abort();
            e.Cancel = false;
            //this.Close();
        }
    }
}
