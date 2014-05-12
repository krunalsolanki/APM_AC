namespace APM_AC
{
    partial class frmParent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aCTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCMastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCMaintanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.aCMaintanceToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1176, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.addToolStripMenuItem1,
            this.aCTypeToolStripMenuItem,
            this.aCMastersToolStripMenuItem,
            this.uploadUserToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.adminToolStripMenuItem.Text = "A&dmin";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.addUserToolStripMenuItem.Text = "User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(175, 24);
            this.addToolStripMenuItem1.Text = "Location";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // aCTypeToolStripMenuItem
            // 
            this.aCTypeToolStripMenuItem.Name = "aCTypeToolStripMenuItem";
            this.aCTypeToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.aCTypeToolStripMenuItem.Text = "AC Type";
            this.aCTypeToolStripMenuItem.Click += new System.EventHandler(this.aCTypeToolStripMenuItem_Click);
            // 
            // aCMastersToolStripMenuItem
            // 
            this.aCMastersToolStripMenuItem.Name = "aCMastersToolStripMenuItem";
            this.aCMastersToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.aCMastersToolStripMenuItem.Text = "AC Masters";
            this.aCMastersToolStripMenuItem.Click += new System.EventHandler(this.aCMastersToolStripMenuItem_Click);
            // 
            // aCMaintanceToolStripMenuItem
            // 
            this.aCMaintanceToolStripMenuItem.Name = "aCMaintanceToolStripMenuItem";
            this.aCMaintanceToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.aCMaintanceToolStripMenuItem.Text = "AC &Maintenance";
            this.aCMaintanceToolStripMenuItem.Click += new System.EventHandler(this.aCMaintanceToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // uploadUserToolStripMenuItem
            // 
            this.uploadUserToolStripMenuItem.Name = "uploadUserToolStripMenuItem";
            this.uploadUserToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.uploadUserToolStripMenuItem.Text = "Upload User";
            this.uploadUserToolStripMenuItem.Click += new System.EventHandler(this.uploadUserToolStripMenuItem_Click);
            // 
            // frmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 611);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmParent";
            this.Text = "frmParent";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aCTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCMastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCMaintanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadUserToolStripMenuItem;
    }
}