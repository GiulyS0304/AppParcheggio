using System;

namespace Operazioni
{
    public class Gestione
    {
        public static double TariffaB (int ore, double costoTariffa)
        {
            double costoTotale = ore * costoTariffa;
            return costoTotale;
        }

        public static double TariffaC (int ore, double costoTariffa)
        {
            double costoTotale = 0;
            costoTariffa = 1.20;
            if (ore == 1)
            {
                costoTotale = 0;
            }
            else
            {
                costoTotale = ore * costoTariffa;
            }
            return costoTotale;
        }

        public static string TariffaConveniente(int ore)
        {
            string risposta = "";
            if (ore == 24)
            {
                risposta = "TariffaA";

            }
            else if (ore == 1)
            {
                risposta = "TariffaC";
            }
            else if (ore > 1)
            {
                risposta = "TariffaB";
            }
            return risposta;
        }
    }
}
