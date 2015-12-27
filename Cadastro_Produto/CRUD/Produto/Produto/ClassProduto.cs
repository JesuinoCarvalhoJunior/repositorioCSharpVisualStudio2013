using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Produto
{
    public class ClassProduto
    {
        private int _Id;
        private string _Descricao;
        private decimal _Preco;
        private int _Original_Id;
        private string _Original_Descricao;
        private decimal _Original_Preco;

        private string junior;


        public int Original_Id
        {
            get { return _Original_Id; }
            set { _Original_Id = value; }
        }

        public decimal Original_Preco
        {
            get { return _Original_Preco; }
            set { _Original_Preco = value; }
        }

        public string Origina_Descricao
        {
            get { return _Original_Descricao; }
            set { _Original_Descricao = value; }
        }

        public decimal Preco
        {
            get { return _Preco; }
            set { _Preco = value; }
        }

        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value; }
        }

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        // alterar produto
        public void Alterar()
        {
            DS_PRODUTOTableAdapters.ProdutoTableAdapter
            Produtos = new DS_PRODUTOTableAdapters.ProdutoTableAdapter();
            Produtos.Update(_Id);
        }

        // criar novo produto
        public void Incluir()
        {
            DS_PRODUTOTableAdapters.ProdutoTableAdapter
               Produtos = new DS_PRODUTOTableAdapters.ProdutoTableAdapter();
            Produtos.Insert(_Id, _Descricao, _Preco);
        }

        // excluir produto
        public void Excluir()
        {
            DS_PRODUTOTableAdapters.ProdutoTableAdapter
              Produtos = new DS_PRODUTOTableAdapters.ProdutoTableAdapter();
            Produtos.Delete(_Id, _Descricao, _Preco);
        }

      //  public DataTable ObterProduto(int Id_Produto)
      //  {
      //      DS_PRODUTOTableAdapters.ProdutoTableAdapter
      //          Produto = new DS_PRODUTOTableAdapters.ProdutoTableAdapter();
       //     Produto.ObterProdutoId(Id_Produto);
       // }
    //
        // retorna produtos com base na inicial da descricao
        public DataTable ObterProduto(string Descricao)
        {

            DS_PRODUTOTableAdapters.ProdutoTableAdapter
            Produtos = new DS_PRODUTOTableAdapters.ProdutoTableAdapter();
            return Produtos.ObterProdutoDescricao(Descricao);


        }
    }
}
