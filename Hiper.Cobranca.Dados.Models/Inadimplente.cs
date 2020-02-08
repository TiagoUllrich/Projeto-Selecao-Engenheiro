using System;
using System.Collections.Generic;

namespace Hiper.Cobranca.Dados.Models
{
    public class Inadimplente
    {
        public long ID { get; set; }

        public string CNPJ { get; set; } //deve implementar mascara e validação de CNPJ

        public string Nome { get; set; }  //obrigatório

        public bool Excluido { get; set; }


        public int TelefoneParaContato1 { get; set; } //deve implementar mascara para exibição dos dados.

        public int TelefoneParaContato2 { get; set; } //deve implementar mascara para exibição dos dados.

        public virtual ICollection<FollowUpInadimplente> FollowUpInadimplentes { get; set; }

    }
}
