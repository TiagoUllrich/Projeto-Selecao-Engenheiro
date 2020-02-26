using System;
using System.Drawing;
using System.Windows.Forms;
using Hiper.Cobranca.Negocio;
using Hiper.Cobranca.Dados.Models;
using System.Text.RegularExpressions;

namespace Hiper.Cobranca.Windows.Inadimplente
{
    public partial class FrmIncluirInadimplente : Form
    {
        InadimplenteBO inadimplenteBO = new InadimplenteBO();
        public FrmIncluirInadimplente()
        {
            InitializeComponent();
        }

        private void btnSalvarInadimplente_Click(object sender, EventArgs e)
        {
            //string cnpj = this.mskCNPJInadimplente.Text;
            //Util.RemoveCaracterCNPJ(cnpj);
            string cnpj = Regex.Replace(this.mskCNPJInadimplente.Text, @"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]", "");

            if (!String.IsNullOrEmpty(this.txtNomeInadimplente.Text))
            {
                if (Util.ValidaCNPJ(cnpj))
                {
                    Cobranca.Dados.Models.Inadimplente objSalvar = new Dados.Models.Inadimplente()
                    {
                        Nome = this.txtNomeInadimplente.Text,                        
                        CNPJ = cnpj,
                        TelefoneParaContato1 = int.Parse(this.txtTelefone1Inadimplente.Text),
                        TelefoneParaContato2 = int.Parse(this.txtTelefone2Inadimplente.Text),
                        Excluido = false
                    };

                    Exception exc;
                    if (inadimplenteBO.NovoInadimplente(objSalvar, out exc))
                    {
                        MessageBox.Show("Salvo com sucesso.");

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao salvar nova situacao - ERRO:[ " + exc.Message + "]");
                    }

                    
                }
                else
                {
                    MessageBox.Show(cnpj);
                }
                
            }
            else
            {
                MessageBox.Show("Não foi informado nenhuma descrição.");
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
            this.mskCNPJInadimplente.Text = "";
            this.txtTelefone1Inadimplente.Text = "";
            this.txtTelefone2Inadimplente.Text = "";
        }

        private void btnCancelarInadimplente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
