using System;
using System.Windows.Forms;

namespace CursoCSharpModuloII.ADONET
{
    public static class SomenteNumerosHelper
    {

        public static void SomenteNumeros(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }}
    }
}
