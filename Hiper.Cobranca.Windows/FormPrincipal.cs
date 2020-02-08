using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hiper.Cobranca.Windows.Situacao;

namespace Hiper.Cobranca.Windows
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void situaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSituacao frmSituacao = new FrmSituacao();
            frmSituacao.ShowDialog();
        }
    }
}
