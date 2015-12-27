using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando array já com valores
            int[] numeros = { 50, 60, 50 };

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }

            Cliente[] clientes = new Cliente[2];
            clientes[0] = new Cliente() { Nome = "Danilo", Cpf = "100" , Idade = 23 };
            clientes[1] = new Cliente() { Nome = "Jose", Cpf = "54548", Idade = 52 };

            for (int i = 0; i < clientes.Where(c => c.Idade <= 25).Count(); i++)
            {
                Cliente cliente = clientes[i];
                Console.WriteLine(cliente.Nome);
                Console.WriteLine(cliente.Cpf);
            }

            foreach (var cliente in clientes.Where(c => c.Idade <= 25))
            {
                Console.WriteLine(cliente.Nome);
                Console.WriteLine(cliente.Cpf);
            }
        }
    }
}
