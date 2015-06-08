namespace Health
{
    partial class HelpdeskMenu
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
            this.btUtentes = new System.Windows.Forms.Button();
            this.btMedicos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btUtentes
            // 
            this.btUtentes.Location = new System.Drawing.Point(307, 113);
            this.btUtentes.Name = "btUtentes";
            this.btUtentes.Size = new System.Drawing.Size(130, 130);
            this.btUtentes.TabIndex = 3;
            this.btUtentes.Text = "Utentes";
            this.btUtentes.UseVisualStyleBackColor = true;
            this.btUtentes.Click += new System.EventHandler(this.btUtentes_Click);
            // 
            // btMedicos
            // 
            this.btMedicos.Location = new System.Drawing.Point(84, 113);
            this.btMedicos.Name = "btMedicos";
            this.btMedicos.Size = new System.Drawing.Size(130, 130);
            this.btMedicos.TabIndex = 2;
            this.btMedicos.Text = "Médicos";
            this.btMedicos.UseVisualStyleBackColor = true;
            this.btMedicos.Click += new System.EventHandler(this.btMedicos_Click);
            // 
            // HelpdeskMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 333);
            this.Controls.Add(this.btUtentes);
            this.Controls.Add(this.btMedicos);
            this.Name = "HelpdeskMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btUtentes;
        private System.Windows.Forms.Button btMedicos;
    }
}