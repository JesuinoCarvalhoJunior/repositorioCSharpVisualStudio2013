using System;

namespace CursoCSharpModuloII.ADONET
{
    public static class RetornaProximoCodigoHelper
    {
        private static int codigoRetornado = 0;
        public static int RetornaProximoCodigo()
        {
            var cmd = DbHelper.CriarComando(@"SELECT MAX(ID) FROM Categoria");

            DbHelper.AbrirConexao();

            var codigoRetornado = Convert.ToInt32(cmd.ExecuteScalar());

            return codigoRetornado + 1;
        }

    }
}
