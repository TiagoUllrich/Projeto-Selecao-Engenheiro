using System;
using Hiper.Cobranca.Dados.Context;
using Hiper.Cobranca.Dados.Models;
using System.Linq;
using System.Linq.Expressions;

namespace Hiper.Cobranca.Dados.DataObjects
{
    public class SituacaoDAO : IDisposable
    {
        HiperCobrancaContext hiperCobrancaContext;

        public SituacaoDAO(HiperCobrancaContext context)
        {
            if (context != null) hiperCobrancaContext = context;
            else hiperCobrancaContext = new HiperCobrancaContext(); //teste
        }

        public void Dispose()
        {
            hiperCobrancaContext.Dispose();
        }

        public Situacao Insert(Situacao situacao)
        {
            try
            {
                Situacao situacaoAdd = this.hiperCobrancaContext.Situacoes.Add(situacao);
                hiperCobrancaContext.SaveChanges();

                return situacaoAdd;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public Situacao UpdatePorId(Situacao situacao)
        {
            try
            {
                Situacao situacaoAtualizar = this.hiperCobrancaContext.Situacoes.FirstOrDefault(st => st.ID == situacao.ID);
                situacaoAtualizar.Descricao = situacao.Descricao;
                this.hiperCobrancaContext.SaveChanges();

                return situacaoAtualizar;

            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public Situacao UpdatePorEntidade(Situacao situacao)
        {
            try
            {
                this.hiperCobrancaContext.Entry(situacao).State = System.Data.Entity.EntityState.Modified;
                this.hiperCobrancaContext.SaveChanges();

                return situacao;

            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public bool DeleteLogico(long ID)
        {
            try
            {
                Situacao situacaoRemover = this.hiperCobrancaContext.Situacoes.FirstOrDefault(st => st.ID == ID);
                situacaoRemover.Excluido = true;                
                this.hiperCobrancaContext.SaveChanges();

                return true;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public bool Delete(long ID, out Exception e)
        {
            try
            {
                Situacao situacaoRemover = this.hiperCobrancaContext.Situacoes.FirstOrDefault(st => st.ID == ID);
                this.hiperCobrancaContext.Situacoes.Remove(situacaoRemover);
                this.hiperCobrancaContext.SaveChanges();
                e = null;
                return true;
            }
            catch (Exception exc)
            {
                e = exc;
                return false;
            }
        }

        public IQueryable<Situacao> GetAll()
        {
            try
            {
                return this.hiperCobrancaContext.Situacoes.AsQueryable();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public IQueryable<Situacao> GetWhere(Expression<Func<Situacao,bool>> predicate)
        {
            try
            {
                return this.hiperCobrancaContext.Situacoes.Where(predicate);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public Situacao GetById(long ID)
        {
            try
            {
                return this.hiperCobrancaContext.Situacoes.FirstOrDefault(st => st.ID == ID);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}
