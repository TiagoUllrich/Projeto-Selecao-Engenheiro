using System;
using System.Drawing;
using System.Windows.Forms;
using Hiper.Cobranca.Negocio;

namespace Hiper.Cobranca.Windows.Inadimplente
{
    public partial class FrmAlterarInadimplente : Form
    {
        public InadimplenteBO inadimplenteBO;

        Dados.Models.Inadimplente objInadimplenteAlterar;

        public long? IdInadimplenteEditar = null;
        
        public FrmAlterarInadimplente()
        {
            InitializeComponent();
        }

        private void FrmAlterarInadimplente_Load(object sender, EventArgs e)
        {
            this.lblMensagemErro.Text = "";
            this.txtNomeInadimplente.Text = "";
            if (IdInadimplenteEditar.HasValue)
            {
                objInadimplenteAlterar = inadimplenteBO.BuscarInadimplentePorId(IdInadimplenteEditar.Value);
                if (objInadimplenteAlterar != null) this.txtNomeInadimplente.Text = objInadimplenteAlterar.Nome;
            }
            else
            {
                this.Close();
            }
        }        

        private void btnCancelarInadimplente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarInadimplente_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtNomeInadimplente.Text) && 
                !String.IsNullOrEmpty(this.txtCNPJInadimplente.Text) && 
                !String.IsNullOrEmpty(this.txtTelefone1Inadimplente.Text))
                        
            {
                if (objInadimplenteAlterar != null)
                {
                    objInadimplenteAlterar.Nome = this.txtNomeInadimplente.Text;
                    objInadimplenteAlterar.CNPJ = this.txtCNPJInadimplente.Text;
                    objInadimplenteAlterar.TelefoneParaContato1 = Convert.ToInt32(this.txtTelefone1Inadimplente.Text);
                    Exception exc;
                    if (inadimplenteBO.AlterarInadimplente(objInadimplenteAlterar, out exc))
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
