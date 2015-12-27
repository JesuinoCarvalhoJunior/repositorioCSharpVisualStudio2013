using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.ClassesEMembrosEstaticos
{
    public class Funcionario
    {
        public static decimal ValorRefeicao;
        public string Nome { get; set; }

        static Funcionario()
        {
            ValorRefeicao = 10;
        }
        public Funcionario()
        {
            Console.WriteLine("Contrutor da classe para os atributos publicos");
        }
    }
}
