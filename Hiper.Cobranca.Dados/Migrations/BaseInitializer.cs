using System.Data.Entity;
using Hiper.Cobranca.Dados.Context;
using Hiper.Cobranca.Dados.Models;
using System.Collections.Generic;
using System;

namespace Hiper.Cobranca.Dados.Migrations
{
    public class BaseInitializer : DropCreateDatabaseIfModelChanges<HiperCobrancaContext>, IDisposable

    {
        public void Dispose()
        {
           
        }

        protected override void Seed(HiperCobrancaContext context)
        {
            try
            {
                //adicionando as situações padrão
                var SituacoesAdicionar = new List<Situacao>()
                {
					new Situacao{ ID=1 , Descricao ="Agendado" },
					new Situacao{ ID=2 , Descricao ="Negociação em andamento" },
					new Situacao{ ID=3 , Descricao ="Não houve retorno" },
					new Situacao{ ID=4 , Descricao ="Processo finalizado" }
				};

                context.Situacoes.AddRange(SituacoesAdicionar);
                context.SaveChanges();
            }
            catch (System.Exception exc)
            {

                throw exc;
            }


        }
    }
}
