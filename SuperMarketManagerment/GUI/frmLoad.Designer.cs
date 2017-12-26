namespace GUI
{
    partial class frmLoad
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progress_Bar_2 = new System.Windows.Forms.ProgressBar();
            this.progress_Bar_1 = new System.Windows.Forms.ProgressBar();
            this.progress_Bar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(544, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đóng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progress_Bar_2
            // 
            this.progress_Bar_2.BackColor = System.Drawing.Color.Black;
            this.progress_Bar_2.ForeColor = System.Drawing.Color.Black;
            this.progress_Bar_2.Location = new System.Drawing.Point(36, 483);
            this.progress_Bar_2.Name = "progress_Bar_2";
            this.progress_Bar_2.Size = new System.Drawing.Size(436, 11);
            this.progress_Bar_2.TabIndex = 5;
            this.progress_Bar_2.Visible = false;
            // 
            // progress_Bar_1
            // 
            this.progress_Bar_1.BackColor = System.Drawing.Color.Black;
            this.progress_Bar_1.ForeColor = System.Drawing.Color.Black;
            this.progress_Bar_1.Location = new System.Drawing.Point(47, 466);
            this.progress_Bar_1.Name = "progress_Bar_1";
            this.progress_Bar_1.Size = new System.Drawing.Size(417, 11);
            this.progress_Bar_1.TabIndex = 6;
            this.progress_Bar_1.Visible = false;
            // 
            // progress_Bar
            // 
            this.progress_Bar.BackColor = System.Drawing.Color.Black;
            this.progress_Bar.ForeColor = System.Drawing.Color.Black;
            this.progress_Bar.Location = new System.Drawing.Point(60, 447);
            this.progress_Bar.Name = "progress_Bar";
            this.progress_Bar.Size = new System.Drawing.Size(391, 12);
            this.progress_Bar.TabIndex = 3;
            this.progress_Bar.Visible = false;
            // 
            // frmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.preLoad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(506, 506);
            this.ControlBox = false;
            this.Controls.Add(this.progress_Bar_1);
            this.Controls.Add(this.progress_Bar_2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progress_Bar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmLoad";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLoad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progress_Bar_2;
        private System.Windows.Forms.ProgressBar progress_Bar_1;
        private System.Windows.Forms.ProgressBar progress_Bar;
    }
}