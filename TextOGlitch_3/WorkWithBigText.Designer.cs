namespace TextOGlitch_3
{
    partial class WorkWithBigText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkWithBigText));
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.glitchMass = new System.Windows.Forms.RadioButton();
            this.replaceMass = new System.Windows.Forms.RadioButton();
            this.reverseMass = new System.Windows.Forms.RadioButton();
            this.startMass = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.copy = new System.Windows.Forms.Button();
            this.paste = new System.Windows.Forms.Button();
            this.lightMass = new System.Windows.Forms.CheckBox();
            this.glitchOneStringCheckBox = new System.Windows.Forms.CheckBox();
            this.glitchOneStringCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glitchOneStringCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            resources.ApplyResources(this.richTextBox2, "richTextBox2");
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            // 
            // glitchMass
            // 
            resources.ApplyResources(this.glitchMass, "glitchMass");
            this.glitchMass.Checked = true;
            this.glitchMass.Name = "glitchMass";
            this.glitchMass.TabStop = true;
            this.glitchMass.UseVisualStyleBackColor = true;
            this.glitchMass.CheckedChanged += new System.EventHandler(this.glitchMass_CheckedChanged);
            this.glitchMass.Click += new System.EventHandler(this.glitchMass_Click);
            // 
            // replaceMass
            // 
            resources.ApplyResources(this.replaceMass, "replaceMass");
            this.replaceMass.Name = "replaceMass";
            this.replaceMass.UseVisualStyleBackColor = true;
            this.replaceMass.CheckedChanged += new System.EventHandler(this.replaceMass_CheckedChanged);
            this.replaceMass.Click += new System.EventHandler(this.replaceMass_Click);
            // 
            // reverseMass
            // 
            resources.ApplyResources(this.reverseMass, "reverseMass");
            this.reverseMass.Name = "reverseMass";
            this.reverseMass.UseVisualStyleBackColor = true;
            this.reverseMass.CheckedChanged += new System.EventHandler(this.reverseMass_CheckedChanged);
            this.reverseMass.Click += new System.EventHandler(this.reverseMass_Click);
            // 
            // startMass
            // 
            resources.ApplyResources(this.startMass, "startMass");
            this.startMass.Name = "startMass";
            this.startMass.UseVisualStyleBackColor = true;
            this.startMass.Click += new System.EventHandler(this.startMass_Click);
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
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
            // copy
            // 
            resources.ApplyResources(this.copy, "copy");
            this.copy.Name = "copy";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // paste
            // 
            resources.ApplyResources(this.paste, "paste");
            this.paste.Name = "paste";
            this.paste.UseVisualStyleBackColor = true;
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // lightMass
            // 
            resources.ApplyResources(this.lightMass, "lightMass");
            this.lightMass.Name = "lightMass";
            this.lightMass.UseVisualStyleBackColor = true;
            // 
            // glitchOneStringCheckBox
            // 
            resources.ApplyResources(this.glitchOneStringCheckBox, "glitchOneStringCheckBox");
            this.glitchOneStringCheckBox.Name = "glitchOneStringCheckBox";
            this.glitchOneStringCheckBox.UseVisualStyleBackColor = true;
            this.glitchOneStringCheckBox.CheckedChanged += new System.EventHandler(this.glitchOneStringCheckBox_CheckedChanged);
            // 
            // glitchOneStringCount
            // 
            resources.ApplyResources(this.glitchOneStringCount, "glitchOneStringCount");
            this.glitchOneStringCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.glitchOneStringCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.glitchOneStringCount.Name = "glitchOneStringCount";
            this.glitchOneStringCount.Value = new decimal(new int[] {
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
            // WorkWithBigText
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.glitchOneStringCount);
            this.Controls.Add(this.glitchOneStringCheckBox);
            this.Controls.Add(this.lightMass);
            this.Controls.Add(this.paste);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.startMass);
            this.Controls.Add(this.reverseMass);
            this.Controls.Add(this.replaceMass);
            this.Controls.Add(this.glitchMass);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WorkWithBigText";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkWithBigText_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glitchOneStringCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RadioButton glitchMass;
        private System.Windows.Forms.RadioButton replaceMass;
        private System.Windows.Forms.RadioButton reverseMass;
        private System.Windows.Forms.Button startMass;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button paste;
        private System.Windows.Forms.CheckBox lightMass;
        private System.Windows.Forms.CheckBox glitchOneStringCheckBox;
        private System.Windows.Forms.NumericUpDown glitchOneStringCount;
        private System.Windows.Forms.Label label2;
    }
}