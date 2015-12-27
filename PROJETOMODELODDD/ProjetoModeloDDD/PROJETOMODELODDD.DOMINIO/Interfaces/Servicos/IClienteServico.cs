using System.Collections.Generic;
using PROJETOMODELODDD.DOMINIO.Entidades;


namespace PROJETOMODELODDD.DOMINIO.Interfaces.Servicos
{
    public interface IClienteServico : IServicoBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
