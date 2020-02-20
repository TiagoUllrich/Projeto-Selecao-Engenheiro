using System;
using System.Drawing;
using System.Windows.Forms;
using Hiper.Cobranca.Negocio;
using Hiper.Cobranca.Dados.Models;

namespace Hiper.Cobranca.Windows.Inadimplente
{
    public partial class FrmIncluirInadimplente : Form
    {
        InadimplenteBO inadimplenteBO;
        public FrmIncluirInadimplente()
        {
            InitializeComponent();
        }

        private void btnSalvarInadimplente_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtNomeInadimplente.Text))
            {
                Cobranca.Dados.Models.Inadimplente objSalvar = new Dados.Models.Inadimplente()
                {
                    Nome = this.txtNomeInadimplente.Text,
                    CNPJ = this.txtCNPJInadimplente.Text,
                    //TelefoneParaContato1 = Convert.ToInt32(this.txtTelefone1Inadimplente.Text),
                    //TelefoneParaContato2 = Convert.ToInt32(this.txtTelefone2Inadimplente.Text),
                    Excluido = false
                };

                Exception exc;
                if (inadimplenteBO.NovoInadimplente(objSalvar, out exc))
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
            else
            {
                this.lblMensagemErro.ForeColor = Color.Red;
                this.lblMensagemErro.Text = "Não foi informado nenhuma descrição.";
            }
        }

        private void FrmIncluirInadimplente_FormCloser(object sender, FormClosedEventArgs e)
        {
            inadimplenteBO.Dispose();
        }

        private void FrmIncluirInadimplente_Load(object sender, EventArgs e)
        {
            inadimplenteBO = new InadimplenteBO();
            this.lblMensagemErro.Text = "";
            this.txtNomeInadimplente.Text = "";            
        }

        private void btnCancelarInadimplente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
