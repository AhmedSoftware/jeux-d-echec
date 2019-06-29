namespace ProjetCavalier
{
    partial class PageAceuil
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
            this.JOUER = new System.Windows.Forms.Button();
            this.BApropos = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lancerUnePartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commencerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.approposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // JOUER
            // 
            this.JOUER.Location = new System.Drawing.Point(12, 184);
            this.JOUER.Name = "JOUER";
            this.JOUER.Size = new System.Drawing.Size(144, 58);
            this.JOUER.TabIndex = 0;
            this.JOUER.Text = "JOUER";
            this.JOUER.UseVisualStyleBackColor = true;
            this.JOUER.Click += new System.EventHandler(this.Automatique_Click);
            this.JOUER.MouseLeave += new System.EventHandler(this.JOUER_MouseLeave);
            this.JOUER.MouseMove += new System.Windows.Forms.MouseEventHandler(this.JOUER_MouseMove);
            // 
            // BApropos
            // 
            this.BApropos.Location = new System.Drawing.Point(386, 184);
            this.BApropos.Name = "BApropos";
            this.BApropos.Size = new System.Drawing.Size(160, 58);
            this.BApropos.TabIndex = 1;
            this.BApropos.Text = "But Du Jeu";
            this.BApropos.UseVisualStyleBackColor = true;
            this.BApropos.Click += new System.EventHandler(this.BApropos_Click);
            this.BApropos.MouseLeave += new System.EventHandler(this.BApropos_MouseLeave);
            this.BApropos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BApropos_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lancerUnePartieToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // lancerUnePartieToolStripMenuItem
            // 
            this.lancerUnePartieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commencerToolStripMenuItem,
            this.quiterToolStripMenuItem});
            this.lancerUnePartieToolStripMenuItem.Name = "lancerUnePartieToolStripMenuItem";
            this.lancerUnePartieToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.lancerUnePartieToolStripMenuItem.Text = "&Menu";
            // 
            // commencerToolStripMenuItem
            // 
            this.commencerToolStripMenuItem.Name = "commencerToolStripMenuItem";
            this.commencerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.commencerToolStripMenuItem.Text = "&Commencer";
            this.commencerToolStripMenuItem.Click += new System.EventHandler(this.commencerToolStripMenuItem_Click);
            // 
            // quiterToolStripMenuItem
            // 
            this.quiterToolStripMenuItem.Name = "quiterToolStripMenuItem";
            this.quiterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quiterToolStripMenuItem.Text = "&Quiter";
            this.quiterToolStripMenuItem.Click += new System.EventHandler(this.quiterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.approposToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "&?";
            // 
            // approposToolStripMenuItem
            // 
            this.approposToolStripMenuItem.Name = "approposToolStripMenuItem";
            this.approposToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.approposToolStripMenuItem.Text = "appropos";
            this.approposToolStripMenuItem.Click += new System.EventHandler(this.approposToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.aideToolStripMenuItem.Text = "aide";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(211, 197);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(136, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // PageAceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 254);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.BApropos);
            this.Controls.Add(this.JOUER);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PageAceuil";
            this.Text = "PageAceuil";
            this.Load += new System.EventHandler(this.PageAceuil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button JOUER;
        private System.Windows.Forms.Button BApropos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lancerUnePartieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commencerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem approposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}