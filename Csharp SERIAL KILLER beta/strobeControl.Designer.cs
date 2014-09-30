namespace Csharp_SERIAL_KILLER_beta
{
    partial class strobeControl
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.blueupdown = new System.Windows.Forms.NumericUpDown();
            this.greenupdown = new System.Windows.Forms.NumericUpDown();
            this.redupdown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bluebar = new System.Windows.Forms.TrackBar();
            this.greenbar = new System.Windows.Forms.TrackBar();
            this.redbar = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(56, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 44;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(12, 44);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(223, 45);
            this.trackBar1.TabIndex = 43;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Select the flashing speed";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(123, 360);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 46;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.strobeModeStop);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(45, 360);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 45;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.strobeModeStart);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Select the led color";
            // 
            // blueupdown
            // 
            this.blueupdown.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.blueupdown.ForeColor = System.Drawing.Color.Blue;
            this.blueupdown.Location = new System.Drawing.Point(190, 201);
            this.blueupdown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueupdown.Name = "blueupdown";
            this.blueupdown.Size = new System.Drawing.Size(45, 21);
            this.blueupdown.TabIndex = 93;
            // 
            // greenupdown
            // 
            this.greenupdown.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.greenupdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenupdown.Location = new System.Drawing.Point(101, 202);
            this.greenupdown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenupdown.Name = "greenupdown";
            this.greenupdown.Size = new System.Drawing.Size(45, 21);
            this.greenupdown.TabIndex = 92;
            // 
            // redupdown
            // 
            this.redupdown.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.redupdown.ForeColor = System.Drawing.Color.Red;
            this.redupdown.Location = new System.Drawing.Point(13, 200);
            this.redupdown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redupdown.Name = "redupdown";
            this.redupdown.Size = new System.Drawing.Size(45, 21);
            this.redupdown.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(205, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(114, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 89;
            this.label5.Text = "G";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(26, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 88;
            this.label6.Text = "R";
            // 
            // bluebar
            // 
            this.bluebar.BackColor = System.Drawing.Color.DodgerBlue;
            this.bluebar.Location = new System.Drawing.Point(190, 228);
            this.bluebar.Maximum = 255;
            this.bluebar.Name = "bluebar";
            this.bluebar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bluebar.Size = new System.Drawing.Size(45, 119);
            this.bluebar.TabIndex = 87;
            this.bluebar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.bluebar.ValueChanged += new System.EventHandler(this.bluebar_Scroll);
            // 
            // greenbar
            // 
            this.greenbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.greenbar.Location = new System.Drawing.Point(101, 229);
            this.greenbar.Maximum = 255;
            this.greenbar.Name = "greenbar";
            this.greenbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.greenbar.Size = new System.Drawing.Size(45, 119);
            this.greenbar.TabIndex = 86;
            this.greenbar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.greenbar.ValueChanged += new System.EventHandler(this.greenbar_Scroll);
            // 
            // redbar
            // 
            this.redbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.redbar.Location = new System.Drawing.Point(12, 227);
            this.redbar.Maximum = 255;
            this.redbar.Name = "redbar";
            this.redbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.redbar.Size = new System.Drawing.Size(45, 120);
            this.redbar.TabIndex = 85;
            this.redbar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.redbar.ValueChanged += new System.EventHandler(this.redbar_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 94;
            this.button1.Text = "Color picker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // strobeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 396);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.blueupdown);
            this.Controls.Add(this.greenupdown);
            this.Controls.Add(this.redupdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bluebar);
            this.Controls.Add(this.greenbar);
            this.Controls.Add(this.redbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label4);
            this.Name = "strobeControl";
            this.Text = "strobeControl";
            this.Load += new System.EventHandler(this.strobeControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.NumericUpDown blueupdown;
        internal System.Windows.Forms.NumericUpDown greenupdown;
        internal System.Windows.Forms.NumericUpDown redupdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar bluebar;
        private System.Windows.Forms.TrackBar greenbar;
        private System.Windows.Forms.TrackBar redbar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}