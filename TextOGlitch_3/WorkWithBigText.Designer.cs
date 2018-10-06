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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label1.Location = new System.Drawing.Point(9, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(742, 230);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 259);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(742, 230);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // glitchMass
            // 
            this.glitchMass.AutoSize = true;
            this.glitchMass.Checked = true;
            this.glitchMass.Location = new System.Drawing.Point(150, 495);
            this.glitchMass.Name = "glitchMass";
            this.glitchMass.Size = new System.Drawing.Size(53, 17);
            this.glitchMass.TabIndex = 5;
            this.glitchMass.TabStop = true;
            this.glitchMass.Text = "Глитч";
            this.glitchMass.UseVisualStyleBackColor = true;
            this.glitchMass.CheckedChanged += new System.EventHandler(this.glitchMass_CheckedChanged);
            this.glitchMass.Click += new System.EventHandler(this.glitchMass_Click);
            // 
            // replaceMass
            // 
            this.replaceMass.AutoSize = true;
            this.replaceMass.Location = new System.Drawing.Point(12, 495);
            this.replaceMass.Name = "replaceMass";
            this.replaceMass.Size = new System.Drawing.Size(64, 17);
            this.replaceMass.TabIndex = 5;
            this.replaceMass.Text = "Замена";
            this.replaceMass.UseVisualStyleBackColor = true;
            this.replaceMass.CheckedChanged += new System.EventHandler(this.replaceMass_CheckedChanged);
            this.replaceMass.Click += new System.EventHandler(this.replaceMass_Click);
            // 
            // reverseMass
            // 
            this.reverseMass.AutoSize = true;
            this.reverseMass.Location = new System.Drawing.Point(82, 495);
            this.reverseMass.Name = "reverseMass";
            this.reverseMass.Size = new System.Drawing.Size(62, 17);
            this.reverseMass.TabIndex = 5;
            this.reverseMass.Text = "Реверс";
            this.reverseMass.UseVisualStyleBackColor = true;
            this.reverseMass.CheckedChanged += new System.EventHandler(this.reverseMass_CheckedChanged);
            this.reverseMass.Click += new System.EventHandler(this.reverseMass_Click);
            // 
            // startMass
            // 
            this.startMass.Location = new System.Drawing.Point(679, 491);
            this.startMass.Name = "startMass";
            this.startMass.Size = new System.Drawing.Size(75, 23);
            this.startMass.TabIndex = 6;
            this.startMass.Text = "Начать";
            this.startMass.UseVisualStyleBackColor = true;
            this.startMass.Click += new System.EventHandler(this.startMass_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(209, 494);
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
            this.numericUpDown1.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // copy
            // 
            this.copy.Location = new System.Drawing.Point(517, 492);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(75, 23);
            this.copy.TabIndex = 8;
            this.copy.Text = "Копировать";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // paste
            // 
            this.paste.Location = new System.Drawing.Point(598, 492);
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(75, 23);
            this.paste.TabIndex = 8;
            this.paste.Text = "Вставить";
            this.paste.UseVisualStyleBackColor = true;
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // lightMass
            // 
            this.lightMass.Appearance = System.Windows.Forms.Appearance.Button;
            this.lightMass.AutoSize = true;
            this.lightMass.Location = new System.Drawing.Point(272, 492);
            this.lightMass.Name = "lightMass";
            this.lightMass.Size = new System.Drawing.Size(40, 23);
            this.lightMass.TabIndex = 9;
            this.lightMass.Text = "Light";
            this.lightMass.UseVisualStyleBackColor = true;
            // 
            // glitchOneStringCheckBox
            // 
            this.glitchOneStringCheckBox.AutoSize = true;
            this.glitchOneStringCheckBox.Location = new System.Drawing.Point(316, 496);
            this.glitchOneStringCheckBox.Name = "glitchOneStringCheckBox";
            this.glitchOneStringCheckBox.Size = new System.Drawing.Size(102, 17);
            this.glitchOneStringCheckBox.TabIndex = 10;
            this.glitchOneStringCheckBox.Text = "Одной строкой";
            this.glitchOneStringCheckBox.UseVisualStyleBackColor = true;
            this.glitchOneStringCheckBox.CheckedChanged += new System.EventHandler(this.glitchOneStringCheckBox_CheckedChanged);
            // 
            // glitchOneStringCount
            // 
            this.glitchOneStringCount.Location = new System.Drawing.Point(467, 494);
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
            this.glitchOneStringCount.Size = new System.Drawing.Size(40, 20);
            this.glitchOneStringCount.TabIndex = 12;
            this.glitchOneStringCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.glitchOneStringCount.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Кол-во";
            this.label2.Visible = false;
            // 
            // WorkWithBigText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 521);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WorkWithBigText";
            this.Text = "Многотекстовик";
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