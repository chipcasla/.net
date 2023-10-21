using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Foresi.Negocio
{
    public class Validaciones
    {
        public static bool EsMailValido(string mail)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; //segun fuente externa

            if(!(Regex.IsMatch(mail, patron)) || string.IsNullOrWhiteSpace(mail))
            {
                return false;
            }

            return true;
        }
    }
}
