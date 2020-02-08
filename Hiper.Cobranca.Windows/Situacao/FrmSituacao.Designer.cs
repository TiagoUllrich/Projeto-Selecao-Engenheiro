namespace Hiper.Cobranca.Windows.Situacao
{
    partial class FrmSituacao
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
            this.txtDescricaoSituacao = new System.Windows.Forms.TextBox();
            this.gridSituacoes = new System.Windows.Forms.DataGridView();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSituacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescricaoSituacao
            // 
            this.txtDescricaoSituacao.Location = new System.Drawing.Point(13, 23);
            this.txtDescricaoSituacao.Name = "txtDescricaoSituacao";
            this.txtDescricaoSituacao.Size = new System.Drawing.Size(435, 20);
            this.txtDescricaoSituacao.TabIndex = 0;
            // 
            // gridSituacoes
            // 
            this.gridSituacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSituacoes.Location = new System.Drawing.Point(13, 61);
            this.gridSituacoes.Name = "gridSituacoes";
            this.gridSituacoes.Size = new System.Drawing.Size(545, 265);
            this.gridSituacoes.TabIndex = 3;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(13, 344);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(104, 23);
            this.btnIncluir.TabIndex = 3;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(454, 23);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(104, 21);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(13, 4);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(215, 13);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Pesquise pela descrição da situação";
            // 
            // FrmSituacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 388);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.gridSituacoes);
            this.Controls.Add(this.txtDescricaoSituacao);
            this.Name = "FrmSituacao";
            this.Text = "Situações";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSituacao_FormClosed);
            this.Load += new System.EventHandler(this.FrmSituacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSituacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricaoSituacao;
        private System.Windows.Forms.DataGridView gridSituacoes;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblDescricao;
    }
}