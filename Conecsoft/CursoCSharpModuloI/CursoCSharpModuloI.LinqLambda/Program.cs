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
            var disciplinas = Repositorio.ObterDisciplinas();
            var professores = Repositorio.ObterProfessores();

            Console.WriteLine("********************************EXERCÍCIOS MODULO I*******************************");
           
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Exerc. 01 - Alunos com 18 anos ou mais, Total: " + alunos.Count(c => c.Idade >= 18));
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Exerc. 02 - Alunos com menos de 18 anos, Total: " + alunos.Count(c => c.Idade < 18));
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Exerc. 03 - Lista de alunos matriculados em Matemática: ");
            
            var alunosMatematatica = alunos.Where(a => a.Disciplinas.Any(d => d.Disciplina.Nome == "Matemática"));
         
            foreach (var item in alunosMatematatica)
            {
                Console.WriteLine("Nome: " + item.Nome);
            }
         
         
            Console.WriteLine(" ");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Exerc. 04 - Lista de alunos matriculados em Matemática com nota menor ou igual a 5:");
            var alunosMatemataticaNotaMenorIgualCinco = alunos.Where(a => a.Disciplinas.Any(d => d.Nota <= 5 && d.Disciplina.Nome == "Matemática"));
            foreach (var item in alunosMatemataticaNotaMenorIgualCinco)
            {
                Console.WriteLine("Nome: " + item.Nome);
            }
           
            Console.WriteLine(" ");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Exerc. 05 - Lista de professores com alguma displina: ");
            var professoresComDisciplinas = professores.Where(p => disciplinas.Any(d => d.Professor.Codigo == p.Codigo));
            foreach (var item in professoresComDisciplinas)
            {
                Console.WriteLine("Nome: " + item.Nome);
            }

            Console.WriteLine(" ");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Exerc. 06 - Lista de professores sem displina: ");
            var professoresSemDisciplinas = professores.Where(p => !disciplinas.Any(d => d.Professor.Codigo == p.Codigo));
            foreach (var item in professoresSemDisciplinas)
            {
                Console.WriteLine("Nome: " + item.Nome);
            }

            Console.WriteLine(" ");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Exerc. 07 - Lista de Alunos com 04 ou mais disciplinas vinculadas: ");
            var alunoQuatroOuMaisDisciplinas = alunos.Where(a => a.Disciplinas.Count >= 4);
            foreach (var item in alunoQuatroOuMaisDisciplinas)
            {
                Console.WriteLine("Nome: " + item.Nome);
            }
            Console.WriteLine(" ");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Exerc. 08 - Lista de Alunos que inicia com a letra 'M': ");
            var alunosIniciamComLetraM = alunos.Where(a => a.Nome.StartsWith("M"));
            foreach (var item in alunosIniciamComLetraM)
            {
                Console.WriteLine(item.Nome);
            }
          
            Console.WriteLine(" ");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Exerc. 09 - Lista de Alunos com menos de 13 caracteres no nome: ");
            var alunosComMenosDeTrezeCaracteres = alunos.Where(a => a.Nome.Length < 13);
            foreach (var item in alunosComMenosDeTrezeCaracteres)
            {
                Console.WriteLine("Nome: " + item.Nome);
            }
           
            Console.WriteLine(" ");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Exerc.10 - Lista de professores que contem o nome 'Pedro': ");
            var professoresComConteNomePedro = professores.Where(p => p.Nome.Contains("Pedro"));
            foreach (var item in professoresComConteNomePedro)
            {
                Console.WriteLine("Nome: " + item.Nome);
            }
           
            Console.WriteLine(" ");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Exerc. 11 - Lista de alunos de Portugues ordenador por idade do menor para o maior: ");
            var alunosDePortuguesOrdenado = alunos.Where(a => a.Disciplinas.Any(d => d.Disciplina.Nome == "Português")).OrderBy(al => al.Idade);
            foreach (var item in alunosDePortuguesOrdenado)
            {
                Console.WriteLine("Nome: "+item.Nome + " - Idade " + item.Idade );
            }
           
            Console.WriteLine(" ");
            Console.WriteLine("**********************************************************************************");           
            var professorGeografia = professores.Where(p => disciplinas.Any(d => d.Professor.Codigo == p.Codigo && d.Nome == "Geografia"));
            Console.WriteLine("Exerc. 12 - Nome do Professor de Geografia: ");
            foreach (var item in professorGeografia)
            {
                Console.WriteLine("Nome: " + item.Nome);
            }
          
            Console.WriteLine(" ");
            Console.WriteLine("************************************FIM*******************************************");
            Console.ReadKey();
        }
    }
}
