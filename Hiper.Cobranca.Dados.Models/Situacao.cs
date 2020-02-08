using System;
using System.Collections.Generic;


namespace Hiper.Cobranca.Dados.Models
{
    public class Situacao
    {
        
        public long ID { get; set; }
        public string Descricao { get; set; }

        public bool Excluido { get; set; }

        public virtual ICollection<FollowUpInadimplente> FollowUpInadimplentes { get; set; }
    }
}
