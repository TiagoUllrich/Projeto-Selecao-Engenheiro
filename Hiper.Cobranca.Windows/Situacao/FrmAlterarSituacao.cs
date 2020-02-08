using System;
using System.Drawing;
using System.Windows.Forms;
using Hiper.Cobranca.Negocio;


namespace Hiper.Cobranca.Windows.Situacao
{
    public partial class FrmAlterarSituacao : Form
    {
        public SituacaoBO situacaoBO;

        Dados.Models.Situacao objSituacaoAlterar;

        public long? IdSituacaoEditar = null;

        public FrmAlterarSituacao()
        {
            InitializeComponent();
        }

        private void FrmAlterarSituacao_Load(object sender, EventArgs e)
        {
            this.lblMensagemErro.Text = "";
            this.txtDescricao.Text = "";
            if (IdSituacaoEditar.HasValue)
            {
                objSituacaoAlterar = situacaoBO.BuscarSituacaoPorId(IdSituacaoEditar.Value);
                if (objSituacaoAlterar != null) this.txtDescricao.Text = objSituacaoAlterar.Descricao;
            }
            else
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtDescricao.Text))
            {
                if (objSituacaoAlterar != null)
                {
                    objSituacaoAlterar.Descricao = this.txtDescricao.Text;
                    Exception exc;
                    if (situacaoBO.AlterarSituacao(objSituacaoAlterar, out exc))
                    {
                        this.lblMensagemErro.ForeColor = Color.Blue;
                        this.lblMensagemErro.Text = "Salvo com sucesso.";
                        this.Close();
                    }
                    else
                    {
                        this.lblMensagemErro.ForeColor = Color.Red;
                        this.lblMensagemErro.Text = "Erro ao salvar nova situacao - ERRO:[ " + exc.Message + "]";
                    }
                }
            }
            else
            {
                this.lblMensagemErro.ForeColor = Color.Red;
                this.lblMensagemErro.Text = "Não foi informado nenhuma descrição.";
            }
        }
    }
}
