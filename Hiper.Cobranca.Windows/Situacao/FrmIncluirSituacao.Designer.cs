namespace Hiper.Cobranca.Windows.Situacao
{
    partial class FrmIncluirSituacao
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblMensagemErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(22, 86);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(161, 86);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(14, 35);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(234, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(12, 19);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(68, 13);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblMensagemErro
            // 
            this.lblMensagemErro.AutoSize = true;
            this.lblMensagemErro.ForeColor = System.Drawing.Color.Red;
            this.lblMensagemErro.Location = new System.Drawing.Point(22, 62);
            this.lblMensagemErro.Name = "lblMensagemErro";
            this.lblMensagemErro.Size = new System.Drawing.Size(0, 13);
            this.lblMensagemErro.TabIndex = 6;
            // 
            // FrmIncluirSituacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 121);
            this.Controls.Add(this.lblMensagemErro);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FrmIncluirSituacao";
            this.Text = "Incluir Situação";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIncluirSituacao_FormClosed);
            this.Load += new System.EventHandler(this.FrmIncluirSituacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblMensagemErro;
    }
}