using System;
using System.Collections.Generic;
using System.Text;

namespace LinFu.DynamicProxy.Samples
{
    public class GreetInterceptor : IInvokeWrapper
    {
        private bool _shouldIntercept = true;
        private readonly object _target;
        public GreetInterceptor(object target)
        {
            _target = target;
        }
        public bool ShouldInterceptMethod
        {
            get { return _shouldIntercept; }
            set { _shouldIntercept = value; }
        }
        
        #region IInvokeWrapper Members

        public void AfterInvoke(InvocationInfo info, object returnValue)
        {
            if (!_shouldIntercept)
                return;

            Console.WriteLine("AfterInvoke Called");
        }

        public void BeforeInvoke(InvocationInfo info)
        {
            if (!_shouldIntercept)
                return;

            Console.WriteLine("BeforeInvoke Called");
        }

        public object DoInvoke(InvocationInfo info)
        {
            // Call the original implementation
            if (!_shouldIntercept)
                return info.TargetMethod.Invoke(_target, info.Arguments);

            // Change the default behavior
            Console.WriteLine("Hello, CodeProject!");
            return null;
        }

        #endregion
    }
    public class Greeter
    {
        public virtual void DoSomething()
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class Program
    {
        static void Main()
        {
            GreetInterceptor interceptor = new GreetInterceptor(new Greeter());
            ProxyFactory factory = new ProxyFactory();
            
            Greeter test = factory.CreateProxy<Greeter>(interceptor);

            // Turn interception off and show the
            // default behavior
            interceptor.ShouldInterceptMethod = false;
            Console.Write("[Interception Off] ");
            test.DoSomething();

            // Turn it back on and replace
            // the method call with the one
            // in the interceptor
            interceptor.ShouldInterceptMethod = true;
            Console.Write("[Interception On] ");            
            test.DoSomething();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
