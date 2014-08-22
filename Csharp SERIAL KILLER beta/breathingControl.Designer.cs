namespace Csharp_SERIAL_KILLER_beta
{
    partial class breathingControl
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.breathGB = new System.Windows.Forms.RadioButton();
            this.breathRB = new System.Windows.Forms.RadioButton();
            this.breathRG = new System.Windows.Forms.RadioButton();
            this.breathWhite = new System.Windows.Forms.RadioButton();
            this.breathBlue = new System.Windows.Forms.RadioButton();
            this.breathGreen = new System.Windows.Forms.RadioButton();
            this.breathRed = new System.Windows.Forms.RadioButton();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerPWM = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the led color";
            // 
            // breathGB
            // 
            this.breathGB.AutoSize = true;
            this.breathGB.Location = new System.Drawing.Point(187, 243);
            this.breathGB.Name = "breathGB";
            this.breathGB.Size = new System.Drawing.Size(52, 17);
            this.breathGB.TabIndex = 26;
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
            this.breathRB.TabIndex = 25;
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
            this.breathRG.TabIndex = 24;
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
            this.breathWhite.TabIndex = 23;
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
            this.breathBlue.TabIndex = 22;
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
            this.breathGreen.TabIndex = 21;
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
            this.breathRed.TabIndex = 20;
            this.breathRed.TabStop = true;
            this.breathRed.Text = "Red";
            this.breathRed.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(125, 331);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 28;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.breathingModeStop);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(47, 331);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 27;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.breathingModeStart);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "label3";
            // 
            // timerPWM
            // 
            this.timerPWM.Enabled = true;
            this.timerPWM.Tick += new System.EventHandler(this.timerPWM_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Select the speed";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Slow",
            "Normal",
            "Fast"});
            this.comboBox1.Location = new System.Drawing.Point(13, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 21);
            this.comboBox1.TabIndex = 39;
            //this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "label5";
            // 
            // breathingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 366);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
            this.Name = "breathingControl";
            this.Text = "breathingControl";
            this.Load += new System.EventHandler(this.breathingControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton breathGB;
        public System.Windows.Forms.RadioButton breathRB;
        public System.Windows.Forms.RadioButton breathRG;
        private System.Windows.Forms.RadioButton breathWhite;
        private System.Windows.Forms.RadioButton breathBlue;
        private System.Windows.Forms.RadioButton breathGreen;
        public System.Windows.Forms.RadioButton breathRed;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerPWM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}