using System.ServiceProcess;

namespace ExemploWindowsService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
//#if (!DEBUG)

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new Service1() 
            };
            ServiceBase.Run(ServicesToRun);
            //
         
//#else
  /*         
            // Debug code: Permite debugar um código sem se passar por um Windows Service.
            // Defina qual método deseja chamar no inicio do Debug (ex. MetodoRealizaFuncao)
            // Depois de debugar basta compilar em Release e instalar para funcionar normalmente.

            Service1 service = new Service1();

            // Chamada do seu método para Debug.
            //service.MetodoRealizaFuncao();

          service.EnviarEmailPendente();

            // Coloque sempre um breakpoint para o ponto de parada do seu código.
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
           
          
#endif
    */
    }
    }
}
