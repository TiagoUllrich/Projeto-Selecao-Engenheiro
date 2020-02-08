using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiper.Cobranca.Dados.Models
{
    public class FollowUpInadimplente
    {
        public long ID { get; set; }

        public DateTime DataHora { get; set; }

        public string AcaoEfetuada{ get; set; }

        public bool Excluido { get; set; }


        public virtual Situacao SituacaoAgendamento { get; set;}

        public virtual Inadimplente Devedor { get; set; }

        public virtual AnalistaFinanceiro Cobrador { get; set; }
    }
}
