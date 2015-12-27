using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.LinqLambda
{
    class Program
    {
        static void Main(string[] args)
        {

            var alunos = Repositorio.ObterAlunos();


             alunos.Where(c => c.Disciplinas.Any(d => d.Disciplina.Nome == "Matemática" && d.Nota <= 5));
            

            foreach (var item in alunos.Where(c => c.Disciplinas.Any(d => d.Disciplina.Nome == "Matemática" && d.Nota <= 5)))
            {
               Console.WriteLine(item.Nome);
            }


           // alunos.Where(c => c.Disciplinas.Any(d => d.Disciplina.Nome == "Matemática" && d.Nota <= 5));
            
            
          //  Console.WriteLine(alunos.Count(c => c.Idade >= 18));



            Console.ReadKey();

        }
        
        

    }
}
