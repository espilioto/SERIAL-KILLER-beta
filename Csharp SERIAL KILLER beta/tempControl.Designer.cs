namespace Csharp_SERIAL_KILLER_beta
{
    partial class tempControl
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
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tempTimer = new System.Windows.Forms.Timer(this.components);
            this.deviceBox = new System.Windows.Forms.ComboBox();
            this.txtLower = new System.Windows.Forms.NumericUpDown();
            this.txtUpper = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lowerColorBox = new System.Windows.Forms.PictureBox();
            this.upperColorBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperColorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(125, 331);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 38;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.tempModeStop);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(47, 331);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 37;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.tempModeStart);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Select the led color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Select the device";
            // 
            // tempTimer
            // 
            this.tempTimer.Tick += new System.EventHandler(this.tempTimer_Tick);
            // 
            // deviceBox
            // 
            this.deviceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceBox.FormattingEnabled = true;
            this.deviceBox.Location = new System.Drawing.Point(12, 34);
            this.deviceBox.Name = "deviceBox";
            this.deviceBox.Size = new System.Drawing.Size(223, 21);
            this.deviceBox.TabIndex = 46;
            // 
            // txtLower
            // 
            this.txtLower.Location = new System.Drawing.Point(15, 137);
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(47, 20);
            this.txtLower.TabIndex = 49;
            // 
            // txtUpper
            // 
            this.txtUpper.Location = new System.Drawing.Point(183, 137);
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Size = new System.Drawing.Size(47, 20);
            this.txtUpper.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 29);
            this.label3.TabIndex = 51;
            this.label3.Text = "lower threshold";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(182, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 29);
            this.label5.TabIndex = 52;
            this.label5.Text = "upper threshold";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(100, 137);
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            this.txtValue.Size = new System.Drawing.Size(47, 20);
            this.txtValue.TabIndex = 53;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(98, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 29);
            this.label6.TabIndex = 54;
            this.label6.Text = "current value";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lowerColorBox
            // 
            this.lowerColorBox.BackColor = System.Drawing.Color.Blue;
            this.lowerColorBox.Location = new System.Drawing.Point(13, 237);
            this.lowerColorBox.Name = "lowerColorBox";
            this.lowerColorBox.Size = new System.Drawing.Size(74, 56);
            this.lowerColorBox.TabIndex = 55;
            this.lowerColorBox.TabStop = false;
            this.lowerColorBox.Click += new System.EventHandler(this.lowerColorBox_Click);
            // 
            // upperColorBox
            // 
            this.upperColorBox.BackColor = System.Drawing.Color.Red;
            this.upperColorBox.Location = new System.Drawing.Point(156, 237);
            this.upperColorBox.Name = "upperColorBox";
            this.upperColorBox.Size = new System.Drawing.Size(74, 56);
            this.upperColorBox.TabIndex = 56;
            this.upperColorBox.TabStop = false;
            this.upperColorBox.Click += new System.EventHandler(this.upperColorBox_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 57;
            this.label2.Text = "lower color";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(156, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 23);
            this.label7.TabIndex = 58;
            this.label7.Text = "upper color";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tempControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 366);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.upperColorBox);
            this.Controls.Add(this.lowerColorBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUpper);
            this.Controls.Add(this.txtLower);
            this.Controls.Add(this.deviceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Name = "tempControl";
            this.Text = "tempControl";
            this.Load += new System.EventHandler(this.tempControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperColorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer tempTimer;
        private System.Windows.Forms.ComboBox deviceBox;
        private System.Windows.Forms.NumericUpDown txtLower;
        private System.Windows.Forms.NumericUpDown txtUpper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox lowerColorBox;
        private System.Windows.Forms.PictureBox upperColorBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}