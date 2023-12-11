namespace staj_1
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            bOOKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            vIEWBOOKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aDDBOOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            vIEWSTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aDDSTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ıSSUEBOOKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            rETURNBOOKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label1 = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bOOKSToolStripMenuItem, sTUDENTToolStripMenuItem, ıSSUEBOOKSToolStripMenuItem, rETURNBOOKSToolStripMenuItem, eXITToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(461, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // bOOKSToolStripMenuItem
            // 
            bOOKSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { vIEWBOOKSToolStripMenuItem, aDDBOOKToolStripMenuItem });
            bOOKSToolStripMenuItem.Name = "bOOKSToolStripMenuItem";
            bOOKSToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            bOOKSToolStripMenuItem.Text = "BOOKS";
            // 
            // vIEWBOOKSToolStripMenuItem
            // 
            vIEWBOOKSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            vIEWBOOKSToolStripMenuItem.Name = "vIEWBOOKSToolStripMenuItem";
            vIEWBOOKSToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            vIEWBOOKSToolStripMenuItem.Text = "VIEW BOOKS";
            vIEWBOOKSToolStripMenuItem.Click += vIEWBOOKSToolStripMenuItem_Click;
            // 
            // aDDBOOKToolStripMenuItem
            // 
            aDDBOOKToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            aDDBOOKToolStripMenuItem.Name = "aDDBOOKToolStripMenuItem";
            aDDBOOKToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            aDDBOOKToolStripMenuItem.Text = "ADD BOOK";
            aDDBOOKToolStripMenuItem.Click += aDDBOOKToolStripMenuItem_Click;
            // 
            // sTUDENTToolStripMenuItem
            // 
            sTUDENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { vIEWSTUDENTToolStripMenuItem, aDDSTUDENTToolStripMenuItem });
            sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            sTUDENTToolStripMenuItem.Text = "STUDENT";
            // 
            // vIEWSTUDENTToolStripMenuItem
            // 
            vIEWSTUDENTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            vIEWSTUDENTToolStripMenuItem.Name = "vIEWSTUDENTToolStripMenuItem";
            vIEWSTUDENTToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            vIEWSTUDENTToolStripMenuItem.Text = "VIEW STUDENT";
            vIEWSTUDENTToolStripMenuItem.Click += vIEWSTUDENTToolStripMenuItem_Click;
            // 
            // aDDSTUDENTToolStripMenuItem
            // 
            aDDSTUDENTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            aDDSTUDENTToolStripMenuItem.Name = "aDDSTUDENTToolStripMenuItem";
            aDDSTUDENTToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            aDDSTUDENTToolStripMenuItem.Text = "ADD STUDENT";
            aDDSTUDENTToolStripMenuItem.Click += aDDSTUDENTToolStripMenuItem_Click;
            // 
            // ıSSUEBOOKSToolStripMenuItem
            // 
            ıSSUEBOOKSToolStripMenuItem.Name = "ıSSUEBOOKSToolStripMenuItem";
            ıSSUEBOOKSToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            ıSSUEBOOKSToolStripMenuItem.Text = "ISSUE BOOKS";
            ıSSUEBOOKSToolStripMenuItem.Click += ıSSUEBOOKSToolStripMenuItem_Click;
            // 
            // rETURNBOOKSToolStripMenuItem
            // 
            rETURNBOOKSToolStripMenuItem.Name = "rETURNBOOKSToolStripMenuItem";
            rETURNBOOKSToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            rETURNBOOKSToolStripMenuItem.Text = "RETURN BOOKS";
            rETURNBOOKSToolStripMenuItem.Click += rETURNBOOKSToolStripMenuItem_Click;
            // 
            // eXITToolStripMenuItem
            // 
            eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            eXITToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            eXITToolStripMenuItem.Text = "EXIT";
            eXITToolStripMenuItem.Click += eXITToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(138, 114);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(513, 46);
            label1.TabIndex = 1;
            label1.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Dashboard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bOOKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWBOOKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDBOOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWSTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDSTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ıSSUEBOOKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rETURNBOOKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}