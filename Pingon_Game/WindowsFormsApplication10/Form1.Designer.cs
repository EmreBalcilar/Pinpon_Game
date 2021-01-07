namespace WindowsFormsApplication10
{
    partial class Form1
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
            this.arkaplan = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.oyunbitti = new System.Windows.Forms.Label();
            this.top = new System.Windows.Forms.PictureBox();
            this.raket = new System.Windows.Forms.PictureBox();
            this.topskor = new System.Windows.Forms.Label();
            this.skorsay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.arkaplan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raket)).BeginInit();
            this.SuspendLayout();
            // 
            // arkaplan
            // 
            this.arkaplan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.arkaplan.Controls.Add(this.label1);
            this.arkaplan.Controls.Add(this.oyunbitti);
            this.arkaplan.Controls.Add(this.top);
            this.arkaplan.Controls.Add(this.raket);
            this.arkaplan.Controls.Add(this.topskor);
            this.arkaplan.Controls.Add(this.skorsay);
            this.arkaplan.Cursor = System.Windows.Forms.Cursors.No;
            this.arkaplan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arkaplan.Location = new System.Drawing.Point(0, 0);
            this.arkaplan.Name = "arkaplan";
            this.arkaplan.Size = new System.Drawing.Size(703, 423);
            this.arkaplan.TabIndex = 0;
            this.arkaplan.Paint += new System.Windows.Forms.PaintEventHandler(this.arkaplan_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(510, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 73);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // oyunbitti
            // 
            this.oyunbitti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oyunbitti.AutoSize = true;
            this.oyunbitti.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyunbitti.Location = new System.Drawing.Point(91, 78);
            this.oyunbitti.Name = "oyunbitti";
            this.oyunbitti.Size = new System.Drawing.Size(446, 220);
            this.oyunbitti.TabIndex = 4;
            this.oyunbitti.Text = "Oyun Bitti\r\n\r\n-F1 Restart \r\n-ESC Oyundan Çık\r\n";
            this.oyunbitti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.oyunbitti.Click += new System.EventHandler(this.oyunbitti_Click);
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Red;
            this.top.Location = new System.Drawing.Point(587, 34);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(30, 30);
            this.top.TabIndex = 1;
            this.top.TabStop = false;
            // 
            // raket
            // 
            this.raket.BackColor = System.Drawing.Color.Black;
            this.raket.Location = new System.Drawing.Point(190, 329);
            this.raket.Name = "raket";
            this.raket.Size = new System.Drawing.Size(200, 20);
            this.raket.TabIndex = 0;
            this.raket.TabStop = false;
            // 
            // topskor
            // 
            this.topskor.AutoSize = true;
            this.topskor.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topskor.Location = new System.Drawing.Point(3, 9);
            this.topskor.Name = "topskor";
            this.topskor.Size = new System.Drawing.Size(155, 55);
            this.topskor.TabIndex = 2;
            this.topskor.Text = "Skor :";
            // 
            // skorsay
            // 
            this.skorsay.AutoSize = true;
            this.skorsay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorsay.Location = new System.Drawing.Point(149, 9);
            this.skorsay.Name = "skorsay";
            this.skorsay.Size = new System.Drawing.Size(52, 55);
            this.skorsay.TabIndex = 3;
            this.skorsay.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 423);
            this.Controls.Add(this.arkaplan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.arkaplan.ResumeLayout(false);
            this.arkaplan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel arkaplan;
        private System.Windows.Forms.PictureBox top;
        private System.Windows.Forms.PictureBox raket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label skorsay;
        private System.Windows.Forms.Label topskor;
        private System.Windows.Forms.Label oyunbitti;
        private System.Windows.Forms.Label label1;
    }
}

