using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Contexto;
using Repositorio.Dominio;


namespace Repositorio.Repositorio
{
    public class UnitOfWork : IDisposable
    {
        private Contexto.Contexto _contexto = new Contexto.Contexto();

        private RepositorioBase<Cliente> _clienteRepositorioBase;

        public RepositorioBase<Cliente> ClienteRepositorioBase
        {
            get
            {
                if (this._clienteRepositorioBase == null)
                {
                    this._clienteRepositorioBase = new RepositorioBase<Cliente>(_contexto);
                }
                return _clienteRepositorioBase;
            }
        }

        private bool _disposed = false;
        public void Dispose()
        {
            Clear(true);
            GC.SuppressFinalize(this);
        }

        private void Clear(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _contexto.Dispose();
                }
            }
            _disposed = true;
        }

        ~UnitOfWork()
        {
            Clear(false);
        }
    }
}
