﻿namespace Csharp_SERIAL_KILLER_beta
{
    partial class normalControl
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
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.breathGB = new System.Windows.Forms.RadioButton();
            this.breathRB = new System.Windows.Forms.RadioButton();
            this.breathRG = new System.Windows.Forms.RadioButton();
            this.breathWhite = new System.Windows.Forms.RadioButton();
            this.breathBlue = new System.Windows.Forms.RadioButton();
            this.breathGreen = new System.Windows.Forms.RadioButton();
            this.breathRed = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(125, 331);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 49;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(47, 331);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 48;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // breathGB
            // 
            this.breathGB.AutoSize = true;
            this.breathGB.Location = new System.Drawing.Point(187, 243);
            this.breathGB.Name = "breathGB";
            this.breathGB.Size = new System.Drawing.Size(52, 17);
            this.breathGB.TabIndex = 47;
            this.breathGB.TabStop = true;
            this.breathGB.Text = "G + B";
            this.breathGB.UseVisualStyleBackColor = true;
            // 
            // breathRB
            // 
            this.breathRB.AutoSize = true;
            this.breathRB.Location = new System.Drawing.Point(96, 243);
            this.breathRB.Name = "breathRB";
            this.breathRB.Size = new System.Drawing.Size(52, 17);
            this.breathRB.TabIndex = 46;
            this.breathRB.TabStop = true;
            this.breathRB.Text = "R + B";
            this.breathRB.UseVisualStyleBackColor = true;
            // 
            // breathRG
            // 
            this.breathRG.AutoSize = true;
            this.breathRG.Location = new System.Drawing.Point(12, 243);
            this.breathRG.Name = "breathRG";
            this.breathRG.Size = new System.Drawing.Size(53, 17);
            this.breathRG.TabIndex = 45;
            this.breathRG.TabStop = true;
            this.breathRG.Text = "R + G";
            this.breathRG.UseVisualStyleBackColor = true;
            // 
            // breathWhite
            // 
            this.breathWhite.AutoSize = true;
            this.breathWhite.Location = new System.Drawing.Point(96, 275);
            this.breathWhite.Name = "breathWhite";
            this.breathWhite.Size = new System.Drawing.Size(53, 17);
            this.breathWhite.TabIndex = 44;
            this.breathWhite.TabStop = true;
            this.breathWhite.Text = "White";
            this.breathWhite.UseVisualStyleBackColor = true;
            // 
            // breathBlue
            // 
            this.breathBlue.AutoSize = true;
            this.breathBlue.Location = new System.Drawing.Point(187, 220);
            this.breathBlue.Name = "breathBlue";
            this.breathBlue.Size = new System.Drawing.Size(46, 17);
            this.breathBlue.TabIndex = 43;
            this.breathBlue.TabStop = true;
            this.breathBlue.Text = "Blue";
            this.breathBlue.UseVisualStyleBackColor = true;
            // 
            // breathGreen
            // 
            this.breathGreen.AutoSize = true;
            this.breathGreen.Location = new System.Drawing.Point(96, 220);
            this.breathGreen.Name = "breathGreen";
            this.breathGreen.Size = new System.Drawing.Size(54, 17);
            this.breathGreen.TabIndex = 42;
            this.breathGreen.TabStop = true;
            this.breathGreen.Text = "Green";
            this.breathGreen.UseVisualStyleBackColor = true;
            // 
            // breathRed
            // 
            this.breathRed.AutoSize = true;
            this.breathRed.Location = new System.Drawing.Point(12, 220);
            this.breathRed.Name = "breathRed";
            this.breathRed.Size = new System.Drawing.Size(45, 17);
            this.breathRed.TabIndex = 41;
            this.breathRed.TabStop = true;
            this.breathRed.Text = "Red";
            this.breathRed.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Select the led color";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Very slow",
            "Slow",
            "Normal",
            "Fast",
            "Very fast"});
            this.comboBox1.Location = new System.Drawing.Point(13, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 21);
            this.comboBox1.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Select the speed";
            // 
            // normalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 366);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.breathGB);
            this.Controls.Add(this.breathRB);
            this.Controls.Add(this.breathRG);
            this.Controls.Add(this.breathWhite);
            this.Controls.Add(this.breathBlue);
            this.Controls.Add(this.breathGreen);
            this.Controls.Add(this.breathRed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Name = "normalControl";
            this.Text = "normalControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.RadioButton breathGB;
        public System.Windows.Forms.RadioButton breathRB;
        public System.Windows.Forms.RadioButton breathRG;
        private System.Windows.Forms.RadioButton breathWhite;
        private System.Windows.Forms.RadioButton breathBlue;
        private System.Windows.Forms.RadioButton breathGreen;
        public System.Windows.Forms.RadioButton breathRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}