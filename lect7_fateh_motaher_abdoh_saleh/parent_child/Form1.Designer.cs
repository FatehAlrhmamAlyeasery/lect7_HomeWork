namespace parent_child
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.العملياتالحسابيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جمعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.طرحToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ضربToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.قسمةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "إغلاق";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.العملياتالحسابيةToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(372, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // العملياتالحسابيةToolStripMenuItem
            // 
            this.العملياتالحسابيةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.جمعToolStripMenuItem,
            this.طرحToolStripMenuItem,
            this.ضربToolStripMenuItem,
            this.قسمةToolStripMenuItem});
            this.العملياتالحسابيةToolStripMenuItem.Name = "العملياتالحسابيةToolStripMenuItem";
            this.العملياتالحسابيةToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.العملياتالحسابيةToolStripMenuItem.Text = "العمليات الحسابية";
            this.العملياتالحسابيةToolStripMenuItem.Click += new System.EventHandler(this.العملياتالحسابيةToolStripMenuItem_Click);
            // 
            // جمعToolStripMenuItem
            // 
            this.جمعToolStripMenuItem.Name = "جمعToolStripMenuItem";
            this.جمعToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.جمعToolStripMenuItem.Text = "جمع";
            this.جمعToolStripMenuItem.Click += new System.EventHandler(this.جمعToolStripMenuItem_Click);
            // 
            // طرحToolStripMenuItem
            // 
            this.طرحToolStripMenuItem.Name = "طرحToolStripMenuItem";
            this.طرحToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.طرحToolStripMenuItem.Text = "طرح";
            this.طرحToolStripMenuItem.Click += new System.EventHandler(this.طرحToolStripMenuItem_Click);
            // 
            // ضربToolStripMenuItem
            // 
            this.ضربToolStripMenuItem.Name = "ضربToolStripMenuItem";
            this.ضربToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ضربToolStripMenuItem.Text = "ضرب";
            this.ضربToolStripMenuItem.Click += new System.EventHandler(this.ضربToolStripMenuItem_Click);
            // 
            // قسمةToolStripMenuItem
            // 
            this.قسمةToolStripMenuItem.Name = "قسمةToolStripMenuItem";
            this.قسمةToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.قسمةToolStripMenuItem.Text = "قسمة";
            this.قسمةToolStripMenuItem.Click += new System.EventHandler(this.قسمةToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 294);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem العملياتالحسابيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem جمعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem طرحToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ضربToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem قسمةToolStripMenuItem;
    }
}

