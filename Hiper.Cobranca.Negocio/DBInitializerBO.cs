using Hiper.Cobranca.Dados.Migrations;
using Hiper.Cobranca.Dados.Context;
using System;

namespace Hiper.Cobranca.Negocio
{
    public class DBInitializerBO : IDisposable

    {
        public void Dispose()
        {
            
        }

        public void InitializeBD()
        {
            using (HiperCobrancaContext hiperCobrancaContext = new HiperCobrancaContext())
            {
                BaseInitializer baseInitializer = new BaseInitializer();
                baseInitializer.InitializeDatabase(hiperCobrancaContext);
            }
        }
    }
}
