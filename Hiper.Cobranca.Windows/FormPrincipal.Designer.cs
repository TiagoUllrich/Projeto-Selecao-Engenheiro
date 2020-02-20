namespace Hiper.Cobranca.Windows
{
    partial class FormPrincipal
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
            this.situaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inadimplentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.followUpsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analistasFinanceirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.situaçõesToolStripMenuItem,
            this.inadimplentesToolStripMenuItem,
            this.followUpsToolStripMenuItem,
            this.analistasFinanceirosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // situaçõesToolStripMenuItem
            // 
            this.situaçõesToolStripMenuItem.Name = "situaçõesToolStripMenuItem";
            this.situaçõesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.situaçõesToolStripMenuItem.Text = "Situações";
            this.situaçõesToolStripMenuItem.Click += new System.EventHandler(this.situaçõesToolStripMenuItem_Click);
            // 
            // inadimplentesToolStripMenuItem
            // 
            this.inadimplentesToolStripMenuItem.Name = "inadimplentesToolStripMenuItem";
            this.inadimplentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.inadimplentesToolStripMenuItem.Text = "Inadimplentes";
            this.inadimplentesToolStripMenuItem.Click += new System.EventHandler(this.inadimplentesToolStripMenuItem_Click);
            // 
            // followUpsToolStripMenuItem
            // 
            this.followUpsToolStripMenuItem.Name = "followUpsToolStripMenuItem";
            this.followUpsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.followUpsToolStripMenuItem.Text = "Follow Ups";
            // 
            // analistasFinanceirosToolStripMenuItem
            // 
            this.analistasFinanceirosToolStripMenuItem.Name = "analistasFinanceirosToolStripMenuItem";
            this.analistasFinanceirosToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.analistasFinanceirosToolStripMenuItem.Text = "Analistas Financeiros";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Hiper - Cobrança de Inadimplentes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem situaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inadimplentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem followUpsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analistasFinanceirosToolStripMenuItem;
    }
}

