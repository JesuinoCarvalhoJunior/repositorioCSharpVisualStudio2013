using System;

namespace PrimeraAplicacaoNHibernate.Util
{
    public class UtilitarioDeData
    {
        private const string FormatoBrasileiro = "{0:MM/dd/yyyy}";

        public static DateTime ConvertaParaBanco(string dataString)
        {
            return Convert.ToDateTime(dataString);
        }

        public static string ConvertaParaFormatoBrasileiro(DateTime data)
        {
            return String.Format(FormatoBrasileiro, data);
        }
    }
}
