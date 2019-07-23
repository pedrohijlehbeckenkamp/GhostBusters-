using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GhostBusters_Forms
{
    public static class Validacoes
    {
        public static bool ValidaCamponull(string item)
        {
            string teste = "";
          //  foreach (var item in param)
            //{
                if (item == teste)
                {
                  return true; 
                }
           // }
            return false;
        }
        public static bool ValidaNome(string nome)
        {
            if (!Regex.IsMatch(nome, @"^[ a-zA-Z á]*$"))
            {
                return true;
            }
            return false;
        }
        public static bool ValidaEmail(string email)
        {
            Regex validaEmail = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            if (!validaEmail.IsMatch(email))
            {
                return true;
            }
            return false;
        }
        public static bool ValidaConfirmaEmail(string email, string confirmaEmail)
        {
            if (confirmaEmail != email)
                return true;
            return false;
        }
        public static bool ValidaSenha(string senha, string confirmaSenha)
        {
            if (string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(confirmaSenha)
                || senha != confirmaSenha || senha.Length < 6)
                return true;

           return false;
        }


    }
}
