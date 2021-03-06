using System;
using System.Collections.Generic;
using System.Text;

namespace Simple.IoC.Factories
{
    public class OncePerRequestFactory<TService, TImplementor> : IFactory<TService>
        where TService : class
        where TImplementor : TService, new()
    {
        #region IFactory<T> Members

        public virtual TService CreateInstance(IContainer container)
        {
            return new TImplementor();
        }

        #endregion
    }
}
