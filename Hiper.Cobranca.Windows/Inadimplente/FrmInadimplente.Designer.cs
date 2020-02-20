namespace Hiper.Cobranca.Windows.Inadimplente
{
    partial class FrmInadimplente
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricaoInadimplente = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gridInadimplentes = new System.Windows.Forms.DataGridView();
            this.btnIncluirInadimplente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridInadimplentes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(13, 4);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(215, 13);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Pesquise pela descrição da situação";
            // 
            // txtDescricaoInadimplente
            // 
            this.txtDescricaoInadimplente.Location = new System.Drawing.Point(13, 23);
            this.txtDescricaoInadimplente.Name = "txtDescricaoInadimplente";
            this.txtDescricaoInadimplente.Size = new System.Drawing.Size(515, 20);
            this.txtDescricaoInadimplente.TabIndex = 6;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(534, 23);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(104, 21);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // gridInadimplentes
            // 
            this.gridInadimplentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInadimplentes.Location = new System.Drawing.Point(13, 61);
            this.gridInadimplentes.Name = "gridInadimplentes";
            this.gridInadimplentes.Size = new System.Drawing.Size(625, 265);
            this.gridInadimplentes.TabIndex = 8;
            // 
            // btnIncluirInadimplente
            // 
            this.btnIncluirInadimplente.Location = new System.Drawing.Point(13, 344);
            this.btnIncluirInadimplente.Name = "btnIncluirInadimplente";
            this.btnIncluirInadimplente.Size = new System.Drawing.Size(104, 23);
            this.btnIncluirInadimplente.TabIndex = 9;
            this.btnIncluirInadimplente.Text = "Incluir";
            this.btnIncluirInadimplente.UseVisualStyleBackColor = true;
            this.btnIncluirInadimplente.Click += new System.EventHandler(this.btnIncluirInadimplente_Click);
            // 
            // FrmInadimplente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 388);
            this.Controls.Add(this.btnIncluirInadimplente);
            this.Controls.Add(this.gridInadimplentes);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtDescricaoInadimplente);
            this.Controls.Add(this.lblDescricao);
            this.Name = "FrmInadimplente";
            this.Text = "FrmInadimplente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmInadimplente_FormClosed);
            this.Load += new System.EventHandler(this.FrmInadimplente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridInadimplentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricaoInadimplente;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView gridInadimplentes;
        private System.Windows.Forms.Button btnIncluirInadimplente;
    }
}