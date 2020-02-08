using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Hiper.Cobranca.Dados.Models;

namespace Hiper.Cobranca.Dados.Context
{
    public class HiperCobrancaContext : DbContext
    {
        public HiperCobrancaContext() : base("HiperCobrancaContext")
        {
          
        }

        public DbSet<Situacao> Situacoes { get; set; }

        public DbSet<FollowUpInadimplente> FollowUpsInadimplentes { get; set; }

        public DbSet<Inadimplente> Inadimplentes { get; set; }

        public DbSet<AnalistaFinanceiro> AnalistasFinanceiros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
