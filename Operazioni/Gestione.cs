using System;

namespace Operazioni
{
    public class Gestione
    {
        public static double IncidenzaPercentuale(double n, double tot)
        {
            double incidenza = (n / tot) * 100;
            Math.Round(incidenza, 2);
            return incidenza;
        }
        public static string Esito(double media)
        {
            if (media >= 6)
                return "STUDENTE PROMOSSO";
            return "STUDENTE BOCCIATO";
        }
    }
}
