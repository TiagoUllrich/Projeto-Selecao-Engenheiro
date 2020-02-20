using System;
using System.Windows.Forms;
using Hiper.Cobranca.Negocio;

namespace Hiper.Cobranca.Windows.Inadimplente
{
    public partial class FrmInadimplente : Form
    {
        InadimplenteBO inadimplenteBO;

        FrmIncluirInadimplente frmIncluirInadimplente;

        FrmAlterarInadimplente frmAlterarInadimplente;

        public FrmInadimplente()
        {
            InitializeComponent();
        }

        private void FrmIncluirInadimplente_FromClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDadosNoGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDescricaoInadimplente.Text))
            {
                CarregarDadosNoGrid(txtDescricaoInadimplente.Text);
            }
            else
            {
                CarregarDadosNoGrid();
            }
        }

        private void FrmInadimplente_Load(object sender, EventArgs e)
        {
            //carregando formulários acessórios
            frmIncluirInadimplente = new FrmIncluirInadimplente();
            frmIncluirInadimplente.FormClosed += FrmIncluirInadimplente_FromClosed;

            frmAlterarInadimplente = new FrmAlterarInadimplente();
            frmAlterarInadimplente.FormClosed += FrmIncluirInadimplente_FromClosed;

            //carregando objeto de negócio para este form
            inadimplenteBO = new InadimplenteBO();
            CarregarDadosNoGrid();

            this.gridInadimplentes.CellClick += GridInadimplentes_CellClick;
        }        

        private void GridInadimplentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceLinha = e.RowIndex;

            long IdDoInadimplente = (long)this.gridInadimplentes[0, indiceLinha].Value;

            if (e.ColumnIndex == this.gridInadimplentes.Columns["btnAlterar"].Index)
            {
                frmAlterarInadimplente.inadimplenteBO = this.inadimplenteBO;
                frmAlterarInadimplente.IdInadimplenteEditar = IdDoInadimplente;
                frmAlterarInadimplente.ShowDialog();
            }
            else if (e.ColumnIndex == this.gridInadimplentes.Columns["btnExcluir"].Index)
            {
                var confirmResult = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Exclusão de situação.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (confirmResult == DialogResult.Yes)
                {
                    inadimplenteBO.ExclusaoLogica(IdDoInadimplente);
                    CarregarDadosNoGrid();
                }
            }
        }

        private void FrmInadimplente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.inadimplenteBO.Dispose();
        }

        void CarregarDadosNoGrid()
        {
            var lstInadimplente = inadimplenteBO.GetTodosInadimplentesNaoExcluidos();

            this.gridInadimplentes.DataSource = null;
            this.gridInadimplentes.Rows.Clear();
            this.gridInadimplentes.Columns.Clear();
            //configurando datasource
            this.gridInadimplentes.DataSource = lstInadimplente;

            //removendo colunas não necessárias para exibição.
            this.gridInadimplentes.Columns.RemoveAt(3);
            this.gridInadimplentes.Columns.RemoveAt(5);

            //adicionando botão de edição dos dados e exclusão lógica de dados
            DataGridViewButtonColumn btnAlterar = new DataGridViewButtonColumn();

            btnAlterar.HeaderText = "";
            btnAlterar.Text = "Alterar";
            btnAlterar.Name = "btnAlterar";
            btnAlterar.UseColumnTextForButtonValue = true;
            this.gridInadimplentes.Columns.Add(btnAlterar);

            DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();

            btnExcluir.HeaderText = "";
            btnExcluir.Text = "Excluir";
            btnExcluir.Name = "btnExcluir";
            btnExcluir.UseColumnTextForButtonValue = true;
            this.gridInadimplentes.Columns.Add(btnExcluir);

            //ajustando colunas por conteúdo
            this.gridInadimplentes.AutoResizeColumn(0);
            this.gridInadimplentes.AutoResizeColumn(1);
            this.gridInadimplentes.AutoResizeColumn(2);
            this.gridInadimplentes.AutoResizeColumn(3);
            this.gridInadimplentes.AutoResizeColumn(4);
            this.gridInadimplentes.AutoResizeColumn(5);
            this.gridInadimplentes.AutoResizeColumn(6);            
            this.gridInadimplentes.Refresh();
        }

        void CarregarDadosNoGrid(string nomePesquisar)
        {
            var lstInadimplente = inadimplenteBO.GetInadimplentesPorNome(nomePesquisar);

            this.gridInadimplentes.DataSource = null;
            this.gridInadimplentes.Rows.Clear();
            this.gridInadimplentes.Columns.Clear();

            //configurando datasource
            this.gridInadimplentes.DataSource = lstInadimplente;

            //removendo colunas não necessárias para exibição
            this.gridInadimplentes.Columns.RemoveAt(3);
            this.gridInadimplentes.Columns.RemoveAt(5);

            //adicionando botão de edição dos dados e exclusão lógica dos dados
            DataGridViewButtonColumn btnAlterar = new DataGridViewButtonColumn();
            btnAlterar.HeaderText = "";
            btnAlterar.Text = "Alterar";
            btnAlterar.Name = "btnAlterar";
            btnAlterar.UseColumnTextForButtonValue = true;
            this.gridInadimplentes.Columns.Add(btnAlterar);


            DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
            btnExcluir.HeaderText = "";
            btnExcluir.Text = "Excluir";
            btnExcluir.Name = "btnExcluir";
            btnExcluir.UseColumnTextForButtonValue = true;
            this.gridInadimplentes.Columns.Add(btnExcluir);

            //ajustando as colunas por conteudo
            this.gridInadimplentes.AutoResizeColumn(0);
            this.gridInadimplentes.AutoResizeColumn(1);
            this.gridInadimplentes.AutoResizeColumn(2);
            this.gridInadimplentes.AutoResizeColumn(3);
            this.gridInadimplentes.AutoResizeColumn(4);
            this.gridInadimplentes.AutoResizeColumn(5);
            this.gridInadimplentes.AutoResizeColumn(6);            
            this.gridInadimplentes.Refresh();
        }

        private void btnIncluirInadimplente_Click(object sender, EventArgs e)
        {
            frmIncluirInadimplente.ShowDialog();
        }        
    }
}
