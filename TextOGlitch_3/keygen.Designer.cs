namespace TextOGlitch_3
{
    partial class keygen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(keygen));
            this.massKeyOut = new System.Windows.Forms.RichTextBox();
            this.massgenlabel = new System.Windows.Forms.Label();
            this.keyOneOut = new System.Windows.Forms.TextBox();
            this.generateOneKey = new System.Windows.Forms.Button();
            this.copyOne = new System.Windows.Forms.Button();
            this.symbols = new System.Windows.Forms.NumericUpDown();
            this.blocks = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.startMassGen = new System.Windows.Forms.Button();
            this.generationProcess = new System.Windows.Forms.Label();
            this.saving = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.symbols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // massKeyOut
            // 
            this.massKeyOut.Location = new System.Drawing.Point(12, 29);
            this.massKeyOut.Name = "massKeyOut";
            this.massKeyOut.ReadOnly = true;
            this.massKeyOut.Size = new System.Drawing.Size(722, 365);
            this.massKeyOut.TabIndex = 0;
            this.massKeyOut.Text = "";
            // 
            // massgenlabel
            // 
            this.massgenlabel.AutoSize = true;
            this.massgenlabel.Location = new System.Drawing.Point(620, 401);
            this.massgenlabel.Name = "massgenlabel";
            this.massgenlabel.Size = new System.Drawing.Size(114, 13);
            this.massgenlabel.TabIndex = 1;
            this.massgenlabel.Text = "Массовая генерация";
            // 
            // keyOneOut
            // 
            this.keyOneOut.Location = new System.Drawing.Point(12, 401);
            this.keyOneOut.Name = "keyOneOut";
            this.keyOneOut.ReadOnly = true;
            this.keyOneOut.Size = new System.Drawing.Size(210, 20);
            this.keyOneOut.TabIndex = 2;
            this.keyOneOut.Text = "Одиночный ключ";
            // 
            // generateOneKey
            // 
            this.generateOneKey.Location = new System.Drawing.Point(12, 427);
            this.generateOneKey.Name = "generateOneKey";
            this.generateOneKey.Size = new System.Drawing.Size(95, 23);
            this.generateOneKey.TabIndex = 3;
            this.generateOneKey.Text = "Сгенерировать";
            this.generateOneKey.UseVisualStyleBackColor = true;
            this.generateOneKey.Click += new System.EventHandler(this.generateOneKey_Click);
            // 
            // copyOne
            // 
            this.copyOne.Location = new System.Drawing.Point(140, 427);
            this.copyOne.Name = "copyOne";
            this.copyOne.Size = new System.Drawing.Size(82, 23);
            this.copyOne.TabIndex = 4;
            this.copyOne.Text = "Скопировать";
            this.copyOne.UseVisualStyleBackColor = true;
            this.copyOne.Click += new System.EventHandler(this.copyOne_Click);
            // 
            // symbols
            // 
            this.symbols.Location = new System.Drawing.Point(322, 408);
            this.symbols.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.symbols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.symbols.Name = "symbols";
            this.symbols.Size = new System.Drawing.Size(32, 20);
            this.symbols.TabIndex = 5;
            this.symbols.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // blocks
            // 
            this.blocks.Location = new System.Drawing.Point(405, 408);
            this.blocks.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.blocks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.blocks.Name = "blocks";
            this.blocks.Size = new System.Drawing.Size(32, 20);
            this.blocks.TabIndex = 5;
            this.blocks.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Символов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Блоков";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(529, 408);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Количество";
            // 
            // startMassGen
            // 
            this.startMassGen.Location = new System.Drawing.Point(623, 426);
            this.startMassGen.Name = "startMassGen";
            this.startMassGen.Size = new System.Drawing.Size(111, 23);
            this.startMassGen.TabIndex = 10;
            this.startMassGen.Text = "Начать!";
            this.startMassGen.UseVisualStyleBackColor = true;
            this.startMassGen.Click += new System.EventHandler(this.startMassGen_Click);
            // 
            // generationProcess
            // 
            this.generationProcess.AutoSize = true;
            this.generationProcess.Location = new System.Drawing.Point(12, 10);
            this.generationProcess.Name = "generationProcess";
            this.generationProcess.Size = new System.Drawing.Size(0, 13);
            this.generationProcess.TabIndex = 11;
            // 
            // saving
            // 
            this.saving.Enabled = false;
            this.saving.Location = new System.Drawing.Point(659, 5);
            this.saving.Name = "saving";
            this.saving.Size = new System.Drawing.Size(75, 23);
            this.saving.TabIndex = 12;
            this.saving.Text = "Сохранить";
            this.saving.UseVisualStyleBackColor = true;
            this.saving.Click += new System.EventHandler(this.saving_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Текстовый файл|*.txt|Все файлы|*.*";
            this.saveFileDialog1.Title = "Сохранить ключи...";
            // 
            // keygen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 455);
            this.Controls.Add(this.saving);
            this.Controls.Add(this.generationProcess);
            this.Controls.Add(this.startMassGen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blocks);
            this.Controls.Add(this.symbols);
            this.Controls.Add(this.copyOne);
            this.Controls.Add(this.generateOneKey);
            this.Controls.Add(this.keyOneOut);
            this.Controls.Add(this.massgenlabel);
            this.Controls.Add(this.massKeyOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "keygen";
            this.Text = "Генерация ключей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.keygen_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.keygen_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.symbols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox massKeyOut;
        private System.Windows.Forms.Label massgenlabel;
        private System.Windows.Forms.TextBox keyOneOut;
        private System.Windows.Forms.Button generateOneKey;
        private System.Windows.Forms.Button copyOne;
        private System.Windows.Forms.NumericUpDown symbols;
        private System.Windows.Forms.NumericUpDown blocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startMassGen;
        private System.Windows.Forms.Label generationProcess;
        private System.Windows.Forms.Button saving;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}