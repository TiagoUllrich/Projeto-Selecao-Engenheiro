using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hiper.Cobranca.Dados.Context;
using Hiper.Cobranca.Dados.DataObjects;
using Hiper.Cobranca.Dados.Models;


namespace Hiper.Cobranca.Negocio
{
    public class SituacaoBO : IDisposable
    {
        SituacaoDAO situacaoDAO;

        HiperCobrancaContext hiperContext;

        public SituacaoBO()
        {
            this.hiperContext = new HiperCobrancaContext();
            situacaoDAO = new SituacaoDAO(hiperContext);
        }

        public List<Situacao> GetTodasSituacoesNaoExcluidas()
        {
            try
            {
                return situacaoDAO.GetWhere(it => it.Excluido != true).ToList();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public List<Situacao> GetTodasSituacoesExcluidas()
        {
            try
            {
                return situacaoDAO.GetWhere(it => it.Excluido == true).ToList();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public List<Situacao> GetSituacoesPorNome(string nome)
        {
            try
            {

                return situacaoDAO.GetWhere(st => st.Descricao.Contains(nome)).ToList();

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }

        public bool NovaSituacao(Situacao situacao, out Exception exception)
        {
            try
            {
                situacaoDAO.Insert(situacao);

                exception = null;
                return true;
            }
            catch (Exception exc)
            {
                exception= exc;
                return false;
            }
        }


        public bool AlterarSituacao(Situacao situacao, out Exception exception)
        {
            try
            {
                situacaoDAO.UpdatePorEntidade(situacao);

                exception = null;
                return true;
            }
            catch (Exception exc)
            {
                exception = exc;
                return false;
            }
        }

        public bool ExclusaoLogica(long id)
        {
            try
            {
                situacaoDAO.DeleteLogico(id);
                return true;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public Situacao BuscarSituacaoPorId(long ID)
        {
            try
            {
                return this.situacaoDAO.GetById(ID);

            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void Dispose()
        {
            this.situacaoDAO.Dispose();            
        }
    }
}
