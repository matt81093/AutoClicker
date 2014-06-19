namespace AutoClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startbutton = new System.Windows.Forms.Button();
            this.clicktimer = new System.Windows.Forms.Timer(this.components);
            this.stopbut = new System.Windows.Forms.Button();
            this.clickintervaltext = new System.Windows.Forms.TextBox();
            this.statuslabel = new System.Windows.Forms.Label();
            this.coordlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.amounttext = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixedrbut = new System.Windows.Forms.RadioButton();
            this.cursorrbut = new System.Windows.Forms.RadioButton();
            this.clickatlabel = new System.Windows.Forms.Label();
            this.fixedlabel = new System.Windows.Forms.Label();
            this.statusheaderlabel = new System.Windows.Forms.Label();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(12, 36);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(124, 23);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "Start (F1)";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // clicktimer
            // 
            this.clicktimer.Interval = 1000;
            this.clicktimer.Tick += new System.EventHandler(this.clicktimer_Tick);
            // 
            // stopbut
            // 
            this.stopbut.Location = new System.Drawing.Point(145, 36);
            this.stopbut.Name = "stopbut";
            this.stopbut.Size = new System.Drawing.Size(127, 23);
            this.stopbut.TabIndex = 1;
            this.stopbut.Text = "Stop (F2)";
            this.stopbut.UseVisualStyleBackColor = true;
            this.stopbut.Click += new System.EventHandler(this.stopbut_Click);
            // 
            // clickintervaltext
            // 
            this.clickintervaltext.Location = new System.Drawing.Point(128, 98);
            this.clickintervaltext.MaxLength = 22;
            this.clickintervaltext.Name = "clickintervaltext";
            this.clickintervaltext.Size = new System.Drawing.Size(144, 20);
            this.clickintervaltext.TabIndex = 3;
            this.clickintervaltext.Text = "1000";
            this.clickintervaltext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clickintervaltext_KeyPress);
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.Location = new System.Drawing.Point(124, 216);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(64, 13);
            this.statuslabel.TabIndex = 3;
            this.statuslabel.Text = "Not Clicking";
            // 
            // coordlabel
            // 
            this.coordlabel.AutoSize = true;
            this.coordlabel.Location = new System.Drawing.Point(194, 193);
            this.coordlabel.Name = "coordlabel";
            this.coordlabel.Size = new System.Drawing.Size(48, 13);
            this.coordlabel.TabIndex = 4;
            this.coordlabel.Text = "X=0,Y=0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Clicking Interval (ms) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Times to click (0 for infinite):";
            // 
            // amounttext
            // 
            this.amounttext.Location = new System.Drawing.Point(156, 70);
            this.amounttext.MaxLength = 18;
            this.amounttext.Name = "amounttext";
            this.amounttext.Size = new System.Drawing.Size(116, 20);
            this.amounttext.TabIndex = 2;
            this.amounttext.Text = "0";
            this.amounttext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amounttext_KeyPress);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(284, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // fixedrbut
            // 
            this.fixedrbut.AutoSize = true;
            this.fixedrbut.Location = new System.Drawing.Point(127, 155);
            this.fixedrbut.Name = "fixedrbut";
            this.fixedrbut.Size = new System.Drawing.Size(94, 17);
            this.fixedrbut.TabIndex = 5;
            this.fixedrbut.TabStop = true;
            this.fixedrbut.Text = "Fixed Location";
            this.fixedrbut.UseVisualStyleBackColor = true;
            // 
            // cursorrbut
            // 
            this.cursorrbut.AutoSize = true;
            this.cursorrbut.Checked = true;
            this.cursorrbut.Location = new System.Drawing.Point(63, 155);
            this.cursorrbut.Name = "cursorrbut";
            this.cursorrbut.Size = new System.Drawing.Size(55, 17);
            this.cursorrbut.TabIndex = 4;
            this.cursorrbut.TabStop = true;
            this.cursorrbut.Text = "Cursor";
            this.cursorrbut.UseVisualStyleBackColor = true;
            // 
            // clickatlabel
            // 
            this.clickatlabel.AutoSize = true;
            this.clickatlabel.Location = new System.Drawing.Point(111, 139);
            this.clickatlabel.Name = "clickatlabel";
            this.clickatlabel.Size = new System.Drawing.Size(48, 13);
            this.clickatlabel.TabIndex = 12;
            this.clickatlabel.Text = "Click at :";
            // 
            // fixedlabel
            // 
            this.fixedlabel.AutoSize = true;
            this.fixedlabel.Location = new System.Drawing.Point(25, 193);
            this.fixedlabel.Name = "fixedlabel";
            this.fixedlabel.Size = new System.Drawing.Size(163, 13);
            this.fixedlabel.TabIndex = 13;
            this.fixedlabel.Text = "Fixed Location (Press F3 to Set) :";
            // 
            // statusheaderlabel
            // 
            this.statusheaderlabel.AutoSize = true;
            this.statusheaderlabel.Location = new System.Drawing.Point(76, 216);
            this.statusheaderlabel.Name = "statusheaderlabel";
            this.statusheaderlabel.Size = new System.Drawing.Size(46, 13);
            this.statusheaderlabel.TabIndex = 14;
            this.statusheaderlabel.Text = "Status : ";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 244);
            this.Controls.Add(this.statusheaderlabel);
            this.Controls.Add(this.fixedlabel);
            this.Controls.Add(this.clickatlabel);
            this.Controls.Add(this.cursorrbut);
            this.Controls.Add(this.fixedrbut);
            this.Controls.Add(this.amounttext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.coordlabel);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.clickintervaltext);
            this.Controls.Add(this.stopbut);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AutoClicker";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Timer clicktimer;
        private System.Windows.Forms.Button stopbut;
        private System.Windows.Forms.TextBox clickintervaltext;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.Label coordlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amounttext;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RadioButton fixedrbut;
        private System.Windows.Forms.RadioButton cursorrbut;
        private System.Windows.Forms.Label clickatlabel;
        private System.Windows.Forms.Label fixedlabel;
        private System.Windows.Forms.Label statusheaderlabel;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

