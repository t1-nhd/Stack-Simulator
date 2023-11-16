
namespace StackSimulator
{
    partial class fmStack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmStack));
            this.btPush = new System.Windows.Forms.Button();
            this.btRandom = new System.Windows.Forms.Button();
            this.btPop = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.txList = new System.Windows.Forms.TextBox();
            this.txCount = new System.Windows.Forms.TextBox();
            this.btPeek = new System.Windows.Forms.Button();
            this.pnStack = new System.Windows.Forms.Panel();
            this.txPop = new System.Windows.Forms.Label();
            this.btStop = new System.Windows.Forms.Button();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.txPush = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infixToPostfixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawingStack = new System.Windows.Forms.Panel();
            this.txTop = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnStack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txPush)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.drawingStack.SuspendLayout();
            this.SuspendLayout();
            // 
            // btPush
            // 
            this.btPush.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btPush.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPush.Location = new System.Drawing.Point(4, 122);
            this.btPush.Margin = new System.Windows.Forms.Padding(2);
            this.btPush.Name = "btPush";
            this.btPush.Size = new System.Drawing.Size(78, 41);
            this.btPush.TabIndex = 1;
            this.btPush.Text = "Push";
            this.btPush.UseVisualStyleBackColor = true;
            this.btPush.Click += new System.EventHandler(this.btPush_Click);
            // 
            // btRandom
            // 
            this.btRandom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRandom.Location = new System.Drawing.Point(4, 44);
            this.btRandom.Margin = new System.Windows.Forms.Padding(2);
            this.btRandom.Name = "btRandom";
            this.btRandom.Size = new System.Drawing.Size(78, 41);
            this.btRandom.TabIndex = 0;
            this.btRandom.TabStop = false;
            this.btRandom.Text = "Random";
            this.btRandom.UseVisualStyleBackColor = true;
            this.btRandom.Click += new System.EventHandler(this.btRandom_Click);
            // 
            // btPop
            // 
            this.btPop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPop.Location = new System.Drawing.Point(4, 221);
            this.btPop.Margin = new System.Windows.Forms.Padding(2);
            this.btPop.Name = "btPop";
            this.btPop.Size = new System.Drawing.Size(78, 41);
            this.btPop.TabIndex = 2;
            this.btPop.Text = "Pop";
            this.btPop.UseVisualStyleBackColor = true;
            this.btPop.Click += new System.EventHandler(this.btPop_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(4, 500);
            this.btClear.Margin = new System.Windows.Forms.Padding(2);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(78, 41);
            this.btClear.TabIndex = 4;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // txList
            // 
            this.txList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txList.Location = new System.Drawing.Point(8, 25);
            this.txList.Margin = new System.Windows.Forms.Padding(2);
            this.txList.Multiline = true;
            this.txList.Name = "txList";
            this.txList.ReadOnly = true;
            this.txList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txList.Size = new System.Drawing.Size(270, 53);
            this.txList.TabIndex = 3;
            // 
            // txCount
            // 
            this.txCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txCount.Enabled = false;
            this.txCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCount.Location = new System.Drawing.Point(4, 10);
            this.txCount.Margin = new System.Windows.Forms.Padding(2);
            this.txCount.Name = "txCount";
            this.txCount.ReadOnly = true;
            this.txCount.Size = new System.Drawing.Size(77, 21);
            this.txCount.TabIndex = 3;
            this.txCount.TabStop = false;
            this.txCount.Text = "Count: 0";
            // 
            // btPeek
            // 
            this.btPeek.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btPeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPeek.Location = new System.Drawing.Point(4, 266);
            this.btPeek.Margin = new System.Windows.Forms.Padding(2);
            this.btPeek.Name = "btPeek";
            this.btPeek.Size = new System.Drawing.Size(78, 41);
            this.btPeek.TabIndex = 3;
            this.btPeek.Text = "Peek";
            this.btPeek.UseVisualStyleBackColor = true;
            this.btPeek.Click += new System.EventHandler(this.btPeek_Click);
            // 
            // pnStack
            // 
            this.pnStack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnStack.Controls.Add(this.txPop);
            this.pnStack.Controls.Add(this.btStop);
            this.pnStack.Controls.Add(this.numMax);
            this.pnStack.Controls.Add(this.button1);
            this.pnStack.Controls.Add(this.txPush);
            this.pnStack.Controls.Add(this.txCount);
            this.pnStack.Controls.Add(this.btPop);
            this.pnStack.Controls.Add(this.btRandom);
            this.pnStack.Controls.Add(this.btClear);
            this.pnStack.Controls.Add(this.btPush);
            this.pnStack.Controls.Add(this.btPeek);
            this.pnStack.Location = new System.Drawing.Point(283, 25);
            this.pnStack.Margin = new System.Windows.Forms.Padding(2);
            this.pnStack.Name = "pnStack";
            this.pnStack.Size = new System.Drawing.Size(92, 545);
            this.pnStack.TabIndex = 0;
            // 
            // txPop
            // 
            this.txPop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPop.ForeColor = System.Drawing.Color.Red;
            this.txPop.Location = new System.Drawing.Point(4, 196);
            this.txPop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txPop.Name = "txPop";
            this.txPop.Size = new System.Drawing.Size(78, 23);
            this.txPop.TabIndex = 8;
            this.txPop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStop.Location = new System.Drawing.Point(13, 471);
            this.btStop.Margin = new System.Windows.Forms.Padding(2);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(58, 25);
            this.btStop.TabIndex = 7;
            this.btStop.Text = "Pause";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // numMax
            // 
            this.numMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMax.Location = new System.Drawing.Point(4, 368);
            this.numMax.Margin = new System.Windows.Forms.Padding(2);
            this.numMax.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(77, 26);
            this.numMax.TabIndex = 6;
            this.numMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMax.ValueChanged += new System.EventHandler(this.numMax_ValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(4, 312);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Random list";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txPush
            // 
            this.txPush.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txPush.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPush.Location = new System.Drawing.Point(4, 89);
            this.txPush.Margin = new System.Windows.Forms.Padding(2);
            this.txPush.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txPush.Name = "txPush";
            this.txPush.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txPush.Size = new System.Drawing.Size(77, 26);
            this.txPush.TabIndex = 0;
            this.txPush.Tag = "0";
            this.txPush.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txPush.ValueChanged += new System.EventHandler(this.txPush_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.convertToolStripMenuItem,
            this.queueToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(380, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.infixToPostfixToolStripMenuItem});
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.convertToolStripMenuItem.Text = "Convert";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // infixToPostfixToolStripMenuItem
            // 
            this.infixToPostfixToolStripMenuItem.Name = "infixToPostfixToolStripMenuItem";
            this.infixToPostfixToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.infixToPostfixToolStripMenuItem.Text = "Infix to Postfix";
            this.infixToPostfixToolStripMenuItem.Click += new System.EventHandler(this.infixToPostfixToolStripMenuItem_Click);
            // 
            // queueToolStripMenuItem
            // 
            this.queueToolStripMenuItem.Name = "queueToolStripMenuItem";
            this.queueToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.queueToolStripMenuItem.Text = "Queue";
            this.queueToolStripMenuItem.Click += new System.EventHandler(this.queueToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // drawingStack
            // 
            this.drawingStack.BackColor = System.Drawing.Color.White;
            this.drawingStack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingStack.Controls.Add(this.txTop);
            this.drawingStack.Location = new System.Drawing.Point(8, 83);
            this.drawingStack.Margin = new System.Windows.Forms.Padding(2);
            this.drawingStack.Name = "drawingStack";
            this.drawingStack.Size = new System.Drawing.Size(270, 487);
            this.drawingStack.TabIndex = 5;
            // 
            // txTop
            // 
            this.txTop.AutoSize = true;
            this.txTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTop.Location = new System.Drawing.Point(52, 483);
            this.txTop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txTop.Name = "txTop";
            this.txTop.Size = new System.Drawing.Size(33, 17);
            this.txTop.TabIndex = 0;
            this.txTop.Text = "Top";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fmStack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 576);
            this.Controls.Add(this.drawingStack);
            this.Controls.Add(this.pnStack);
            this.Controls.Add(this.txList);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fmStack";
            this.Text = "Stack Simulator";
            this.pnStack.ResumeLayout(false);
            this.pnStack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txPush)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.drawingStack.ResumeLayout(false);
            this.drawingStack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPush;
        private System.Windows.Forms.Button btRandom;
        private System.Windows.Forms.Button btPop;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox txList;
        private System.Windows.Forms.TextBox txCount;
        private System.Windows.Forms.Button btPeek;
        private System.Windows.Forms.Panel pnStack;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel drawingStack;
        private System.Windows.Forms.Label txTop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown txPush;
        private System.Windows.Forms.ToolStripMenuItem queueToolStripMenuItem;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infixToPostfixToolStripMenuItem;
        private System.Windows.Forms.Label txPop;
    }
}

