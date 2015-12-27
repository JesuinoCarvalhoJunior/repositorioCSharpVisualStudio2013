using System;
using CursoCSharpModuloII.ADONET.Dominio;

namespace CursoCSharpModuloII.ADONET.Dados
{
    public class ProdutoDao
    {
        public Produto Obter(int id)
        {
            var cmd = DbHelper.CriarComando("SELECT * FROM PRODUTO WHERE ID = " + id.ToString());

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Produto produto = new Produto();
                    produto.Id = Convert.ToInt32(reader["ID"].ToString());
                    produto.CodigoFabricacao = reader["CODIGOFABRICACAO"].ToString();
                    produto.NomeProduto = reader["NOMEPRODUTO"].ToString();
                    produto.Categoria = reader["CATEGORIA"].ToString();
                    produto.Peso =Convert.ToInt32(reader["PESO"].ToString());
                    return produto;}
                else
                {
                    return null;
                }
            }
        }

        public void Salvar(Produto produto)
        {
            //if (produto.Id > 0)
            //{
            //    Editar(produto);
            //}
            //else
            {
                Inserir(produto);}
        }

        private void Inserir(Produto produto)
        {
            var cmd = DbHelper.CriarComando(@"INSERT INTO PRODUTO(CODIGOFABRICACAO,NOMEPRODUTO,CATEGORIA, PESO) 
                    VALUES (@CODIGOFABRICACAO, @NOMEPRODUTO, @CATEGORIA, @PESO)");
            cmd.Parameters.AddWithValue("@CODIGOFABRICACAO", produto.CodigoFabricacao);
            cmd.Parameters.AddWithValue("@NOMEPRODUTO", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@CATEGORIA", produto.Categoria);
            cmd.Parameters.AddWithValue("@PESO", produto.Peso);

            cmd.ExecuteNonQuery();
        }
        //private void Editar(Produto produto)
        //{

        //    var cmd = DbHelper.CriarComando(@"UPDATE CATEGORIA SET Codigo = @Codigo, Descricao = @Descricao Where id= @Id");

        //    cmd.Parameters.AddWithValue("@Codigo", produto.CodigoFabricacao);
        //    cmd.Parameters.AddWithValue("@Descricao", produto.Descricao);
        //    cmd.Parameters.AddWithValue("@Id", produto.Id);
        //    cmd.ExecuteNonQuery();

        //}

        //public void Excluir(int id)
        //{
        //    var cmd = DbHelper.CriarComando(@"DELETE CATEGORIA Where id= @Id");

        //    cmd.Parameters.AddWithValue("@Id", id);
        //    cmd.ExecuteNonQuery();

        //}

    }
}
