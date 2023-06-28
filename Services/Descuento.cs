using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU123AMTaynaPech.Services
{
    public class Descuento
    {
        public int MenorMil(int TotalCompra)
        {
            int Envio = 250;
            if (TotalCompra<1000)
            {
                TotalCompra = TotalCompra + Envio;
            }
            return TotalCompra;
        }
        public int MayorMil(int TotalCompra)
        {
            int SITMeses = 0;
            if (TotalCompra >= 1000)
            {
                 SITMeses = TotalCompra / 3;         //cuanto pagara mensualmente 
            }
            return SITMeses;
        }


    }
}
