
using System.Collections.Generic;
using PROJETOMODELODDD.Aplicacao.Interface;
using PROJETOMODELODDD.DOMINIO.Entidades;
using  PROJETOMODELODDD.DOMINIO.Interfaces.Servicos;

namespace PROJETOMODELODDD.Aplicacao
{
    public class ClienteAppServicoBase : AppServicoBase<Cliente>, IClienteAppServicoBase
    {

        private readonly IClienteServico _clienteServico;

        public ClienteAppServicoBase(IClienteServico clienteServico)
            : base(clienteServico)
        {
            _clienteServico = clienteServico;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais()
        {
            return _clienteServico.ObterClientesEspeciais(_clienteServico.GetAll());
        }

    }
}
