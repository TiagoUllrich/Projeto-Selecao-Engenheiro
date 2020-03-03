using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hiper.Cobranca.Negocio
{
    public static class Util
    {
        public static string RemoveCaracterCNPJ(string cnpj)
        {
            cnpj = Regex.Replace(cnpj, @"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]", "");

            return cnpj;
        }

        public static string RemoveCaracterTelefone(string tel)
        {
            tel = Regex.Replace(tel, @"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]", "");

            return tel;
        }

        public static bool ValidaCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = RemoveCaracterCNPJ(cnpj);

            if (cnpj.Length != 14)
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

        public static bool ValidaTelefone(string telefone)
        {            
            if (telefone.Length == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
