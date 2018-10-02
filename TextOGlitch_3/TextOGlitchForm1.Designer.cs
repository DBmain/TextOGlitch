namespace TextOGlitch_3
{
    partial class TextOGlitchForm1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextOGlitchForm1));
            this.textIn = new System.Windows.Forms.TextBox();
            this.textOut = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.glitchExtent = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.режимыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glitchMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.generateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lettersAndNumbersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyLettersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toBaseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toTextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.keygenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.rejimi = new System.Windows.Forms.ToolStripMenuItem();
            this.gli4 = new System.Windows.Forms.ToolStripMenuItem();
            this.zamena = new System.Windows.Forms.ToolStripMenuItem();
            this.revers = new System.Windows.Forms.ToolStripMenuItem();
            this.generationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.bukvi_i_cifri = new System.Windows.Forms.ToolStripMenuItem();
            this.bukvi = new System.Windows.Forms.ToolStripMenuItem();
            this.cifri = new System.Windows.Forms.ToolStripMenuItem();
            this.tobase = new System.Windows.Forms.ToolStripMenuItem();
            this.totext = new System.Windows.Forms.ToolStripMenuItem();
            this.manyText = new System.Windows.Forms.ToolStripMenuItem();
            this.fileGlitch = new System.Windows.Forms.ToolStripMenuItem();
            this.RandomizerButton = new System.Windows.Forms.ToolStripMenuItem();
            this.keygenform = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.english = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.workWithTextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.glitchContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.glitchTray = new System.Windows.Forms.ToolStripMenuItem();
            this.lightGlitchTray = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceTray = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseTray = new System.Windows.Forms.ToolStripMenuItem();
            this.generateTray = new System.Windows.Forms.ToolStripMenuItem();
            this.base64Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toBaseTray = new System.Windows.Forms.ToolStripMenuItem();
            this.toTextTray = new System.Windows.Forms.ToolStripMenuItem();
            this.symbolsTray = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.lennyFace = new System.Windows.Forms.ToolStripMenuItem();
            this.shrug = new System.Windows.Forms.ToolStripMenuItem();
            this.voidSymbol = new System.Windows.Forms.ToolStripMenuItem();
            this.gUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manyTextTray = new System.Windows.Forms.ToolStripMenuItem();
            this.fileGlitcherTray = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeTray = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitTray = new System.Windows.Forms.ToolStripMenuItem();
            this.lightGlitch = new System.Windows.Forms.CheckBox();
            this.ramClean = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.glitchExtent)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textIn
            // 
            resources.ApplyResources(this.textIn, "textIn");
            this.textIn.Name = "textIn";
            this.textIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textIn_KeyDown);
            // 
            // textOut
            // 
            resources.ApplyResources(this.textOut, "textOut");
            this.textOut.Name = "textOut";
            this.textOut.ReadOnly = true;
            // 
            // start
            // 
            resources.ApplyResources(this.start, "start");
            this.start.Name = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // copyButton
            // 
            resources.ApplyResources(this.copyButton, "copyButton");
            this.copyButton.Name = "copyButton";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // glitchExtent
            // 
            resources.ApplyResources(this.glitchExtent, "glitchExtent");
            this.glitchExtent.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.glitchExtent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.glitchExtent.Name = "glitchExtent";
            this.glitchExtent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // менюToolStripMenuItem
            // 
            resources.ApplyResources(this.менюToolStripMenuItem, "менюToolStripMenuItem");
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            // 
            // exitMenuStrip
            // 
            resources.ApplyResources(this.exitMenuStrip, "exitMenuStrip");
            this.exitMenuStrip.Name = "exitMenuStrip";
            // 
            // режимыToolStripMenuItem
            // 
            resources.ApplyResources(this.режимыToolStripMenuItem, "режимыToolStripMenuItem");
            this.режимыToolStripMenuItem.Name = "режимыToolStripMenuItem";
            // 
            // glitchMenu
            // 
            resources.ApplyResources(this.glitchMenu, "glitchMenu");
            this.glitchMenu.Name = "glitchMenu";
            // 
            // replaceMenu
            // 
            resources.ApplyResources(this.replaceMenu, "replaceMenu");
            this.replaceMenu.Name = "replaceMenu";
            // 
            // reverseMenu
            // 
            resources.ApplyResources(this.reverseMenu, "reverseMenu");
            this.reverseMenu.Name = "reverseMenu";
            // 
            // generateMenu
            // 
            resources.ApplyResources(this.generateMenu, "generateMenu");
            this.generateMenu.Name = "generateMenu";
            // 
            // lettersAndNumbersMenu
            // 
            resources.ApplyResources(this.lettersAndNumbersMenu, "lettersAndNumbersMenu");
            this.lettersAndNumbersMenu.Name = "lettersAndNumbersMenu";
            // 
            // onlyLettersMenu
            // 
            resources.ApplyResources(this.onlyLettersMenu, "onlyLettersMenu");
            this.onlyLettersMenu.Name = "onlyLettersMenu";
            // 
            // toBaseMenu
            // 
            resources.ApplyResources(this.toBaseMenu, "toBaseMenu");
            this.toBaseMenu.Name = "toBaseMenu";
            // 
            // toTextMenu
            // 
            resources.ApplyResources(this.toTextMenu, "toTextMenu");
            this.toTextMenu.Name = "toTextMenu";
            // 
            // keygenMenu
            // 
            resources.ApplyResources(this.keygenMenu, "keygenMenu");
            this.keygenMenu.Name = "keygenMenu";
            this.keygenMenu.Click += new System.EventHandler(this.keygenMenu_Click);
            // 
            // pasteButton
            // 
            resources.ApplyResources(this.pasteButton, "pasteButton");
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.UseVisualStyleBackColor = true;
            this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aboutMenu
            // 
            resources.ApplyResources(this.aboutMenu, "aboutMenu");
            this.aboutMenu.Name = "aboutMenu";
            // 
            // about
            // 
            resources.ApplyResources(this.about, "about");
            this.about.Name = "about";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // menu
            // 
            resources.ApplyResources(this.menu, "menu");
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit});
            this.menu.Name = "menu";
            // 
            // exit
            // 
            resources.ApplyResources(this.exit, "exit");
            this.exit.Name = "exit";
            this.exit.Click += new System.EventHandler(this.exitMenuStrip_Click);
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.rejimi,
            this.keygenform,
            this.help});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // rejimi
            // 
            resources.ApplyResources(this.rejimi, "rejimi");
            this.rejimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gli4,
            this.zamena,
            this.revers,
            this.generationMenu,
            this.tobase,
            this.totext,
            this.manyText,
            this.fileGlitch,
            this.RandomizerButton});
            this.rejimi.Name = "rejimi";
            // 
            // gli4
            // 
            resources.ApplyResources(this.gli4, "gli4");
            this.gli4.Checked = true;
            this.gli4.CheckOnClick = true;
            this.gli4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gli4.Name = "gli4";
            this.gli4.Click += new System.EventHandler(this.glitchMenu_Click);
            // 
            // zamena
            // 
            resources.ApplyResources(this.zamena, "zamena");
            this.zamena.CheckOnClick = true;
            this.zamena.Name = "zamena";
            this.zamena.Click += new System.EventHandler(this.replaceMenu_Click);
            // 
            // revers
            // 
            resources.ApplyResources(this.revers, "revers");
            this.revers.CheckOnClick = true;
            this.revers.Name = "revers";
            this.revers.Click += new System.EventHandler(this.reverseMenu_Click);
            // 
            // generationMenu
            // 
            resources.ApplyResources(this.generationMenu, "generationMenu");
            this.generationMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bukvi_i_cifri,
            this.bukvi,
            this.cifri});
            this.generationMenu.Name = "generationMenu";
            // 
            // bukvi_i_cifri
            // 
            resources.ApplyResources(this.bukvi_i_cifri, "bukvi_i_cifri");
            this.bukvi_i_cifri.CheckOnClick = true;
            this.bukvi_i_cifri.Name = "bukvi_i_cifri";
            this.bukvi_i_cifri.Click += new System.EventHandler(this.lettersAndNumbersMenu_Click);
            // 
            // bukvi
            // 
            resources.ApplyResources(this.bukvi, "bukvi");
            this.bukvi.CheckOnClick = true;
            this.bukvi.Name = "bukvi";
            this.bukvi.Click += new System.EventHandler(this.onlyLettersMenu_Click);
            // 
            // cifri
            // 
            resources.ApplyResources(this.cifri, "cifri");
            this.cifri.Name = "cifri";
            this.cifri.Click += new System.EventHandler(this.cifri_Click);
            // 
            // tobase
            // 
            resources.ApplyResources(this.tobase, "tobase");
            this.tobase.CheckOnClick = true;
            this.tobase.Name = "tobase";
            this.tobase.Click += new System.EventHandler(this.toBaseMenu_Click);
            // 
            // totext
            // 
            resources.ApplyResources(this.totext, "totext");
            this.totext.CheckOnClick = true;
            this.totext.Name = "totext";
            this.totext.Click += new System.EventHandler(this.toTextMenu_Click);
            // 
            // manyText
            // 
            resources.ApplyResources(this.manyText, "manyText");
            this.manyText.Name = "manyText";
            this.manyText.Click += new System.EventHandler(this.manyText_Click);
            // 
            // fileGlitch
            // 
            resources.ApplyResources(this.fileGlitch, "fileGlitch");
            this.fileGlitch.Name = "fileGlitch";
            this.fileGlitch.Click += new System.EventHandler(this.fileGlitch_Click);
            // 
            // RandomizerButton
            // 
            resources.ApplyResources(this.RandomizerButton, "RandomizerButton");
            this.RandomizerButton.Name = "RandomizerButton";
            this.RandomizerButton.Click += new System.EventHandler(this.RandomizerButton_click);
            // 
            // keygenform
            // 
            resources.ApplyResources(this.keygenform, "keygenform");
            this.keygenform.Name = "keygenform";
            this.keygenform.Click += new System.EventHandler(this.keygenform_Click);
            // 
            // help
            // 
            resources.ApplyResources(this.help, "help");
            this.help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMessage,
            this.english});
            this.help.Name = "help";
            // 
            // aboutMessage
            // 
            resources.ApplyResources(this.aboutMessage, "aboutMessage");
            this.aboutMessage.Name = "aboutMessage";
            this.aboutMessage.Click += new System.EventHandler(this.aboutMessage_click);
            // 
            // english
            // 
            resources.ApplyResources(this.english, "english");
            this.english.Name = "english";
            this.english.Click += new System.EventHandler(this.english_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // tray
            // 
            resources.ApplyResources(this.tray, "tray");
            this.tray.ContextMenuStrip = this.contextMenuStrip;
            this.tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tray_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            resources.ApplyResources(this.contextMenuStrip, "contextMenuStrip");
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workWithTextMenu,
            this.base64Menu,
            this.symbolsTray,
            this.gUIToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitTray});
            this.contextMenuStrip.Name = "contextMenuStrip";
            // 
            // workWithTextMenu
            // 
            resources.ApplyResources(this.workWithTextMenu, "workWithTextMenu");
            this.workWithTextMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.glitchContextMenu,
            this.replaceTray,
            this.reverseTray,
            this.generateTray});
            this.workWithTextMenu.Name = "workWithTextMenu";
            // 
            // glitchContextMenu
            // 
            resources.ApplyResources(this.glitchContextMenu, "glitchContextMenu");
            this.glitchContextMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.glitchTray,
            this.lightGlitchTray});
            this.glitchContextMenu.Name = "glitchContextMenu";
            // 
            // glitchTray
            // 
            resources.ApplyResources(this.glitchTray, "glitchTray");
            this.glitchTray.Name = "glitchTray";
            this.glitchTray.Click += new System.EventHandler(this.glitchTray_Click);
            // 
            // lightGlitchTray
            // 
            resources.ApplyResources(this.lightGlitchTray, "lightGlitchTray");
            this.lightGlitchTray.Name = "lightGlitchTray";
            this.lightGlitchTray.Click += new System.EventHandler(this.lightGlitchTray_Click);
            // 
            // replaceTray
            // 
            resources.ApplyResources(this.replaceTray, "replaceTray");
            this.replaceTray.Name = "replaceTray";
            this.replaceTray.Click += new System.EventHandler(this.replaceTray_Click);
            // 
            // reverseTray
            // 
            resources.ApplyResources(this.reverseTray, "reverseTray");
            this.reverseTray.Name = "reverseTray";
            this.reverseTray.Click += new System.EventHandler(this.reverseTray_Click);
            // 
            // generateTray
            // 
            resources.ApplyResources(this.generateTray, "generateTray");
            this.generateTray.Name = "generateTray";
            this.generateTray.Click += new System.EventHandler(this.generateTray_Click);
            // 
            // base64Menu
            // 
            resources.ApplyResources(this.base64Menu, "base64Menu");
            this.base64Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toBaseTray,
            this.toTextTray});
            this.base64Menu.Name = "base64Menu";
            // 
            // toBaseTray
            // 
            resources.ApplyResources(this.toBaseTray, "toBaseTray");
            this.toBaseTray.Name = "toBaseTray";
            this.toBaseTray.Click += new System.EventHandler(this.toBaseTray_Click);
            // 
            // toTextTray
            // 
            resources.ApplyResources(this.toTextTray, "toTextTray");
            this.toTextTray.Name = "toTextTray";
            this.toTextTray.Click += new System.EventHandler(this.toTextTray_Click);
            // 
            // symbolsTray
            // 
            resources.ApplyResources(this.symbolsTray, "symbolsTray");
            this.symbolsTray.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.lennyFace,
            this.shrug,
            this.voidSymbol});
            this.symbolsTray.Name = "symbolsTray";
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // lennyFace
            // 
            resources.ApplyResources(this.lennyFace, "lennyFace");
            this.lennyFace.Name = "lennyFace";
            this.lennyFace.Click += new System.EventHandler(this.lennyFace_Click);
            // 
            // shrug
            // 
            resources.ApplyResources(this.shrug, "shrug");
            this.shrug.Name = "shrug";
            this.shrug.Click += new System.EventHandler(this.shrug_Click);
            // 
            // voidSymbol
            // 
            resources.ApplyResources(this.voidSymbol, "voidSymbol");
            this.voidSymbol.Name = "voidSymbol";
            this.voidSymbol.Click += new System.EventHandler(this.voidSymbol_Click);
            // 
            // gUIToolStripMenuItem
            // 
            resources.ApplyResources(this.gUIToolStripMenuItem, "gUIToolStripMenuItem");
            this.gUIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manyTextTray,
            this.fileGlitcherTray,
            this.randomizeTray});
            this.gUIToolStripMenuItem.Name = "gUIToolStripMenuItem";
            // 
            // manyTextTray
            // 
            resources.ApplyResources(this.manyTextTray, "manyTextTray");
            this.manyTextTray.Name = "manyTextTray";
            this.manyTextTray.Click += new System.EventHandler(this.manyTextTray_Click);
            // 
            // fileGlitcherTray
            // 
            resources.ApplyResources(this.fileGlitcherTray, "fileGlitcherTray");
            this.fileGlitcherTray.Name = "fileGlitcherTray";
            this.fileGlitcherTray.Click += new System.EventHandler(this.fileGlitcherTray_Click);
            // 
            // randomizeTray
            // 
            resources.ApplyResources(this.randomizeTray, "randomizeTray");
            this.randomizeTray.Name = "randomizeTray";
            this.randomizeTray.Click += new System.EventHandler(this.randomizeTray_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // exitTray
            // 
            resources.ApplyResources(this.exitTray, "exitTray");
            this.exitTray.Name = "exitTray";
            this.exitTray.Click += new System.EventHandler(this.exitTray_Click);
            // 
            // lightGlitch
            // 
            resources.ApplyResources(this.lightGlitch, "lightGlitch");
            this.lightGlitch.Name = "lightGlitch";
            this.lightGlitch.UseVisualStyleBackColor = true;
            // 
            // ramClean
            // 
            this.ramClean.Interval = 60000;
            this.ramClean.Tick += new System.EventHandler(this.ramClean_Tick);
            // 
            // TextOGlitchForm1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lightGlitch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.glitchExtent);
            this.Controls.Add(this.pasteButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.start);
            this.Controls.Add(this.textOut);
            this.Controls.Add(this.textIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "TextOGlitchForm1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextOGlitchForm1_FormClosing);
            this.Load += new System.EventHandler(this.TextOGlitchForm1_Load);
            this.Shown += new System.EventHandler(this.TextOGlitchForm1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.glitchExtent)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textIn;
        private System.Windows.Forms.TextBox textOut;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.NumericUpDown glitchExtent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem режимыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glitchMenu;
        private System.Windows.Forms.ToolStripMenuItem replaceMenu;
        private System.Windows.Forms.ToolStripMenuItem keygenMenu;
        private System.Windows.Forms.ToolStripMenuItem reverseMenu;
        private System.Windows.Forms.ToolStripMenuItem generateMenu;
        private System.Windows.Forms.ToolStripMenuItem lettersAndNumbersMenu;
        private System.Windows.Forms.ToolStripMenuItem onlyLettersMenu;
        private System.Windows.Forms.ToolStripMenuItem toBaseMenu;
        private System.Windows.Forms.ToolStripMenuItem toTextMenu;
        private System.Windows.Forms.Button pasteButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem rejimi;
        private System.Windows.Forms.ToolStripMenuItem gli4;
        private System.Windows.Forms.ToolStripMenuItem zamena;
        private System.Windows.Forms.ToolStripMenuItem revers;
        private System.Windows.Forms.ToolStripMenuItem generationMenu;
        private System.Windows.Forms.ToolStripMenuItem bukvi_i_cifri;
        private System.Windows.Forms.ToolStripMenuItem bukvi;
        private System.Windows.Forms.ToolStripMenuItem tobase;
        private System.Windows.Forms.ToolStripMenuItem totext;
        private System.Windows.Forms.ToolStripMenuItem keygenform;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitTray;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem manyText;
        private System.Windows.Forms.CheckBox lightGlitch;
        private System.Windows.Forms.ToolStripMenuItem symbolsTray;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Timer ramClean;
        private System.Windows.Forms.ToolStripMenuItem fileGlitch;
        private System.Windows.Forms.ToolStripMenuItem lennyFace;
        private System.Windows.Forms.ToolStripMenuItem cifri;
        private System.Windows.Forms.ToolStripMenuItem RandomizerButton;
        private System.Windows.Forms.ToolStripMenuItem workWithTextMenu;
        private System.Windows.Forms.ToolStripMenuItem glitchContextMenu;
        private System.Windows.Forms.ToolStripMenuItem glitchTray;
        private System.Windows.Forms.ToolStripMenuItem lightGlitchTray;
        private System.Windows.Forms.ToolStripMenuItem replaceTray;
        private System.Windows.Forms.ToolStripMenuItem reverseTray;
        private System.Windows.Forms.ToolStripMenuItem generateTray;
        private System.Windows.Forms.ToolStripMenuItem base64Menu;
        private System.Windows.Forms.ToolStripMenuItem toBaseTray;
        private System.Windows.Forms.ToolStripMenuItem toTextTray;
        private System.Windows.Forms.ToolStripMenuItem gUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manyTextTray;
        private System.Windows.Forms.ToolStripMenuItem fileGlitcherTray;
        private System.Windows.Forms.ToolStripMenuItem randomizeTray;
        private System.Windows.Forms.ToolStripMenuItem shrug;
        private System.Windows.Forms.ToolStripMenuItem voidSymbol;
        private System.Windows.Forms.ToolStripMenuItem aboutMessage;
        private System.Windows.Forms.ToolStripMenuItem english;
    }
}

