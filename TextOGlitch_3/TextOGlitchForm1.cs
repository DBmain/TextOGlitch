using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using TextGlitch;
using System.Globalization;
using System.Diagnostics;
using TextOGlitch;

namespace TextOGlitch_3
{
    public partial class TextOGlitchForm1 : Form
    {
        private string[] args;
        public static char[] workFileText;
        bool exitFromForm = false;
        bool exitMessage = true;
        bool fromArgsLaunchForm = true;
        bool checkArgs = true;
        bool ifTrayLaunched = false;
        Thread name;
        static char[] unicodeSquares =
        {
            '\u0000', '\u0001', '\u0002', '\u0003', '\u0004', '\u0005', '\u0006', '\u0007', '\u0008', '\u0009', '\u000b', '\u000c', '\u000d', '\u000e', '\u000f',
            '\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017', '\u0018', '\u0019', '\u001a', '\u001b', '\u001c', '\u001d', '\u001e', '\u001f', '\u007f'
        };
        trayForm a;
        FileGlitcherGUI.FileGlitcher y;

        public static byte mode = 0;
        public static byte modeTray = 0;
        [System.Runtime.InteropServices.DllImport("psapi.dll")]
        static extern int EmptyWorkingSet(IntPtr hwProc);
        public TextOGlitchForm1(string[] args)
        {
            this.args = args;
            if (!File.Exists("ru/rus"))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            }
            InitializeComponent();
        }

        public static void threadLocalization()
        {
            CultureInfo ci;
            if (!File.Exists("ru/rus")) ci = new CultureInfo("en-US");
            else ci = new CultureInfo("ru");
            Thread.CurrentThread.CurrentUICulture = ci;
        }

        private void nameChanging(object rename)
        {
            CheckForIllegalCrossThreadCalls = false;
            while (true)
            {
                int nameValue = Convert.ToInt32(glitchExtent.Value);
                if (nameValue <= 5)
                {
                    this.Text = Glitch.Text(Convert.ToString(rename), nameValue, true);
                }
                else
                {
                    this.Text = Glitch.Text(Convert.ToString(rename), 5, true);
                }
                Thread.Sleep(200);
            }
        }
        private void copyButton_Click(object sender, EventArgs e)
        {
            if (textOut.Text != "")
            {
                Clipboard.SetText(textOut.Text);
            }
        }
        Thread work;
        private void start_Click(object sender, EventArgs e)
        {
            if (textIn.Text != "" || (mode == 3 || mode == 4 || mode == 5))
            {
                work = new Thread(working);
                work.IsBackground = true;
                work.Start();
            }
        }

        private void working()
        {
            TextOGlitchForm1.threadLocalization();
            CheckForIllegalCrossThreadCalls = false;
            switch (mode)
            {
                case 0:
                    string output;
                    if (!lightGlitch.Checked)
                    {
                        output = Glitch.Text(textIn.Text, Convert.ToInt32(glitchExtent.Value), false);
                        output = output.Replace("\r", null);
                        output = output.Replace("\n", null);
                        textOut.Text = output;
                    }
                    else if (lightGlitch.Checked)
                    {
                        output = Glitch.Text(textIn.Text, Convert.ToInt32(glitchExtent.Value), true);
                        output = output.Replace("\r", null);
                        output = output.Replace("\n", null);
                        textOut.Text = output;
                    }
                    break;
                case 1:
                    textOut.Text = Replace.Text(textIn.Text);
                    break;
                case 2:
                    textOut.Text = Reverse.Text(textIn.Text);
                    break;
                case 3:
                    textOut.Text = Generate.TextAndNumbers(Convert.ToInt32(glitchExtent.Value));
                    break;
                case 4:
                    textOut.Text = Generate.OnlyText(Convert.ToInt32(glitchExtent.Value));
                    break;
                case 5:
                    textOut.Text = Generate.OnlyNumbers(Convert.ToInt32(glitchExtent.Value));
                    break;
                case 6:
                    textOut.Text = EasyBase64.Encode(textIn.Text);
                    break;
                case 7:
                    string outText = textOut.Text = EasyBase64.Decode(textIn.Text);
                    if (outText == "It is not Base64.")
                    {
                        textOut.Text = Translate.itsNotBase;
                    }
                    else textOut.Text = outText;
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
        private void TextOGlitchForm1_Load(object sender, EventArgs e)
        {
            ramClean.Enabled = true;
            a = new trayForm();
            if (this.args.Length > 0 && checkArgs)
            {
                if (args[0] == "-tray")
                {
                    ifTrayLaunched = true;
                    launchTray();
                }
                checkArgs = false;
            }
            if (!ifTrayLaunched)
            {
                    name = new Thread(nameChanging);
                    name.IsBackground = true;
                    name.Start("Text'O'Glitch");
            }
        }
        private void TextOGlitchForm1_Shown(object sender, EventArgs e)
        {
            if (args.Length > 0 && fromArgsLaunchForm && ifTrayLaunched)
            {
                fromArgsLaunchForm = false;
                this.Hide();
            }
        }

        private void exitMenuStrip_Click(object sender, EventArgs e)
        {
            exitMessage = false;
            try
            {
                Application.Exit();
            }
            catch { };
        }


        private void glitchMenu_Click(object sender, EventArgs e)
        {
            lightGlitch.Enabled = true;
            glitchExtent.Enabled = true;
            mode = 0;
            textOut.Text = "";
            if (gli4.Checked == true)
            {
                gli4.Checked = true;
                textIn.Enabled = true;
                zamena.Checked = false;
                revers.Checked = false;
                bukvi_i_cifri.Checked = false;
                bukvi.Checked = false;
                totext.Checked = false;
                tobase.Checked = false;
                cifri.Checked = false;
            }
            else if (gli4.Checked == false)
            {
                gli4.Checked = true;
            }
            label2.Text = Translate.glitchExtent;
            glitchExtent.Maximum = 5;
        }

        private void replaceMenu_Click(object sender, EventArgs e)
        {
            lightGlitch.Enabled = false;
            glitchExtent.Enabled = false;
            mode = 1;
            textOut.Text = "";
            if (zamena.Checked == true)
            {
                zamena.Checked = true;
                textIn.Enabled = true;
                gli4.Checked = false;
                revers.Checked = false;
                bukvi_i_cifri.Checked = false;
                bukvi.Checked = false;
                totext.Checked = false;
                tobase.Checked = false;
                cifri.Checked = false;
            }
            else if (zamena.Checked == false)
            {
                zamena.Checked = true;
            }
            label2.Text = Translate.glitchExtent;
            glitchExtent.Maximum = 5;
        }

        private void reverseMenu_Click(object sender, EventArgs e)
        {
            lightGlitch.Enabled = false;
            glitchExtent.Enabled = false;
            mode = 2;
            textOut.Text = "";
            if (revers.Checked == true)
            {
                revers.Checked = true;
                textIn.Enabled = true;
                zamena.Checked = false;
                gli4.Checked = false;
                bukvi_i_cifri.Checked = false;
                bukvi.Checked = false;
                totext.Checked = false;
                tobase.Checked = false;
                cifri.Checked = false;
            }
            else if (revers.Checked == false)
            {
                revers.Checked = true;
            }
            label2.Text = Translate.glitchExtent;
            glitchExtent.Maximum = 5;
        }

        private void lettersAndNumbersMenu_Click(object sender, EventArgs e)
        {
            lightGlitch.Enabled = false;
            glitchExtent.Enabled = true;
            mode = 3;
            textOut.Text = "";
            if (bukvi_i_cifri.Checked == true)
            {
                bukvi_i_cifri.Checked = true;
                textIn.Enabled = false;
                zamena.Checked = false;
                revers.Checked = false;
                gli4.Checked = false;
                bukvi.Checked = false;
                totext.Checked = false;
                tobase.Checked = false;
                cifri.Checked = false;
            }
            else if (bukvi_i_cifri.Checked == false)
            {
                bukvi_i_cifri.Checked = true;
            }
            label2.Text = Translate.size;
            glitchExtent.Maximum = 300;
        }

        private void onlyLettersMenu_Click(object sender, EventArgs e)
        {
            lightGlitch.Enabled = false;
            glitchExtent.Enabled = true;
            mode = 4;
            textOut.Text = "";
            if (bukvi.Checked == true)
            {
                bukvi.Checked = true;
                textIn.Enabled = false;
                zamena.Checked = false;
                revers.Checked = false;
                bukvi_i_cifri.Checked = false;
                gli4.Checked = false;
                totext.Checked = false;
                tobase.Checked = false;
                cifri.Checked = false;
            }
            else if (bukvi.Checked == false)
            {
                bukvi.Checked = true;
            }
            label2.Text = Translate.size;
            glitchExtent.Maximum = 300;
        }

        private void cifri_Click(object sender, EventArgs e)
        {
            lightGlitch.Enabled = false;
            glitchExtent.Enabled = true;
            mode = 5;
            textOut.Text = "";
            if (cifri.Checked != true)
            {
                cifri.Checked = true;
                bukvi.Checked = false;
                textIn.Enabled = false;
                zamena.Checked = false;
                revers.Checked = false;
                bukvi_i_cifri.Checked = false;
                gli4.Checked = false;
                totext.Checked = false;
                tobase.Checked = false;
            }
            else if (cifri.Checked != false)
            {
                cifri.Checked = true;
            }
            label2.Text = Translate.size;
            glitchExtent.Maximum = 300;
        }

        private void toBaseMenu_Click(object sender, EventArgs e)
        {
            lightGlitch.Enabled = false;
            glitchExtent.Enabled = false;
            mode = 6;
            textOut.Text = "";
            if (tobase.Checked == true)
            {
                tobase.Checked = true;
                textIn.Enabled = true;
                zamena.Checked = false;
                revers.Checked = false;
                bukvi_i_cifri.Checked = false;
                bukvi.Checked = false;
                totext.Checked = false;
                gli4.Checked = false;
                cifri.Checked = false;
            }
            else if (tobase.Checked == false)
            {
                tobase.Checked = true;
            }
            label2.Text = Translate.glitchExtent;
            glitchExtent.Maximum = 5;
        }

        private void toTextMenu_Click(object sender, EventArgs e)
        {
            lightGlitch.Enabled = false;
            glitchExtent.Enabled = false;
            mode = 7;
            textOut.Text = "";
            if (totext.Checked == true)
            {
                totext.Checked = true;
                textIn.Enabled = true;
                zamena.Checked = false;
                revers.Checked = false;
                bukvi_i_cifri.Checked = false;
                bukvi.Checked = false;
                gli4.Checked = false;
                tobase.Checked = false;
                cifri.Checked = false;
            }
            else if (totext.Checked == false)
            {
                totext.Checked = true;
            }
            label2.Text = Translate.wordSize;
            glitchExtent.Maximum = 300;
        }

        private void lettersAndNumbersMenu_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void onlyLettersMenu_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void keygenMenu_Click(object sender, EventArgs e)
        {
            keygen a = new keygen();
            a.Show();
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                textIn.Text = Clipboard.GetText();
            }
        }

        private void glitchMenu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void onlyLettersMenu_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textIn.Text = "";
            textOut.Text = "";
        }

        private void about_Click(object sender, EventArgs e)
        {

        }
        private void keygenform_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "keygen") return;
            }
            keygen a = new keygen();
            a.Show();
        }


        private void textIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                start_Click(sender, e);
            }
        }

        private void TextOGlitchForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                if (exitMessage)
                {
                    name.Abort();
                    exitFromForm = true;
                    launchTray();
                    e.Cancel = true;
                }
            }
            else
            {
                exitMessage = false;
                try
                {
                    if (name != null) if (name.IsAlive) name.Abort();
                    if (work != null) if (work.IsAlive) work.Abort();
                    Process.GetCurrentProcess().Kill();
                }
                catch { };
            }
        }

        private void tray_MouseClick(object sender, MouseEventArgs e)
        {

        }
        public void launchTray()
        {
            if (exitFromForm)
            {
                tray.Visible = true;
                //tray.BalloonTipTitle = "Text'O'Glitch";
                //tray.BalloonTipText = "Теперь я в трее!";
                //tray.ShowBalloonTip(100);
                tray.ShowBalloonTip(5000, "Text'O'Glitch", Translate.inTray, tray.BalloonTipIcon);
                this.Hide();
            }
            else
            {
                tray.Visible = true;
                this.Hide();
            }
        }


        private void exitTray_Click(object sender, EventArgs e)
        {
            exitMessage = false;
            try
            {
                Application.Exit();
            }
            catch { };
        }

        private void glitchTray_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "trayForm")
                {
                    return;
                }
            }
            modeTray = 0;
            a = new trayForm();
            a.Show();
        }
        private void lightGlitchTray_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "trayForm")
                {
                    return;
                }
            }
            modeTray = 1;
            a = new trayForm();
            a.Show();
        }
        private void replaceTray_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "trayForm")
                {
                    return;
                }
            }
            modeTray = 2;
            a = new trayForm();
            a.Show();
        }

        private void reverseTray_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "trayForm")
                {
                    return;
                }
            }
            modeTray = 3;
            a = new trayForm();
            a.Show();
        }

        private void generateTray_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "trayForm")
                {
                    return;
                }
            }
            modeTray = 4;
            a = new trayForm();
            a.Show();
        }

        private void toBaseTray_Click(object sender, EventArgs e)
        {
            string clipboard = Clipboard.GetText();
            if (clipboard != "")
            {
                clipboard = EasyBase64.Encode(clipboard);
                Clipboard.SetText(clipboard);
                tray.ShowBalloonTip(1000, Translate.convertedToBaseTray, Translate.copiedToClipboard, tray.BalloonTipIcon);
            }
            else
            {
                tray.ShowBalloonTip(1000, "Text'O'Glitch", Translate.clipboardEmpty, tray.BalloonTipIcon);
            }
        }


        private void toTextTray_Click(object sender, EventArgs e)
        {
            string clipboard = Clipboard.GetText();
            if (clipboard != "")
            {
                clipboard = EasyBase64.Decode(clipboard);
                if (clipboard != "It is not Base64.")
                {
                    Clipboard.SetText(clipboard);
                    tray.ShowBalloonTip(1000, Translate.decodedFromBaseTray, Translate.decodedFromBaseTray2 + clipboard + "\"." + Translate.copiedToClipboard, tray.BalloonTipIcon);
                }
                else
                {
                    tray.ShowBalloonTip(1000, Translate.itsNotBase, Translate.itsNotBase2, tray.BalloonTipIcon);
                }
            }
            else
            {
                tray.ShowBalloonTip(1000, "Text'O'Glitch", Translate.clipboardEmpty, tray.BalloonTipIcon);
            }
        }


        private void tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                ifTrayLaunched = false;
                TextOGlitchForm1_Load(sender, e);
                tray.Visible = false;
            }
            else if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip.Show();
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void manyText_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "WorkWithBigText") return;
            }
            ManyText o = new ManyText();
            o.Show();
        }

        private void RandomizerButton_click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Randomizer") return;
            }
            Randomizer o = new Randomizer();
            o.Show();
        }

        private void manyTextTray_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "WorkWithBigText") return;
            }
            ManyText a = new ManyText();
            a.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tray.ShowBalloonTip(1000, "Text'O'Glitch", Translate.trademark, tray.BalloonTipIcon);
            Clipboard.SetText("™");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tray.ShowBalloonTip(1000, "Text'O'Glitch", Translate.copyright, tray.BalloonTipIcon);
            Clipboard.SetText("©");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            tray.ShowBalloonTip(1000, "Text'O'Glitch", Translate.copyleft, tray.BalloonTipIcon);
            Clipboard.SetText("®");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            tray.ShowBalloonTip(1000, "Text'O'Glitch", Translate.mark, tray.BalloonTipIcon);
            Clipboard.SetText("✔");
        }
        private void lennyFace_Click(object sender, EventArgs e)
        {
            tray.ShowBalloonTip(1000, "Text'O'Glitch", Translate.lenface, tray.BalloonTipIcon);
            Clipboard.SetText("( ͡° ͜ʖ ͡°)");
        }
        private void shrug_Click(object sender, EventArgs e)
        {
            tray.ShowBalloonTip(1000, "Text'O'Glitch", Translate.shrug, tray.BalloonTipIcon);
            Clipboard.SetText("¯\\_(ツ)_/¯");
        }

        private void ramClean_Tick(object sender, EventArgs e)
        {
            try
            {
                EmptyWorkingSet(System.Diagnostics.Process.GetCurrentProcess().Handle);
            }
            catch
            {
            }
        }

        private void fileGlitch_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FileGlitcher") return;
            }
            y = new FileGlitcherGUI.FileGlitcher();
            y.Show();
        }

        private void fileGlitcherTray_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FileGlitcher") return;
            }
            y = new FileGlitcherGUI.FileGlitcher();
            y.Show();
        }

        private void randomizeTray_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Randomizer") return;
            }
            Randomizer o = new Randomizer();
            o.Show();
        }

        private void voidSymbol_Click(object sender, EventArgs e)
        {
            tray.ShowBalloonTip(1000, "Text'O'Glitch", Translate.invisible, tray.BalloonTipIcon);
            Clipboard.SetText("͏");
        }

        private void aboutMessage_click(object sender, EventArgs e)
        {
            MessageBox.Show(Translate.about, "About");
        }

        private void english_Click(object sender, EventArgs e)
        {
            if (File.Exists("ru/rus"))
            {
                try
                {
                    File.Delete("ru/rus");
                    exitMessage = false;
                    try
                    {
                        Application.Restart();
                        Process.GetCurrentProcess().Kill();
                    }
                    catch { };
                }
                catch
                {
                    MessageBox.Show("File \"ru/rus\" is busy or not exist! Delete it by yourself or just restart the programm!");
                }
            }
            else
            {
                File.Create("ru/rus");
                exitMessage = false;
                try
                {
                    Application.Restart();
                    Process.GetCurrentProcess().Kill();
                }
                catch { };
            }


        }
    }
    }
