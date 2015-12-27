
using System.Collections.Generic;
using PROJETOMODELODDD.DOMINIO.Entidades;


namespace PROJETOMODELODDD.Aplicacao.Interface
{

    // classe especializada
    public interface IClienteAppServicoBase : IAppServicoBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();


     //   IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> enumerable);

      
    }
}
