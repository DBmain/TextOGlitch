namespace FileGlitcher
{
    partial class FileGlitcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileGlitcher));
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outputPath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.sourcePath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.fileLenght = new System.Windows.Forms.Label();
            this.blockGlitching = new System.Windows.Forms.CheckBox();
            this.oneBlockButton = new System.Windows.Forms.RadioButton();
            this.randomBlockButton = new System.Windows.Forms.RadioButton();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.infoButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 24;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(286, 100);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(116, 20);
            this.numericUpDown4.TabIndex = 23;
            this.numericUpDown4.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(330, 49);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown3.TabIndex = 22;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Пропорции ломания (1 - полностью, 100 - 1/100 etc)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Начальная позиция (в байтах)";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(182, 75);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(99, 20);
            this.numericUpDown2.TabIndex = 19;
            this.numericUpDown2.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Режим";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Кол-во выходных файлов";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(156, 49);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Выходной путь";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(605, 165);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 13;
            this.start.Text = "Начать";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Исходный путь";
            // 
            // outputPath
            // 
            this.outputPath.Location = new System.Drawing.Point(105, 138);
            this.outputPath.Name = "outputPath";
            this.outputPath.ReadOnly = true;
            this.outputPath.Size = new System.Drawing.Size(497, 20);
            this.outputPath.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Открыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(605, 7);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 11;
            this.openFile.Text = "Открыть";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // sourcePath
            // 
            this.sourcePath.AllowDrop = true;
            this.sourcePath.Location = new System.Drawing.Point(105, 9);
            this.sourcePath.Name = "sourcePath";
            this.sourcePath.ReadOnly = true;
            this.sourcePath.Size = new System.Drawing.Size(494, 20);
            this.sourcePath.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Все файлы|*.*";
            this.openFileDialog1.Title = "Открыть файл...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(156, 164);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(446, 24);
            this.progressBar1.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 26;
            // 
            // fileLenght
            // 
            this.fileLenght.AutoSize = true;
            this.fileLenght.Location = new System.Drawing.Point(287, 78);
            this.fileLenght.Name = "fileLenght";
            this.fileLenght.Size = new System.Drawing.Size(0, 13);
            this.fileLenght.TabIndex = 27;
            // 
            // blockGlitching
            // 
            this.blockGlitching.AutoSize = true;
            this.blockGlitching.Enabled = false;
            this.blockGlitching.Location = new System.Drawing.Point(386, 50);
            this.blockGlitching.Name = "blockGlitching";
            this.blockGlitching.Size = new System.Drawing.Size(121, 17);
            this.blockGlitching.TabIndex = 28;
            this.blockGlitching.Text = "Глитчить поблочно";
            this.blockGlitching.UseVisualStyleBackColor = true;
            this.blockGlitching.CheckedChanged += new System.EventHandler(this.blockGlitching_CheckedChanged);
            // 
            // oneBlockButton
            // 
            this.oneBlockButton.AutoSize = true;
            this.oneBlockButton.Location = new System.Drawing.Point(516, 49);
            this.oneBlockButton.Name = "oneBlockButton";
            this.oneBlockButton.Size = new System.Drawing.Size(78, 17);
            this.oneBlockButton.TabIndex = 29;
            this.oneBlockButton.TabStop = true;
            this.oneBlockButton.Text = "Один блок";
            this.oneBlockButton.UseVisualStyleBackColor = true;
            this.oneBlockButton.Visible = false;
            this.oneBlockButton.CheckedChanged += new System.EventHandler(this.oneBlockButton_CheckedChanged);
            // 
            // randomBlockButton
            // 
            this.randomBlockButton.AutoSize = true;
            this.randomBlockButton.Location = new System.Drawing.Point(516, 75);
            this.randomBlockButton.Name = "randomBlockButton";
            this.randomBlockButton.Size = new System.Drawing.Size(89, 17);
            this.randomBlockButton.TabIndex = 29;
            this.randomBlockButton.TabStop = true;
            this.randomBlockButton.Text = "В диапазоне";
            this.randomBlockButton.UseVisualStyleBackColor = true;
            this.randomBlockButton.Visible = false;
            this.randomBlockButton.CheckedChanged += new System.EventHandler(this.randomBlockButton_CheckedChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Enabled = false;
            this.numericUpDown5.Location = new System.Drawing.Point(605, 49);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            262144000,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown5.TabIndex = 30;
            this.numericUpDown5.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown5.Visible = false;
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Enabled = false;
            this.numericUpDown7.Location = new System.Drawing.Point(605, 96);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            262144000,
            0,
            0,
            0});
            this.numericUpDown7.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown7.TabIndex = 31;
            this.numericUpDown7.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown7.Visible = false;
            this.numericUpDown7.ValueChanged += new System.EventHandler(this.numericUpDown7_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(592, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "-";
            this.label9.Visible = false;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Enabled = false;
            this.numericUpDown6.Location = new System.Drawing.Point(516, 96);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            262144000,
            0,
            0,
            0});
            this.numericUpDown6.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(73, 20);
            this.numericUpDown6.TabIndex = 31;
            this.numericUpDown6.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown6.Visible = false;
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(18, 28);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(14, 20);
            this.infoButton.TabIndex = 33;
            this.infoButton.Text = "?";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(513, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Сохраняем файл...";
            this.label10.Visible = false;
            // 
            // FileGlitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 194);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDown7);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.randomBlockButton);
            this.Controls.Add(this.oneBlockButton);
            this.Controls.Add(this.blockGlitching);
            this.Controls.Add(this.fileLenght);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputPath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.sourcePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileGlitcher";
            this.Text = "Файлоломатель";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileGlitcher_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FileGlitcher_FormClosed);
            this.Load += new System.EventHandler(this.FileGlitcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.TextBox sourcePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label fileLenght;
        private System.Windows.Forms.CheckBox blockGlitching;
        private System.Windows.Forms.RadioButton oneBlockButton;
        private System.Windows.Forms.RadioButton randomBlockButton;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label label10;
    }
}