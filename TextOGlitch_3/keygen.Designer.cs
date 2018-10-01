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
            resources.ApplyResources(this.massKeyOut, "massKeyOut");
            this.massKeyOut.Name = "massKeyOut";
            this.massKeyOut.ReadOnly = true;
            // 
            // massgenlabel
            // 
            resources.ApplyResources(this.massgenlabel, "massgenlabel");
            this.massgenlabel.Name = "massgenlabel";
            // 
            // keyOneOut
            // 
            resources.ApplyResources(this.keyOneOut, "keyOneOut");
            this.keyOneOut.Name = "keyOneOut";
            this.keyOneOut.ReadOnly = true;
            // 
            // generateOneKey
            // 
            resources.ApplyResources(this.generateOneKey, "generateOneKey");
            this.generateOneKey.Name = "generateOneKey";
            this.generateOneKey.UseVisualStyleBackColor = true;
            this.generateOneKey.Click += new System.EventHandler(this.generateOneKey_Click);
            // 
            // copyOne
            // 
            resources.ApplyResources(this.copyOne, "copyOne");
            this.copyOne.Name = "copyOne";
            this.copyOne.UseVisualStyleBackColor = true;
            this.copyOne.Click += new System.EventHandler(this.copyOne_Click);
            // 
            // symbols
            // 
            resources.ApplyResources(this.symbols, "symbols");
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
            this.symbols.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // blocks
            // 
            resources.ApplyResources(this.blocks, "blocks");
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
            this.blocks.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // startMassGen
            // 
            resources.ApplyResources(this.startMassGen, "startMassGen");
            this.startMassGen.Name = "startMassGen";
            this.startMassGen.UseVisualStyleBackColor = true;
            this.startMassGen.Click += new System.EventHandler(this.startMassGen_Click);
            // 
            // generationProcess
            // 
            resources.ApplyResources(this.generationProcess, "generationProcess");
            this.generationProcess.Name = "generationProcess";
            // 
            // saving
            // 
            resources.ApplyResources(this.saving, "saving");
            this.saving.Name = "saving";
            this.saving.UseVisualStyleBackColor = true;
            this.saving.Click += new System.EventHandler(this.saving_Click);
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // keygen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.MaximizeBox = false;
            this.Name = "keygen";
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