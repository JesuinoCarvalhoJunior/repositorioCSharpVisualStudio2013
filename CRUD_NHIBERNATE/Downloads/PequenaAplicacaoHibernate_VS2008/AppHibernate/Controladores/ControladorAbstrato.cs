using System.Collections.Generic;

namespace PrimeraAplicacaoNHibernate.Controladores
{
    public class ControladorAbstrato
    {
        protected static string[] ObtenhaArrayDeErros(IList<string> listaDeErros)
        {
            var array = new string[listaDeErros.Count];

            for (var i = 0; i < listaDeErros.Count; i++)
                array[i] = listaDeErros[i];

            return array;
        }
    }
}