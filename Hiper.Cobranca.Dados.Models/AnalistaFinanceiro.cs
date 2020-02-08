using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiper.Cobranca.Dados.Models
{
    public class AnalistaFinanceiro
    {
        public long ID { get; set; }

        public string CPF { get; set; } //deve implementar mascara e validação de CPF

        public string Nome { get; set; } 

        public string Email { get; set; } //deve validar mascara de e-mail e salvar somente com a mascara correta. Implementar REGEX ao setar o dado

        public string Login { get; set; }

        public string Senha { get; set; }

        public bool Excluido { get; set; }


        public virtual ICollection<FollowUpInadimplente> FollowUpInadimplentes { get; set; }

    }
}
