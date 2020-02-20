using System;
using Hiper.Cobranca.Dados.Context;
using Hiper.Cobranca.Dados.Models;
using System.Linq;
using System.Linq.Expressions;

namespace Hiper.Cobranca.Dados.DataObjects
{
    public class InadimplenteDAO  : IDisposable
    {
        HiperCobrancaContext hiperCobrancaContext;

        public InadimplenteDAO(HiperCobrancaContext context)
        {
            if (context != null) hiperCobrancaContext = context;
            else hiperCobrancaContext = new HiperCobrancaContext();
        }

        public void Dispose()
        {
            hiperCobrancaContext.Dispose();
        }

        public Inadimplente Insert(Inadimplente inadimplente)
        {
            try
            {
                Inadimplente inadimplenteAdd = this.hiperCobrancaContext.Inadimplentes.Add(inadimplente);
                hiperCobrancaContext.SaveChanges();

                return inadimplenteAdd;
            }
            catch (Exception exc)
            {

                throw exc;
            }
        }

        public Inadimplente UpdatePorId(Inadimplente inadimplente)
        {
            try
            {
                Inadimplente inadimplenteAtualizar = this.hiperCobrancaContext.Inadimplentes.FirstOrDefault(st => st.ID == inadimplente.ID);

                inadimplenteAtualizar.Nome = inadimplente.Nome;
                inadimplenteAtualizar.CNPJ = inadimplente.CNPJ;
                inadimplenteAtualizar.TelefoneParaContato1 = inadimplente.TelefoneParaContato1;
                inadimplenteAtualizar.TelefoneParaContato2 = inadimplente.TelefoneParaContato2;
                this.hiperCobrancaContext.SaveChanges();

                return inadimplenteAtualizar;

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }

        public Inadimplente UpdatePorEntidade(Inadimplente inadimplente)
        {
            try
            {
                this.hiperCobrancaContext.Entry(inadimplente).State = System.Data.Entity.EntityState.Modified;
                this.hiperCobrancaContext.SaveChanges();

                return inadimplente;
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
                Inadimplente inadimplenteRemover = this.hiperCobrancaContext.Inadimplentes.FirstOrDefault(st => st.ID == ID);
                inadimplenteRemover.Excluido = true;
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
                Inadimplente inadimplenteRemover = this.hiperCobrancaContext.Inadimplentes.FirstOrDefault(st => st.ID == ID);
                this.hiperCobrancaContext.Inadimplentes.Remove(inadimplenteRemover);
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

        public IQueryable<Inadimplente> GetWhere(Expression<Func<Inadimplente,bool>> predicate)
        {
            try
            {
                return this.hiperCobrancaContext.Inadimplentes.Where(predicate);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public Inadimplente GetById(long ID)
        {
            try
            {
                return this.hiperCobrancaContext.Inadimplentes.FirstOrDefault(st => st.ID == ID);
            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
    }
}
