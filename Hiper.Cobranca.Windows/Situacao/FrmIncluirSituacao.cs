using System;
using System.Drawing;
using System.Windows.Forms;
using Hiper.Cobranca.Negocio;
using Hiper.Cobranca.Dados.Models;

namespace Hiper.Cobranca.Windows.Situacao
{
    public partial class FrmIncluirSituacao : Form
    {

        SituacaoBO situacaoBO;
        public FrmIncluirSituacao()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtDescricao.Text))
            {
                Cobranca.Dados.Models.Situacao objSalvar = new Dados.Models.Situacao()
                {
                    Descricao = this.txtDescricao.Text,
                    Excluido = false
                };

                Exception exc;
                if (situacaoBO.NovaSituacao(objSalvar, out exc))
                {
                    this.lblMensagemErro.ForeColor = Color.Blue;
                    this.lblMensagemErro.Text = "Salvo com sucesso.";
                    
                    this.Close();
                }else
                {
                    this.lblMensagemErro.ForeColor = Color.Red;
                    this.lblMensagemErro.Text = "Erro ao salvar nova situacao - ERRO:[ " + exc.Message+ "]";
                }
            }
            else
            {
                this.lblMensagemErro.ForeColor = Color.Red;
                this.lblMensagemErro.Text = "Não foi informado nenhuma descrição.";
            }
        }

        private void FrmIncluirSituacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            situacaoBO.Dispose();
        }

        private void FrmIncluirSituacao_Load(object sender, EventArgs e)
        {
            situacaoBO = new SituacaoBO();
            this.lblMensagemErro.Text = "";
            this.txtDescricao.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
