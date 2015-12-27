using System.Collections.Generic;
using System.Linq;
using PROJETOMODELODDD.DOMINIO.Entidades;
using PROJETOMODELODDD.DOMINIO.Interfaces.Repositorios;
using PROJETOMODELODDD.DOMINIO.Interfaces.Servicos;

namespace PROJETOMODELODDD.DOMINIO.Servicos
{
    // classe de servico especilizada
    public class ClienteServico : ServicoBase<Cliente>, IClienteServico
    {

        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteServico(IClienteRepositorio clienteRepositorio)
             : base(clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
