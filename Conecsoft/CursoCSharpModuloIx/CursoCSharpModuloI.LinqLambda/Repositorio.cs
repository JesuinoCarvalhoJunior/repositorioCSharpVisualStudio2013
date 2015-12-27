using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.LinqLambda
{
    public static class Repositorio
    {
        private static List<Professor> professores;
        private static List<Aluno> alunos;
        private static List<Disciplina> disciplinas;

        static Repositorio()
        {
            #region Professores

            professores = new List<Professor>();
            professores.Add(new Professor() { Codigo = 1, Cpf = "557896", Nome = "José Pedro" });
            professores.Add(new Professor() { Codigo = 2, Cpf = "548588", Nome = "Helena" });
            professores.Add(new Professor() { Codigo = 3, Cpf = "698523", Nome = "Maria Clemente" });
            professores.Add(new Professor() { Codigo = 4, Cpf = "314569", Nome = "Pedro" });
            professores.Add(new Professor() { Codigo = 5, Cpf = "235578", Nome = "Paulo Araújo" });
            professores.Add(new Professor() { Codigo = 5, Cpf = "235578", Nome = "Paulo" });
            professores.Add(new Professor() { Codigo = 6, Cpf = "471599", Nome = "Tiago" });
            professores.Add(new Professor() { Codigo = 7, Cpf = "578999", Nome = "Judas" });

            #endregion

            #region Disciplinas

            disciplinas = new List<Disciplina>();
            disciplinas.Add(new Disciplina() { Codigo = 1, Nome = "Matemática", Professor = ObterProfessor(1) });
            disciplinas.Add(new Disciplina() { Codigo = 2, Nome = "Português", Professor = ObterProfessor(1) });
            disciplinas.Add(new Disciplina() { Codigo = 3, Nome = "Física", Professor = ObterProfessor(2) });
            disciplinas.Add(new Disciplina() { Codigo = 4, Nome = "Química", Professor = ObterProfessor(3) });
            disciplinas.Add(new Disciplina() { Codigo = 5, Nome = "Geografia", Professor = ObterProfessor(4) });
            disciplinas.Add(new Disciplina() { Codigo = 6, Nome = "História", Professor = ObterProfessor(5) });
            disciplinas.Add(new Disciplina() { Codigo = 7, Nome = "Inglês", Professor = ObterProfessor(5) });
            
            #endregion

            #region Alunos

            alunos = new List<Aluno>();
            alunos.Add(new Aluno() { Nome = "Ricardo Augusto", Idade = 23, Rg = "557895" });
            alunos.Add(new Aluno() { Nome = "Hudson Araujo", Idade = 40, Rg = "96658" });
            alunos.Add(new Aluno() { Nome = "Maria Eduarda", Idade = 30, Rg = "56698" });
            alunos.Add(new Aluno() { Nome = "Ana Paula Furtado", Idade = 32, Rg = "11525" });
            alunos.Add(new Aluno() { Nome = "Matheus Ferreira", Idade = 18, Rg = "365993" });
            alunos.Add(new Aluno() { Nome = "Carol Aguiar", Idade = 17, Rg = "145696" });
            alunos.Add(new Aluno() { Nome = "Felipe Gomes", Idade = 15, Rg = "55889" });

            alunos[0].VincularDisciplina(ObterDisciplina(1), 8.5F);
            alunos[0].VincularDisciplina(ObterDisciplina(2), 6.5F);
            alunos[0].VincularDisciplina(ObterDisciplina(4), 9.0F);
            alunos[0].VincularDisciplina(ObterDisciplina(5), 5.2F);
            alunos[0].VincularDisciplina(ObterDisciplina(6), 7.7F);

            alunos[1].VincularDisciplina(ObterDisciplina(2), 8.4F);
            alunos[1].VincularDisciplina(ObterDisciplina(3), 7.2F);
            alunos[1].VincularDisciplina(ObterDisciplina(4), 2.0F);
            alunos[1].VincularDisciplina(ObterDisciplina(5), 6.2F);

            alunos[2].VincularDisciplina(ObterDisciplina(5), 8.4F);
            alunos[2].VincularDisciplina(ObterDisciplina(3), 7.2F);

            alunos[3].VincularDisciplina(ObterDisciplina(2), 9.4F);
            alunos[3].VincularDisciplina(ObterDisciplina(3), 7.0F);
            alunos[3].VincularDisciplina(ObterDisciplina(4), 6.3F);

            alunos[4].VincularDisciplina(ObterDisciplina(1), 9.4F);
            alunos[4].VincularDisciplina(ObterDisciplina(2), 6.0F);
            alunos[4].VincularDisciplina(ObterDisciplina(3), 5.4F);
            alunos[4].VincularDisciplina(ObterDisciplina(5), 4.0F);
            alunos[4].VincularDisciplina(ObterDisciplina(6), 2.3F);

            alunos[5].VincularDisciplina(ObterDisciplina(1), 4.5F);
            alunos[5].VincularDisciplina(ObterDisciplina(2), 6.5F);
            alunos[5].VincularDisciplina(ObterDisciplina(4), 9.0F);
            alunos[5].VincularDisciplina(ObterDisciplina(5), 5.2F);
            alunos[5].VincularDisciplina(ObterDisciplina(6), 7.7F);

            alunos[6].VincularDisciplina(ObterDisciplina(2), 8.4F);
            alunos[6].VincularDisciplina(ObterDisciplina(3), 7.2F);
            alunos[6].VincularDisciplina(ObterDisciplina(4), 2.0F);
            alunos[6].VincularDisciplina(ObterDisciplina(5), 6.2F);
            alunos[6].VincularDisciplina(ObterDisciplina(7), 6.2F);

            #endregion
        }

        private static Professor ObterProfessor(int codigo)
        {
            return professores.FirstOrDefault(c => c.Codigo == codigo);
        }

        private static Disciplina ObterDisciplina(int codigo)
        {
            return disciplinas.FirstOrDefault(c => c.Codigo == codigo);
        }

        public static List<Professor> ObterProfessores()
        {

            return professores;
        }

        public static List<Disciplina> ObterDisciplinas()
        {
            return disciplinas;
        }

        public static List<Aluno> ObterAlunos()
        {
            return alunos;
        }
    }
}
