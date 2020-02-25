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
    public class InadimplenteBO : IDisposable
    {
        InadimplenteDAO inadimplenteDAO;

        HiperCobrancaContext hiperContext;

        public InadimplenteBO()
        {
            this.hiperContext = new HiperCobrancaContext();
            inadimplenteDAO = new InadimplenteDAO(hiperContext);
        }

        public List<Inadimplente> GetTodosInadimplentesNaoExcluidos()
        {
            try
            {
                return inadimplenteDAO.GetWhere(it => it.Excluido != true).ToList();
            }
            catch (Exception exc)
            {

                throw exc;
            }
        }

        public List<Inadimplente> GetTodosInadimplentesExcluidos()
        {
            try
            {
                return inadimplenteDAO.GetWhere(it => it.Excluido == true).ToList();
            }
            catch (Exception exc)
            {

                throw exc;
            }
        }     

        public List<Inadimplente> GetInadimplentesPorNome(string nome)
        {
            try
            {
                return inadimplenteDAO.GetWhere(st => st.Nome.Contains(nome)).ToList();
            }
            catch (Exception exc)
            {

                throw exc;
            }
        }

        public List<Inadimplente> GetInadimplentesPorCNPJ(string cnpj)
        {
            try
            {
                return inadimplenteDAO.GetWhere(st => st.CNPJ.Contains(cnpj)).ToList();
            }
            catch (Exception exc)
            {

                throw exc;
            }
        }

        public bool NovoInadimplente(Inadimplente inadimplente, out Exception exception)
        {
            try
            {
                inadimplenteDAO.Insert(inadimplente);
                exception = null;

                return true;
            }
            catch (Exception exc)
            {
                exception = exc;
                return false;
            }
        }

        public bool AlterarInadimplente(Inadimplente inadimplente, out Exception exception)
        {
            try
            {
                inadimplenteDAO.UpdatePorEntidade(inadimplente);
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
                inadimplenteDAO.DeleteLogico(id);
                return true;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public Inadimplente BuscarInadimplentePorId(long ID)
        {
            try
            {
                return this.inadimplenteDAO.GetById(ID);
            }
            catch (Exception exc)
            {

                throw exc;
            }
        }

        public void Dispose()
        {
            this.inadimplenteDAO.Dispose();
        }

        public static bool ValidaCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length !=14)
            {
                return false;
            }

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;

            for (int i = 0; i < 12; i++)
            {
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            }
            resto = (soma % 11);

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
            {
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            }

            resto = (soma % 11);

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }
    }
}
