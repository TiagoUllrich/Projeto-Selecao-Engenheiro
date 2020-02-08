using System;
using System.Windows.Forms;
using Hiper.Cobranca.Negocio;

namespace Hiper.Cobranca.Windows.Situacao
{
    public partial class FrmSituacao : Form
    {
        SituacaoBO situacaoBO;

        FrmIncluirSituacao frmIncluirSituacao;

        FrmAlterarSituacao frmAlterarSituacao;
        public FrmSituacao()
        {
            InitializeComponent();


        }

        private void FrmIncluirSituacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDadosNoGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDescricaoSituacao.Text))
            {
                CarregarDadosNoGrid(txtDescricaoSituacao.Text);
            }
            else
            {
                CarregarDadosNoGrid();
            }
        }

        private void FrmSituacao_Load(object sender, EventArgs e)
        {
            //carregando formulários acessórios
            frmIncluirSituacao = new FrmIncluirSituacao();
            frmIncluirSituacao.FormClosed += FrmIncluirSituacao_FormClosed;

            frmAlterarSituacao = new FrmAlterarSituacao();
            frmAlterarSituacao.FormClosed += FrmIncluirSituacao_FormClosed;

            //carregando objeto de negócio para este form
            situacaoBO = new SituacaoBO();
            CarregarDadosNoGrid();

            this.gridSituacoes.CellClick += GridSituacoes_CellClick;
        }

        private void GridSituacoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceLinha = e.RowIndex;

            long IdDaSituacao = (long)this.gridSituacoes[0, indiceLinha].Value;

            if (e.ColumnIndex == this.gridSituacoes.Columns["btnAlterar"].Index)
            {
                frmAlterarSituacao.situacaoBO = this.situacaoBO;
                frmAlterarSituacao.IdSituacaoEditar = IdDaSituacao;
                frmAlterarSituacao.ShowDialog();
            }
            else if(e.ColumnIndex == this.gridSituacoes.Columns["btnExcluir"].Index)
            {
                var confirmResult = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Exclusão de situação.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if(confirmResult == DialogResult.Yes)
                {
                    situacaoBO.ExclusaoLogica(IdDaSituacao);
                    CarregarDadosNoGrid();
                }                
            }
        }

        private void FrmSituacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.situacaoBO.Dispose();
        }

        void CarregarDadosNoGrid()
        {
            var lstSituacao = situacaoBO.GetTodasSituacoesNaoExcluidas();

            this.gridSituacoes.DataSource = null;
            this.gridSituacoes.Rows.Clear();
            this.gridSituacoes.Columns.Clear();
            //configurando datasource
            this.gridSituacoes.DataSource = lstSituacao;

            //removendo colunas não necessárias para exibição.
            this.gridSituacoes.Columns.RemoveAt(3);
            this.gridSituacoes.Columns.RemoveAt(2);

            //adicionando botão de edição dos dados e exclusão lógica dos dados
            DataGridViewButtonColumn btnAlterar = new DataGridViewButtonColumn();
        
            btnAlterar.HeaderText = "";
            btnAlterar.Text = "Alterar";
            btnAlterar.Name = "btnAlterar";
            btnAlterar.UseColumnTextForButtonValue = true;
            this.gridSituacoes.Columns.Add(btnAlterar);

       
            DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();

            btnExcluir.HeaderText = "";
            btnExcluir.Text = "Excluir";
            btnExcluir.Name = "btnExcluir";
            btnExcluir.UseColumnTextForButtonValue = true;
            this.gridSituacoes.Columns.Add(btnExcluir);

            //ajustando as colunas por conteudo
            this.gridSituacoes.AutoResizeColumn(0);
            this.gridSituacoes.AutoResizeColumn(1);
            this.gridSituacoes.AutoResizeColumn(2);
            this.gridSituacoes.AutoResizeColumn(3);
            this.gridSituacoes.Refresh();
        }

        void CarregarDadosNoGrid(string nomePesquisar)
        {
            var lstSituacao = situacaoBO.GetSituacoesPorNome(nomePesquisar);

            this.gridSituacoes.DataSource = null;
            this.gridSituacoes.Rows.Clear();
            this.gridSituacoes.Columns.Clear();

            //configurando datasource
            this.gridSituacoes.DataSource = lstSituacao;

            //removendo colunas não necessárias para exibição.
            this.gridSituacoes.Columns.RemoveAt(3);
            this.gridSituacoes.Columns.RemoveAt(2);

            //adicionando botão de edição dos dados e exclusão lógica dos dados
            DataGridViewButtonColumn btnAlterar = new DataGridViewButtonColumn();
            btnAlterar.HeaderText = "";
            btnAlterar.Text = "Alterar";
            btnAlterar.Name = "btnAlterar";
            btnAlterar.UseColumnTextForButtonValue = true;
            this.gridSituacoes.Columns.Add(btnAlterar);


            DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
            btnExcluir.HeaderText = "";
            btnExcluir.Text = "Excluir";
            btnExcluir.Name = "btnExcluir";
            btnExcluir.UseColumnTextForButtonValue = true;
            this.gridSituacoes.Columns.Add(btnExcluir);

            //ajustando as colunas por conteudo
            this.gridSituacoes.AutoResizeColumn(0);
            this.gridSituacoes.AutoResizeColumn(1);
            this.gridSituacoes.AutoResizeColumn(2);
            this.gridSituacoes.AutoResizeColumn(3);
            this.gridSituacoes.Refresh();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
                 
            frmIncluirSituacao.ShowDialog();
        }
    }
}
