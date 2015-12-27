using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.LinqLambda
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Rg { get; set; }
        public IList<AlunoDisciplina> Disciplinas { get; set; }

        public Aluno()
        {
            Disciplinas = new List<AlunoDisciplina>();
        }

        public void VincularDisciplina(Disciplina disciplina, float nota)
        {
            Disciplinas.Add(new AlunoDisciplina() { Disciplina = disciplina, Nota = nota });
        }
    }
}
