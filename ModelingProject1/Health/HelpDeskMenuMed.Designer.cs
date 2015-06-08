namespace Health
{
    partial class HelpDeskMenuMed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpDeskMenuMed));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proficiênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarProficiênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarProficiênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarProficiênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarMédicoToolStripMenuItem,
            this.proficiênciasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarMédicoToolStripMenuItem
            // 
            this.adicionarMédicoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adicionarMédicoToolStripMenuItem.Image")));
            this.adicionarMédicoToolStripMenuItem.Name = "adicionarMédicoToolStripMenuItem";
            this.adicionarMédicoToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.adicionarMédicoToolStripMenuItem.Text = "Adicionar Médico";
            this.adicionarMédicoToolStripMenuItem.Click += new System.EventHandler(this.adicionarMédicoToolStripMenuItem_Click);
            // 
            // proficiênciasToolStripMenuItem
            // 
            this.proficiênciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarProficiênciaToolStripMenuItem,
            this.pesquisarProficiênciaToolStripMenuItem,
            this.atualizarProficiênciaToolStripMenuItem});
            this.proficiênciasToolStripMenuItem.Image = global::Health.Properties.Resources.sem_nome__2_;
            this.proficiênciasToolStripMenuItem.Name = "proficiênciasToolStripMenuItem";
            this.proficiênciasToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.proficiênciasToolStripMenuItem.Text = "Proficiência";
            // 
            // adicionarProficiênciaToolStripMenuItem
            // 
            this.adicionarProficiênciaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adicionarProficiênciaToolStripMenuItem.Image")));
            this.adicionarProficiênciaToolStripMenuItem.Name = "adicionarProficiênciaToolStripMenuItem";
            this.adicionarProficiênciaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.adicionarProficiênciaToolStripMenuItem.Text = "Adicionar Proficiência";
            this.adicionarProficiênciaToolStripMenuItem.Click += new System.EventHandler(this.adicionarProficiênciaToolStripMenuItem_Click);
            // 
            // pesquisarProficiênciaToolStripMenuItem
            // 
            this.pesquisarProficiênciaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pesquisarProficiênciaToolStripMenuItem.Image")));
            this.pesquisarProficiênciaToolStripMenuItem.Name = "pesquisarProficiênciaToolStripMenuItem";
            this.pesquisarProficiênciaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.pesquisarProficiênciaToolStripMenuItem.Text = "Pesquisar Proficiência";
            this.pesquisarProficiênciaToolStripMenuItem.Click += new System.EventHandler(this.pesquisarProficiênciaToolStripMenuItem_Click);
            // 
            // atualizarProficiênciaToolStripMenuItem
            // 
            this.atualizarProficiênciaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("atualizarProficiênciaToolStripMenuItem.Image")));
            this.atualizarProficiênciaToolStripMenuItem.Name = "atualizarProficiênciaToolStripMenuItem";
            this.atualizarProficiênciaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.atualizarProficiênciaToolStripMenuItem.Text = "Atualizar Proficiência";
            this.atualizarProficiênciaToolStripMenuItem.Click += new System.EventHandler(this.atualizarProficiênciaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // HelpDeskMenuMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 275);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "HelpDeskMenuMed";
            this.Text = "Menu Medico";
            this.Load += new System.EventHandler(this.HelpDeskMenuMed_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarMédicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proficiênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarProficiênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarProficiênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarProficiênciaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}