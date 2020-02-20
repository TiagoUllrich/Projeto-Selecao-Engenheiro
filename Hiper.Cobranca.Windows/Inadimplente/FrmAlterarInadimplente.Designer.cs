namespace Hiper.Cobranca.Windows.Inadimplente
{
    partial class FrmAlterarInadimplente
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
            this.txtNomeInadimplente = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.lblTelefone1 = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.txtCNPJInadimplente = new System.Windows.Forms.TextBox();
            this.txtTelefone1Inadimplente = new System.Windows.Forms.TextBox();
            this.txtTelefone2Inadimplente = new System.Windows.Forms.TextBox();
            this.btnSalvarInadimplente = new System.Windows.Forms.Button();
            this.btnCancelarInadimplente = new System.Windows.Forms.Button();
            this.lblMensagemErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomeInadimplente
            // 
            this.txtNomeInadimplente.Location = new System.Drawing.Point(12, 38);
            this.txtNomeInadimplente.Name = "txtNomeInadimplente";
            this.txtNomeInadimplente.Size = new System.Drawing.Size(234, 20);
            this.txtNomeInadimplente.TabIndex = 11;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome:";
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone2.Location = new System.Drawing.Point(12, 170);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(115, 13);
            this.lblTelefone2.TabIndex = 13;
            this.lblTelefone2.Text = "Telefone contato 2";
            // 
            // lblTelefone1
            // 
            this.lblTelefone1.AutoSize = true;
            this.lblTelefone1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTelefone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone1.Location = new System.Drawing.Point(12, 120);
            this.lblTelefone1.Name = "lblTelefone1";
            this.lblTelefone1.Size = new System.Drawing.Size(115, 13);
            this.lblTelefone1.TabIndex = 14;
            this.lblTelefone1.Text = "Telefone contato 1";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(12, 70);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(42, 13);
            this.lblCNPJ.TabIndex = 15;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // txtCNPJInadimplente
            // 
            this.txtCNPJInadimplente.Location = new System.Drawing.Point(12, 86);
            this.txtCNPJInadimplente.Name = "txtCNPJInadimplente";
            this.txtCNPJInadimplente.Size = new System.Drawing.Size(234, 20);
            this.txtCNPJInadimplente.TabIndex = 16;
            // 
            // txtTelefone1Inadimplente
            // 
            this.txtTelefone1Inadimplente.Location = new System.Drawing.Point(12, 136);
            this.txtTelefone1Inadimplente.Name = "txtTelefone1Inadimplente";
            this.txtTelefone1Inadimplente.Size = new System.Drawing.Size(234, 20);
            this.txtTelefone1Inadimplente.TabIndex = 17;
            // 
            // txtTelefone2Inadimplente
            // 
            this.txtTelefone2Inadimplente.Location = new System.Drawing.Point(12, 186);
            this.txtTelefone2Inadimplente.Name = "txtTelefone2Inadimplente";
            this.txtTelefone2Inadimplente.Size = new System.Drawing.Size(234, 20);
            this.txtTelefone2Inadimplente.TabIndex = 18;
            // 
            // btnSalvarInadimplente
            // 
            this.btnSalvarInadimplente.Location = new System.Drawing.Point(22, 235);
            this.btnSalvarInadimplente.Name = "btnSalvarInadimplente";
            this.btnSalvarInadimplente.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarInadimplente.TabIndex = 19;
            this.btnSalvarInadimplente.Text = "Salvar";
            this.btnSalvarInadimplente.UseVisualStyleBackColor = true;
            this.btnSalvarInadimplente.Click += new System.EventHandler(this.btnSalvarInadimplente_Click);
            // 
            // btnCancelarInadimplente
            // 
            this.btnCancelarInadimplente.Location = new System.Drawing.Point(161, 235);
            this.btnCancelarInadimplente.Name = "btnCancelarInadimplente";
            this.btnCancelarInadimplente.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarInadimplente.TabIndex = 20;
            this.btnCancelarInadimplente.Text = "Cancelar";
            this.btnCancelarInadimplente.UseVisualStyleBackColor = true;
            this.btnCancelarInadimplente.Click += new System.EventHandler(this.btnCancelarInadimplente_Click);
            // 
            // lblMensagemErro
            // 
            this.lblMensagemErro.AutoSize = true;
            this.lblMensagemErro.ForeColor = System.Drawing.Color.Red;
            this.lblMensagemErro.Location = new System.Drawing.Point(127, 225);
            this.lblMensagemErro.Name = "lblMensagemErro";
            this.lblMensagemErro.Size = new System.Drawing.Size(0, 13);
            this.lblMensagemErro.TabIndex = 21;
            // 
            // FrmAlterarInadimplente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 270);
            this.Controls.Add(this.lblMensagemErro);
            this.Controls.Add(this.btnCancelarInadimplente);
            this.Controls.Add(this.btnSalvarInadimplente);
            this.Controls.Add(this.txtTelefone2Inadimplente);
            this.Controls.Add(this.txtTelefone1Inadimplente);
            this.Controls.Add(this.txtCNPJInadimplente);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblTelefone1);
            this.Controls.Add(this.lblTelefone2);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNomeInadimplente);
            this.Name = "FrmAlterarInadimplente";
            this.Text = "AlterarInadimplente";
            this.Load += new System.EventHandler(this.FrmAlterarInadimplente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeInadimplente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone2;
        private System.Windows.Forms.Label lblTelefone1;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox txtCNPJInadimplente;
        private System.Windows.Forms.TextBox txtTelefone1Inadimplente;
        private System.Windows.Forms.TextBox txtTelefone2Inadimplente;
        private System.Windows.Forms.Button btnSalvarInadimplente;
        private System.Windows.Forms.Button btnCancelarInadimplente;
        private System.Windows.Forms.Label lblMensagemErro;
    }
}