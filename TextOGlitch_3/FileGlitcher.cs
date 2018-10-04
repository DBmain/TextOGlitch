using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using TextOGlitch_3;

namespace FileGlitcherGUI
{
    public partial class FileGlitcher : Form
    {
        [System.Runtime.InteropServices.DllImport("psapi.dll")]
        static extern int EmptyWorkingSet(IntPtr hwProc);
        string fileNameWithoutExtension;
        string extension;
        string outputFileName;
        string source;
        int length;
        byte[] a;
        public static byte mode;
        Thread work;
        public FileGlitcher()
        {
            InitializeComponent();
        }
        private int random(int length, Random rand)
        {
            return rand.Next((int)numericUpDown2.Value, length);
        }
        private int random1_oneBlock(int length, int endOffset, Random rand)
        {
            return rand.Next((int)numericUpDown2.Value, length - endOffset);
        }
        private byte randomize(int symbolsToReplace, Random rand)
        {
            int rand2;
            rand2 = rand.Next(1, 256);
            return Convert.ToByte(rand2);
        }

        private void working()
        {
            TextOGlitchForm1.threadLocalization();
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                label7.Text = Translate.fg_waiting;
                openFile.Enabled = false;
                button2.Enabled = false;
                start.Enabled = false;
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
                numericUpDown6.Enabled = false;
                numericUpDown7.Enabled = false;
                blockGlitching.Enabled = false;
                oneBlockButton.Enabled = false;
                randomBlockButton.Enabled = false;
                int fileNumbers = 0;
                byte[] outByte = null;
                Random rand = new Random();
                for (int f = 1; f < numericUpDown1.Value + 1; f++)
                {
                    outByte = null;
                    int mode = (int)numericUpDown3.Value;
                    a = File.ReadAllBytes(source);
                    if (numericUpDown2.Value >= (decimal)a.Length)
                    {
                        MessageBox.Show(Translate.fg_startByteWarning, Translate.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        try
                        {
                            EmptyWorkingSet(System.Diagnostics.Process.GetCurrentProcess().Handle);
                        }
                        catch
                        {
                        }
                        break;
                    }
                    if (a.Length < 10000)
                    {
                        MessageBox.Show(Translate.fg_fileTooBig, Translate.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        try
                        {
                            EmptyWorkingSet(System.Diagnostics.Process.GetCurrentProcess().Handle);
                        }
                        catch
                        {
                        }
                        break;
                    }
                    outByte = new byte[a.Length];
                    outByte = a;
                    if(length < (int)numericUpDown4.Value)
                    {
                        MessageBox.Show(Translate.fg_mismatchOfSizes, Translate.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    int symbolsToReplace = length / (int)numericUpDown4.Value;
                    int blockToReplace = (int)numericUpDown4.Value;
                    int[] checkForRandom = new int[symbolsToReplace];
                    int randomingBlock;
                    switch (mode)
                    {
                        case 1:
                            if (!blockGlitching.Checked)
                            {
                                for (int i = 0; i < symbolsToReplace; i++)
                                {
                                    checkForRandom[i] = random(length, rand);
                                    outByte[checkForRandom[i]] = randomize(symbolsToReplace, rand);
                                    progressBar1.Value = (int)(i * 100d / symbolsToReplace);
                                }
                            }
                            else
                            {
                                if (oneBlockButton.Checked)
                                {
                                    for (int i = 0; i < blockToReplace; i++)
                                    {
                                        randomingBlock = random1_oneBlock(length, (int)numericUpDown5.Value, rand);
                                        for (int g = randomingBlock; g < randomingBlock + (int)numericUpDown5.Value; g++)
                                        {
                                            outByte[g] = randomize(length, rand);
                                        }
                                        progressBar1.Value = (int)(i * 100d / blockToReplace);
                                    }
                                }
                                else if (randomBlockButton.Checked)
                                {
                                    int currentBytesInRandomBlock;
                                    for (int i = 0; i < blockToReplace; i++)
                                    {
                                        currentBytesInRandomBlock = rand.Next((int)numericUpDown6.Value, (int)numericUpDown7.Value + 1);
                                        randomingBlock = random1_oneBlock(length, currentBytesInRandomBlock, rand);
                                        for (int g = randomingBlock; g < randomingBlock + currentBytesInRandomBlock; g++)
                                        {
                                            outByte[g] = randomize(length, rand);
                                        }
                                        progressBar1.Value = (int)(i * 100d / blockToReplace);
                                    }
                                }
                                progressBar1.Value = 100;
                            }
                            break;
                        case 2:
                            if (!blockGlitching.Checked)
                            {
                                for (int i = 0; i < symbolsToReplace; i++)
                                {
                                    checkForRandom[i] = random(length, rand);
                                    outByte[checkForRandom[i]] = 00;
                                    progressBar1.Value = (int)(i * 100d / symbolsToReplace);
                                }
                            }
                            else
                            {
                                if (oneBlockButton.Checked)
                                {
                                    for (int i = 0; i < blockToReplace; i++)
                                    {
                                        randomingBlock = random1_oneBlock(length, (int)numericUpDown5.Value, rand);
                                        for (int g = randomingBlock; g < randomingBlock + (int)numericUpDown5.Value; g++)
                                        {
                                            outByte[g] = 00;
                                        }
                                        progressBar1.Value = (int)(i * 100d / blockToReplace);
                                    }
                                }
                                else if (randomBlockButton.Checked)
                                {
                                    int currentBytesInRandomBlock;
                                    for (int i = 0; i < blockToReplace; i++)
                                    {
                                        currentBytesInRandomBlock = rand.Next((int)numericUpDown6.Value, (int)numericUpDown7.Value + 1);
                                        randomingBlock = random1_oneBlock(length, currentBytesInRandomBlock, rand);
                                        for (int g = randomingBlock; g < randomingBlock + currentBytesInRandomBlock; g++)
                                        {
                                            outByte[g] = 00;
                                        }
                                        progressBar1.Value = (int)(i * 100d / blockToReplace);
                                    }
                                }
                                progressBar1.Value = 100;
                            }
                            break;
                        case 3:
                            byte randomByte = Convert.ToByte(rand.Next(1, 256));
                            if (!blockGlitching.Checked)
                            {
                                
                                for (int i = 0; i < symbolsToReplace; i++)
                                {
                                    checkForRandom[i] = random(length, rand);
                                    outByte[checkForRandom[i]] = randomByte;
                                    //outByte[checkForRandom[i]] = a[checkForRandom[i] - 1];
                                    //outByte[checkForRandom[i] - 1] = a[checkForRandom[i]];
                                    progressBar1.Value = (int)(i * 100d / symbolsToReplace);
                                }
                            progressBar1.Value = 100;
                            }
                            else
                            {
                                if (oneBlockButton.Checked)
                                {
                                    for (int i = 0; i < blockToReplace; i++)
                                    {
                                        randomingBlock = random1_oneBlock(length, (int)numericUpDown5.Value, rand);
                                        for (int g = randomingBlock; g < randomingBlock + (int)numericUpDown5.Value; g++)
                                        {
                                            outByte[g] = randomByte;
                                        }
                                        progressBar1.Value = (int)(i * 100d / blockToReplace);
                                    }
                                    }
                                    else if (randomBlockButton.Checked)
                                    {
                                        int currentBytesInRandomBlock;
                                        for (int i = 0; i < blockToReplace; i++)
                                        {
                                            currentBytesInRandomBlock = rand.Next((int)numericUpDown6.Value, (int)numericUpDown7.Value + 1);
                                            randomingBlock = random1_oneBlock(length, currentBytesInRandomBlock, rand);
                                            for (int g = randomingBlock; g < randomingBlock + currentBytesInRandomBlock; g++)
                                            {
                                                outByte[g] = randomByte;
                                            }
                                            progressBar1.Value = (int)(i * 100d / blockToReplace);
                                        }
                                    }
                                    progressBar1.Value = 100;
                                }
                                break;
                            //Console.WriteLine(original);
                            //Console.WriteLine(Encoding.Default.GetString(outByte));
                    }
                    label10.Visible = true;
                    label10.Update();
                    do
                    {
                        if (!File.Exists(outputPath.Text + outputFileName.Replace("*", fileNumbers.ToString())))
                        {
                            File.WriteAllBytes(outputPath.Text + outputFileName.Replace("*", fileNumbers.ToString()), outByte);
                            fileNumbers++;
                            break;
                        }
                        else fileNumbers++;
                    } while (true);
                    label10.Visible = false;
                    label10.Update();
                    label7.Text = Translate.fg_filesReady + f + Translate.of + numericUpDown1.Value.ToString() + ".";
                    try
                    {
                        EmptyWorkingSet(System.Diagnostics.Process.GetCurrentProcess().Handle);
                    }
                    catch
                    {
                    }
                }
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show(Translate.fg_fileTooBig, Translate.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    EmptyWorkingSet(System.Diagnostics.Process.GetCurrentProcess().Handle);
                }
                catch
                {
                }
            }
            label8.Text = "";
            openFile.Enabled = true;
            button2.Enabled = true;
            start.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            numericUpDown4.Enabled = true;
            numericUpDown5.Enabled = true;
            numericUpDown6.Enabled = true;
            numericUpDown7.Enabled = true;
            //if (length < 100000) blockGlitching.Enabled = false;
            /*else*/ blockGlitching.Enabled = true;
            oneBlockButton.Enabled = true;
            randomBlockButton.Enabled = true;
            progressBar1.Value = 100;
            label7.Text = Translate.done;
            return;
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            FileInfo capacity;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //try
                //{
                //    a = File.ReadAllBytes(openFileDialog1.FileName);
                //}
                //catch
                //{
                //    MessageBox.Show("Невозможно прочитать файлы размером больше 2-х гигабайт, либо имеются какие-то проблемы с доступом к файлу!", "АТТЕНШН АЛЯРМ");
                //    outputPath.Text = "";
                //    sourcePath.Text = "";
                //    return;
                //}
                capacity = new FileInfo(openFileDialog1.FileName);
                if(capacity.Length > 524288000)
                {
                    MessageBox.Show(Translate.fg_limit, Translate.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //outputPath.Text = "";
                    //sourcePath.Text = "";
                    return;
                }
                sourcePath.Text = openFileDialog1.FileName;
                if (outputPath.Text == "")
                {
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    {
                        outputPath.Text = folderBrowserDialog1.SelectedPath + "\\";
                    }
                }
            }
            else return;
            source = sourcePath.Text;
            a = File.ReadAllBytes(source);
            length = a.Length;
            //if (length < 100000) blockGlitching.Enabled = false;
            /*else*/ blockGlitching.Enabled = true;
            fileLenght.Text = Translate.fg_fileSize + length;
            numericUpDown5.Enabled = true;
            numericUpDown6.Enabled = true;
            numericUpDown7.Enabled = true;
            numericUpDown4.Value = length / 10;
        }

        private void start_Click(object sender, EventArgs e)
        {
            //if(numericUpDown3.Value == 3 && blockGlitching.Checked)
            //{
            //    MessageBox.Show("Внимание! Поблочное ломание в 3 режиме не работает и работать не будет!", "НЕ РАБОТАЕТ");
            //    return;
            //}
            if (!File.Exists(sourcePath.Text) || !Directory.Exists(outputPath.Text))
            {
                MessageBox.Show(Translate.fg_pathError, Translate.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (blockGlitching.Checked)
            {
                if (oneBlockButton.Checked)
                {
                    if ((int)numericUpDown4.Value * (int)numericUpDown5.Value > length)
                    {
                        decimal value = Math.Floor(length/numericUpDown5.Value);
                        if (value == 0)
                        {
                            MessageBox.Show(Translate.fg_takeLessGlitchingBytes, Translate.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(Translate.fg_takeLessGlitchingBlocks + value, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            numericUpDown4.Value = value;
                        }
                        return;
                    }
                }
                else
                {
                    if (numericUpDown7.Value < numericUpDown6.Value)
                    {
                        int max = (int)numericUpDown6.Value;
                        int min = (int)numericUpDown7.Value;
                        numericUpDown7.Value = max;
                        numericUpDown6.Value = min;
                    }
                    if (numericUpDown6.Value > numericUpDown7.Value)
                    {
                        int max = (int)numericUpDown6.Value;
                        int min = (int)numericUpDown7.Value;
                        numericUpDown7.Value = max;
                        numericUpDown6.Value = min;
                    }
                    if ((int)numericUpDown7.Value * (int)numericUpDown4.Value > length)
                    {
                        decimal value = Math.Floor(length / numericUpDown7.Value);
                        if (value == 0)
                        {
                            MessageBox.Show(Translate.fg_takeLessGlitchingBytes, Translate.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(Translate.fg_takeLessGlitchingBlocks + value, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            numericUpDown4.Value = value;
                        }
                        return;
                    }
                }
            }
                fileNameWithoutExtension = Path.GetFileNameWithoutExtension(sourcePath.Text);
                extension = Path.GetExtension(sourcePath.Text);
                outputFileName = fileNameWithoutExtension + "_*" + extension;
                work = new Thread(working);
                work.IsBackground = true;
                work.Start();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                outputPath.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }

        //private void sourcePath_DragEnter(object sender, DragEventArgs e)
        //{
        //    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        //    if (files != null && files.Length != 0)
        //    {
        //        sourcePath.Text = files[0];
        //    }
        //}

        //private void sourcePath_DragDrop(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
        //    {
        //        e.Effect = DragDropEffects.All;
        //    }
        //}

        private void FileGlitcher_Load(object sender, EventArgs e)
        {
        }

        private void FileGlitcher_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(work != null) if (work.IsAlive) work.Abort();
        }

        private void FileGlitcher_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (work != null) if (work.IsAlive) work.Abort();
            try
            {
                EmptyWorkingSet(System.Diagnostics.Process.GetCurrentProcess().Handle);
            }
            catch
            {
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void blockGlitching_CheckedChanged(object sender, EventArgs e)
        {
            if (blockGlitching.Checked)
            {
                oneBlockButton.Visible = true;
                oneBlockButton.Checked = true;
                randomBlockButton.Visible = true;
                numericUpDown5.Value = 2;
                numericUpDown6.Value = 2;
                numericUpDown6.Value = 10;
                numericUpDown5.Enabled = true;
                numericUpDown6.Enabled = true;
                numericUpDown7.Enabled = true;
                label6.Text = Translate.fg_numberOfGlitchingBlocks;
                numericUpDown4.Location = new System.Drawing.Point(182, 100);
                numericUpDown4.Value = length / 1000;

            }
            else
            {
                oneBlockButton.Visible = false;
                oneBlockButton.Checked = false;
                randomBlockButton.Checked = false;
                randomBlockButton.Visible = false;
                numericUpDown6.Visible = false;
                numericUpDown7.Visible = false;
                numericUpDown5.Enabled = false;
                numericUpDown6.Enabled = false;
                numericUpDown7.Enabled = false;
                label6.Text = Translate.fg_glitchingRatio;
                numericUpDown4.Location = new System.Drawing.Point(286, 100);
                numericUpDown4.Value = length / 10;
                label9.Visible = false;
            }

        }

        private void oneBlockButton_CheckedChanged(object sender, EventArgs e)
        {
            if (oneBlockButton.Checked)
            {
                numericUpDown5.Visible = true;
                numericUpDown5.Value = 2;
            }
            else numericUpDown5.Visible = false;
        }

        private void randomBlockButton_CheckedChanged(object sender, EventArgs e)
        {
            if (randomBlockButton.Checked)
            {
                numericUpDown6.Visible = true;
                numericUpDown7.Visible = true;
                numericUpDown6.Value = 2;
                numericUpDown7.Value = 10;
                label9.Visible = true;
            }
            else
            {
                numericUpDown6.Visible = false;
                numericUpDown7.Visible = false;
                label9.Visible = false;
            }
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown7.Value < numericUpDown6.Value)
            {
                int max = (int)numericUpDown6.Value;
                int min = (int)numericUpDown7.Value;
                numericUpDown7.Value = max;
                numericUpDown6.Value = min;
            }
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown6.Value > numericUpDown7.Value)
            {
                int max = (int)numericUpDown6.Value;
                int min = (int)numericUpDown7.Value;
                numericUpDown7.Value = max;
                numericUpDown6.Value = min;
            }
        }

        //private void hardMode_MouseMove(object sender, MouseEventArgs e)
        //{
        //    toolTip1.Show("В обычном режиме не проверяется, глитчился ли этот байт или нет. \nВ режиме HARD такая проверка есть, но при этом, естественно, замедляется скорость работы программы.", hardMode);
        //}
    }
}
