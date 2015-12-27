using CursoCSharpModuloII.ADONET.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloII.ADONET.Dados
{
    public class CategoriaDao
    {
        public Categoria Obter(int id)
        {
            var cmd = DbHelper.CriarComando("SELECT * FROM TBCATEGORIA WHERE ID = " + id.ToString());

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
            var cmd = DbHelper.CriarComando(@"INSERT INTO TBCATEGORIA(Codigo,Descricao) 
                    VALUES (@Codigo, @Descricao)");
            cmd.Parameters.AddWithValue("@Codigo", categoria.Codigo);
            cmd.Parameters.AddWithValue("@Descricao", categoria.Descricao);
            cmd.ExecuteNonQuery();
        }

        private void Editar(Categoria categoria)
        { }

        public void Excluir(int id)
        { }

    }
}
