using System;
using Repositorio.Dominio;
using Repositorio.Contexto;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositorio.Repositorio;

namespace Repositorio.UnidadeTeste
{
    [TestClass]
    public class ClienteUnitTest
    {
        UnitOfWork _unitOfWork = new UnitOfWork();

        [TestMethod]
        public void Adicionar()
        {
            Cliente novoCliente = new Cliente();

            novoCliente.nome = "júnior";
            novoCliente.email = "junior@hotmail.com";
            novoCliente.endereco = "Rua abc";
            novoCliente.bairro = "Centro";
            novoCliente.cidade = "Cuiabá";
            novoCliente.uf = "MT";

            _unitOfWork.ClienteRepositorioBase.Inserir(novoCliente);
        }

        [TestMethod]
        public void Editar()
        {
            Cliente editarCliente = _unitOfWork.ClienteRepositorioBase.Get(x => x.id == 1000)[0];

            editarCliente.nome = "John Doel Gates";
            editarCliente.email = "john.doel.gates@msn.com";
            editarCliente.endereco = "Street: Philadelph 289";

            _unitOfWork.ClienteRepositorioBase.Inserir(editarCliente);
        }

        [TestMethod]
        public void Deletar()
        {
            Cliente deletarCliente = _unitOfWork.ClienteRepositorioBase.Get(x => x.id == 1000)[0];
            _unitOfWork.ClienteRepositorioBase.Deletar(deletarCliente);
        }
    }
}