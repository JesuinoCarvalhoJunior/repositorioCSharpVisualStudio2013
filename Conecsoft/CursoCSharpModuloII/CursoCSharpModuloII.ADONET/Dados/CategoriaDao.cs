using System;
using CursoCSharpModuloII.ADONET.Dominio;

namespace CursoCSharpModuloII.ADONET.Dados
{
    public class CategoriaDao
    {
        public Categoria Obter(int id)
        {
            var cmd = DbHelper.CriarComando("SELECT * FROM CATEGORIA WHERE ID = " + id.ToString());

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = Convert.ToInt32(reader["ID"].ToString());
                    categoria.Codigo = reader["CODIGO"].ToString();
                    categoria.Descricao = reader["DESCRICAO"].ToString();
                    return categoria;
                }
                else
                {
                    return null;
                }
            }
        }

        public void Salvar(Categoria categoria)
        {
            if (categoria.Id > 0)
            {
                Editar(categoria);
            }
            else
            {
                Inserir(categoria);
            }
        }

        private void Inserir(Categoria categoria)
        {
            var cmd = DbHelper.CriarComando(@"INSERT INTO CATEGORIA(Codigo,Descricao) 
                                               VALUES (@Codigo, @Descricao)");
            cmd.Parameters.AddWithValue("@Codigo", categoria.Codigo);
            cmd.Parameters.AddWithValue("@Descricao", categoria.Descricao);
            cmd.ExecuteNonQuery();
        }

        private void Editar(Categoria categoria)
        {

            var cmd = DbHelper.CriarComando(@"UPDATE CATEGORIA SET Codigo = @Codigo, Descricao = @Descricao Where id= @Id");

            cmd.Parameters.AddWithValue("@Codigo", categoria.Codigo);
            cmd.Parameters.AddWithValue("@Descricao", categoria.Descricao);
            cmd.Parameters.AddWithValue("@Id", categoria.Id);
            cmd.ExecuteNonQuery();

        }

        public void Excluir(int id)
        {
            var cmd = DbHelper.CriarComando(@"DELETE CATEGORIA Where id= @Id");

            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();

        }

    }
}
