
namespace StackSimulator
{
    partial class fmDecConvert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDecConvert));
            this.numCv = new System.Windows.Forms.NumericUpDown();
            this.btBin = new System.Windows.Forms.Button();
            this.btHex = new System.Windows.Forms.Button();
            this.btOct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btQuit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btRd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lbTop = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Panel();
            this.lbRs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCv)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numCv
            // 
            this.numCv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCv.Location = new System.Drawing.Point(11, 40);
            this.numCv.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numCv.Name = "numCv";
            this.numCv.Size = new System.Drawing.Size(120, 34);
            this.numCv.TabIndex = 1;
            this.numCv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCv.ValueChanged += new System.EventHandler(this.numCv_ValueChanged);
            // 
            // btBin
            // 
            this.btBin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btBin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBin.Location = new System.Drawing.Point(11, 105);
            this.btBin.Name = "btBin";
            this.btBin.Size = new System.Drawing.Size(117, 37);
            this.btBin.TabIndex = 2;
            this.btBin.Text = "Binary";
            this.btBin.UseVisualStyleBackColor = false;
            this.btBin.Click += new System.EventHandler(this.btBin_Click);
            // 
            // btHex
            // 
            this.btHex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btHex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHex.Location = new System.Drawing.Point(11, 148);
            this.btHex.Name = "btHex";
            this.btHex.Size = new System.Drawing.Size(117, 37);
            this.btHex.TabIndex = 3;
            this.btHex.Text = "Hex";
            this.btHex.UseVisualStyleBackColor = false;
            this.btHex.Click += new System.EventHandler(this.btHex_Click);
            // 
            // btOct
            // 
            this.btOct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btOct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOct.Location = new System.Drawing.Point(11, 191);
            this.btOct.Name = "btOct";
            this.btOct.Size = new System.Drawing.Size(117, 37);
            this.btOct.TabIndex = 4;
            this.btOct.Text = "Octal";
            this.btOct.UseVisualStyleBackColor = false;
            this.btOct.Click += new System.EventHandler(this.btOct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "to";
            // 
            // btQuit
            // 
            this.btQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuit.Location = new System.Drawing.Point(11, 389);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(117, 37);
            this.btQuit.TabIndex = 4;
            this.btQuit.Text = "Quit";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btRd);
            this.panel1.Controls.Add(this.btQuit);
            this.panel1.Controls.Add(this.numCv);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btBin);
            this.panel1.Controls.Add(this.btHex);
            this.panel1.Controls.Add(this.btOct);
            this.panel1.Location = new System.Drawing.Point(380, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 429);
            this.panel1.TabIndex = 5;
            // 
            // btRd
            // 
            this.btRd.BackColor = System.Drawing.Color.White;
            this.btRd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRd.Location = new System.Drawing.Point(11, 3);
            this.btRd.Name = "btRd";
            this.btRd.Size = new System.Drawing.Size(117, 31);
            this.btRd.TabIndex = 5;
            this.btRd.Text = "Decimal";
            this.btRd.UseVisualStyleBackColor = false;
            this.btRd.Click += new System.EventHandler(this.btRd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 400;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 400;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lbTop
            // 
            this.lbTop.AutoSize = true;
            this.lbTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTop.Location = new System.Drawing.Point(54, 156);
            this.lbTop.Name = "lbTop";
            this.lbTop.Size = new System.Drawing.Size(40, 20);
            this.lbTop.TabIndex = 7;
            this.lbTop.Text = "Top";
            this.lbTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTop.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoScroll = true;
            this.label3.BackColor = System.Drawing.Color.PeachPuff;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.MaximumSize = new System.Drawing.Size(350, 1000);
            this.label3.MinimumSize = new System.Drawing.Size(350, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 390);
            this.label3.TabIndex = 9;
            // 
            // lbRs
            // 
            this.lbRs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRs.Location = new System.Drawing.Point(12, 31);
            this.lbRs.Name = "lbRs";
            this.lbRs.Size = new System.Drawing.Size(334, 34);
            this.lbRs.TabIndex = 10;
            this.lbRs.Text = "Result: ";
            this.lbRs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fmDecConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 469);
            this.Controls.Add(this.lbRs);
            this.Controls.Add(this.lbTop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmDecConvert";
            this.Text = "Convert";
            ((System.ComponentModel.ISupportInitialize)(this.numCv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numCv;
        private System.Windows.Forms.Button btBin;
        private System.Windows.Forms.Button btHex;
        private System.Windows.Forms.Button btOct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btRd;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lbTop;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Panel label3;
        private System.Windows.Forms.Label lbRs;
    }
}