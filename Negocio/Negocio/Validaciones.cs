using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Giangiordano.Negocio
{
    public class Validaciones
    {
        public static bool EsHistoricaClinicaValida(int HistClinica)
        {
            string patron = "^(9)([0-9]{4})$";

            if (Regex.IsMatch(HistClinica.ToString(), patron))
            {
                return true;
            }

            return false;
        }
    }
}
