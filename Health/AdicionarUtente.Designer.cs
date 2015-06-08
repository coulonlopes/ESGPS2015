namespace Health
{
    partial class AdicionarUtente
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardarUtente = new System.Windows.Forms.Button();
            this.tbCP = new System.Windows.Forms.TextBox();
            this.rtbMorada = new System.Windows.Forms.RichTextBox();
            this.tbSNS = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.lbNumTelefone = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.tbbicc = new System.Windows.Forms.TextBox();
            this.tbNomeUtente = new System.Windows.Forms.TextBox();
            this.lbCodigoP = new System.Windows.Forms.Label();
            this.lbMorada = new System.Windows.Forms.Label();
            this.lbDataNasc = new System.Windows.Forms.Label();
            this.lbNumSNS = new System.Windows.Forms.Label();
            this.lbBICC = new System.Windows.Forms.Label();
            this.lbNomeUtente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(430, 238);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(96, 53);
            this.btCancelar.TabIndex = 31;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btGuardarUtente
            // 
            this.btGuardarUtente.Location = new System.Drawing.Point(566, 238);
            this.btGuardarUtente.Name = "btGuardarUtente";
            this.btGuardarUtente.Size = new System.Drawing.Size(96, 53);
            this.btGuardarUtente.TabIndex = 30;
            this.btGuardarUtente.Text = "Guardar";
            this.btGuardarUtente.UseVisualStyleBackColor = true;
            this.btGuardarUtente.Click += new System.EventHandler(this.btGuardarUtente_Click);
            // 
            // tbCP
            // 
            this.tbCP.Location = new System.Drawing.Point(430, 142);
            this.tbCP.Name = "tbCP";
            this.tbCP.Size = new System.Drawing.Size(232, 20);
            this.tbCP.TabIndex = 29;
            // 
            // rtbMorada
            // 
            this.rtbMorada.Location = new System.Drawing.Point(91, 145);
            this.rtbMorada.Name = "rtbMorada";
            this.rtbMorada.Size = new System.Drawing.Size(251, 146);
            this.rtbMorada.TabIndex = 28;
            this.rtbMorada.Text = "";
            // 
            // tbSNS
            // 
            this.tbSNS.Location = new System.Drawing.Point(430, 107);
            this.tbSNS.Name = "tbSNS";
            this.tbSNS.Size = new System.Drawing.Size(232, 20);
            this.tbSNS.TabIndex = 27;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(96, 107);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(246, 20);
            this.tbTelefone.TabIndex = 26;
            // 
            // lbNumTelefone
            // 
            this.lbNumTelefone.AutoSize = true;
            this.lbNumTelefone.Location = new System.Drawing.Point(38, 110);
            this.lbNumTelefone.Name = "lbNumTelefone";
            this.lbNumTelefone.Size = new System.Drawing.Size(52, 13);
            this.lbNumTelefone.TabIndex = 25;
            this.lbNumTelefone.Text = "Telefone:";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Location = new System.Drawing.Point(462, 66);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(200, 20);
            this.dtpDataNasc.TabIndex = 24;
            // 
            // tbbicc
            // 
            this.tbbicc.Location = new System.Drawing.Point(96, 69);
            this.tbbicc.Name = "tbbicc";
            this.tbbicc.Size = new System.Drawing.Size(246, 20);
            this.tbbicc.TabIndex = 23;
            // 
            // tbNomeUtente
            // 
            this.tbNomeUtente.Location = new System.Drawing.Point(96, 33);
            this.tbNomeUtente.Name = "tbNomeUtente";
            this.tbNomeUtente.Size = new System.Drawing.Size(566, 20);
            this.tbNomeUtente.TabIndex = 22;
            // 
            // lbCodigoP
            // 
            this.lbCodigoP.AutoSize = true;
            this.lbCodigoP.Location = new System.Drawing.Point(349, 148);
            this.lbCodigoP.Name = "lbCodigoP";
            this.lbCodigoP.Size = new System.Drawing.Size(75, 13);
            this.lbCodigoP.TabIndex = 21;
            this.lbCodigoP.Text = "Código Postal:";
            // 
            // lbMorada
            // 
            this.lbMorada.AutoSize = true;
            this.lbMorada.Location = new System.Drawing.Point(38, 145);
            this.lbMorada.Name = "lbMorada";
            this.lbMorada.Size = new System.Drawing.Size(46, 13);
            this.lbMorada.TabIndex = 20;
            this.lbMorada.Text = "Morada:";
            // 
            // lbDataNasc
            // 
            this.lbDataNasc.AutoSize = true;
            this.lbDataNasc.Location = new System.Drawing.Point(349, 69);
            this.lbDataNasc.Name = "lbDataNasc";
            this.lbDataNasc.Size = new System.Drawing.Size(107, 13);
            this.lbDataNasc.TabIndex = 19;
            this.lbDataNasc.Text = "Data de Nascimento:";
            // 
            // lbNumSNS
            // 
            this.lbNumSNS.AutoSize = true;
            this.lbNumSNS.Location = new System.Drawing.Point(349, 110);
            this.lbNumSNS.Name = "lbNumSNS";
            this.lbNumSNS.Size = new System.Drawing.Size(32, 13);
            this.lbNumSNS.TabIndex = 18;
            this.lbNumSNS.Text = "SNS:";
            // 
            // lbBICC
            // 
            this.lbBICC.AutoSize = true;
            this.lbBICC.Location = new System.Drawing.Point(38, 72);
            this.lbBICC.Name = "lbBICC";
            this.lbBICC.Size = new System.Drawing.Size(39, 13);
            this.lbBICC.TabIndex = 17;
            this.lbBICC.Text = "BI/CC:";
            // 
            // lbNomeUtente
            // 
            this.lbNomeUtente.AutoSize = true;
            this.lbNomeUtente.Location = new System.Drawing.Point(39, 36);
            this.lbNomeUtente.Name = "lbNomeUtente";
            this.lbNomeUtente.Size = new System.Drawing.Size(38, 13);
            this.lbNomeUtente.TabIndex = 16;
            this.lbNomeUtente.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Médico:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(430, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 21);
            this.comboBox1.TabIndex = 33;
            // 
            // AdicionarUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 387);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardarUtente);
            this.Controls.Add(this.tbCP);
            this.Controls.Add(this.rtbMorada);
            this.Controls.Add(this.tbSNS);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.lbNumTelefone);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.tbbicc);
            this.Controls.Add(this.tbNomeUtente);
            this.Controls.Add(this.lbCodigoP);
            this.Controls.Add(this.lbMorada);
            this.Controls.Add(this.lbDataNasc);
            this.Controls.Add(this.lbNumSNS);
            this.Controls.Add(this.lbBICC);
            this.Controls.Add(this.lbNomeUtente);
            this.Name = "AdicionarUtente";
            this.Text = "Adicionar Utente";
            this.Load += new System.EventHandler(this.AdicionarUtente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGuardarUtente;
        private System.Windows.Forms.TextBox tbCP;
        private System.Windows.Forms.RichTextBox rtbMorada;
        private System.Windows.Forms.TextBox tbSNS;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.Label lbNumTelefone;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.TextBox tbbicc;
        private System.Windows.Forms.TextBox tbNomeUtente;
        private System.Windows.Forms.Label lbCodigoP;
        private System.Windows.Forms.Label lbMorada;
        private System.Windows.Forms.Label lbDataNasc;
        private System.Windows.Forms.Label lbNumSNS;
        private System.Windows.Forms.Label lbBICC;
        private System.Windows.Forms.Label lbNomeUtente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}