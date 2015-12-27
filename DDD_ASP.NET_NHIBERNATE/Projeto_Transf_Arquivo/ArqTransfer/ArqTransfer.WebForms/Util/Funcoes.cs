using System;
using System.Collections.Generic;

namespace ArqTransfer.WebForms.Util
{
    public class Funcoes
    {
        public static string TrataMensagens(IList<string> mensagens)
        {
            string retorno = "";
            foreach (var msg in mensagens)
                retorno = "<li>" + msg.Trim() + Environment.NewLine;
            return retorno;
        }
    }
}
