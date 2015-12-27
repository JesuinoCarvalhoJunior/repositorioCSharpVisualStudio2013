using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Collenctions
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            lista.Add("Danilo");
            Console.WriteLine("Adicionou Danilo[0]");
            lista.Add("Alisson");
            Console.WriteLine("Adicionou Alisson[1]");
            lista.Add("Rafael");
            Console.WriteLine("Adicionou Rafael[2]");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            lista.Insert(0,"Jakson");
            Console.WriteLine("Adicionou Jakson[0]");

            foreach (var item in lista)
            {
                Console.WriteLine(item);               
            }
            if (lista.Contains("Danilo"))
            {
                Console.WriteLine("Contem = lista.Contains(Danilo)");
            }
            if (!lista.Contains("Wilson"))
            {
                Console.WriteLine("Não Contem = !lista.Contains(Wilson)");
                lista.Add("Wilson");
                Console.WriteLine("Adicionou Wilson[4]");
            }
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            //Generics
            Console.WriteLine("Lista do tipo Generics");
            //ArrayList clientes = new ArrayList();
            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(new Cliente() {Nome = "Danilo"});
            clientes.Add(new Cliente() {Nome = "Alisson" });
            clientes.Add(new Cliente() { Nome = "Rafael" });

            foreach (var item in clientes)
            {
                Console.WriteLine(item.Nome);
                
            }
            Console.ReadKey();
        }
    }
}
