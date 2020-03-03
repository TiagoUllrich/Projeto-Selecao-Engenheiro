using System;
using System.Drawing;
using System.Windows.Forms;
using Hiper.Cobranca.Negocio;
using Hiper.Cobranca.Dados.Models;
using System.Text.RegularExpressions;

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
            this.mskCnpjInadimplente.Text = "";
            this.mskTelefone1.Text = "";
            this.mskTelefone2.Text = "";
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
            string cnpj = Util.RemoveCaracterCNPJ(this.mskCnpjInadimplente.Text);
            string tel1 = Util.RemoveCaracterTelefone(this.mskTelefone1.Text);
            string tel2 = Util.RemoveCaracterTelefone(this.mskTelefone2.Text);

            //Falta tratar mensagem de exceção de quando os campos estiverem incorretos
            if (!String.IsNullOrEmpty(this.txtNomeInadimplente.Text) && 
                !String.IsNullOrEmpty(this.mskCnpjInadimplente.Text) && 
                !String.IsNullOrEmpty(this.mskTelefone1.Text))
                        
            {
                if (objInadimplenteAlterar != null &&
                    Util.ValidaCNPJ(cnpj) &&
                    Util.ValidaTelefone(tel1) &&
                    Util.ValidaTelefone(tel2))
                {
                    objInadimplenteAlterar.Nome = this.txtNomeInadimplente.Text;
                    objInadimplenteAlterar.CNPJ = cnpj;
                    objInadimplenteAlterar.TelefoneParaContato1 = Convert.ToInt32(tel1);
                    objInadimplenteAlterar.TelefoneParaContato2 = Convert.ToInt32(tel2);

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
