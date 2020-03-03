namespace Hiper.Cobranca.Windows.Inadimplente
{
    partial class FrmIncluirInadimplente
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
            this.lblMensagemErro = new System.Windows.Forms.Label();
            this.btnCancelarInadimplente = new System.Windows.Forms.Button();
            this.btnSalvarInadimplente = new System.Windows.Forms.Button();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblTelefone1 = new System.Windows.Forms.Label();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeInadimplente = new System.Windows.Forms.TextBox();
            this.mskCnpjInadimplente = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblMensagemErro
            // 
            this.lblMensagemErro.AutoSize = true;
            this.lblMensagemErro.ForeColor = System.Drawing.Color.Red;
            this.lblMensagemErro.Location = new System.Drawing.Point(128, 220);
            this.lblMensagemErro.Name = "lblMensagemErro";
            this.lblMensagemErro.Size = new System.Drawing.Size(0, 13);
            this.lblMensagemErro.TabIndex = 32;
            // 
            // btnCancelarInadimplente
            // 
            this.btnCancelarInadimplente.Location = new System.Drawing.Point(114, 230);
            this.btnCancelarInadimplente.Name = "btnCancelarInadimplente";
            this.btnCancelarInadimplente.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarInadimplente.TabIndex = 31;
            this.btnCancelarInadimplente.Text = "Cancelar";
            this.btnCancelarInadimplente.UseVisualStyleBackColor = true;
            this.btnCancelarInadimplente.Click += new System.EventHandler(this.btnCancelarInadimplente_Click);
            // 
            // btnSalvarInadimplente
            // 
            this.btnSalvarInadimplente.Location = new System.Drawing.Point(14, 230);
            this.btnSalvarInadimplente.Name = "btnSalvarInadimplente";
            this.btnSalvarInadimplente.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarInadimplente.TabIndex = 30;
            this.btnSalvarInadimplente.Text = "Salvar";
            this.btnSalvarInadimplente.UseVisualStyleBackColor = true;
            this.btnSalvarInadimplente.Click += new System.EventHandler(this.btnSalvarInadimplente_Click);
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(13, 65);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(42, 13);
            this.lblCNPJ.TabIndex = 26;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // lblTelefone1
            // 
            this.lblTelefone1.AutoSize = true;
            this.lblTelefone1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTelefone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone1.Location = new System.Drawing.Point(13, 115);
            this.lblTelefone1.Name = "lblTelefone1";
            this.lblTelefone1.Size = new System.Drawing.Size(115, 13);
            this.lblTelefone1.TabIndex = 25;
            this.lblTelefone1.Text = "Telefone contato 1";
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone2.Location = new System.Drawing.Point(13, 165);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(115, 13);
            this.lblTelefone2.TabIndex = 24;
            this.lblTelefone2.Text = "Telefone contato 2";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(13, 17);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 23;
            this.lblNome.Text = "Nome:";
            // 
            // txtNomeInadimplente
            // 
            this.txtNomeInadimplente.Location = new System.Drawing.Point(12, 38);
            this.txtNomeInadimplente.Name = "txtNomeInadimplente";
            this.txtNomeInadimplente.Size = new System.Drawing.Size(105, 20);
            this.txtNomeInadimplente.TabIndex = 22;
            // 
            // mskCnpjInadimplente
            // 
            this.mskCnpjInadimplente.BeepOnError = true;
            this.mskCnpjInadimplente.Location = new System.Drawing.Point(13, 81);
            this.mskCnpjInadimplente.Mask = "00.000.000/0000-00";
            this.mskCnpjInadimplente.Name = "mskCnpjInadimplente";
            this.mskCnpjInadimplente.Size = new System.Drawing.Size(105, 20);
            this.mskCnpjInadimplente.TabIndex = 33;
            // 
            // mskTelefone1
            // 
            this.mskTelefone1.Location = new System.Drawing.Point(13, 131);
            this.mskTelefone1.Mask = "0000-0000";
            this.mskTelefone1.Name = "mskTelefone1";
            this.mskTelefone1.Size = new System.Drawing.Size(62, 20);
            this.mskTelefone1.TabIndex = 34;
            // 
            // mskTelefone2
            // 
            this.mskTelefone2.Location = new System.Drawing.Point(13, 181);
            this.mskTelefone2.Mask = "0000-0000";
            this.mskTelefone2.Name = "mskTelefone2";
            this.mskTelefone2.Size = new System.Drawing.Size(62, 20);
            this.mskTelefone2.TabIndex = 35;
            // 
            // FrmIncluirInadimplente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 270);
            this.Controls.Add(this.mskTelefone2);
            this.Controls.Add(this.mskTelefone1);
            this.Controls.Add(this.mskCnpjInadimplente);
            this.Controls.Add(this.lblMensagemErro);
            this.Controls.Add(this.btnCancelarInadimplente);
            this.Controls.Add(this.btnSalvarInadimplente);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblTelefone1);
            this.Controls.Add(this.lblTelefone2);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNomeInadimplente);
            this.Name = "FrmIncluirInadimplente";
            this.Text = "FrmIncluirInadimplente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIncluirInadimplente_FormCloser);
            this.Load += new System.EventHandler(this.FrmIncluirInadimplente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagemErro;
        private System.Windows.Forms.Button btnCancelarInadimplente;
        private System.Windows.Forms.Button btnSalvarInadimplente;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblTelefone1;
        private System.Windows.Forms.Label lblTelefone2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeInadimplente;
        private System.Windows.Forms.MaskedTextBox mskCnpjInadimplente;
        private System.Windows.Forms.MaskedTextBox mskTelefone1;
        private System.Windows.Forms.MaskedTextBox mskTelefone2;
    }
}