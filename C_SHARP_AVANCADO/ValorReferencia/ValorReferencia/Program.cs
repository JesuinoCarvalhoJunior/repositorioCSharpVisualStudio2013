using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorReferencia
{
    class Program
    {

        public class PosicaoClass  // refernece type
        {
            public int x;
            public int y;
        }
        static void Main(string[] args)
        {
            PosicaoClass pos1Class = new PosicaoClass(); // instanciar é a alocacao de memoria
            pos1Class.x = 10;
            pos1Class.y = 20;

            PosicaoClass pos2Class = new PosicaoClass(); // instanciar é a alocacao de memoria
            pos2Class.x = 30;
            pos2Class.y = 40;

            Console.WriteLine(pos1Class.x);
            Console.WriteLine(pos1Class.y);
            Console.WriteLine(pos2Class.x);
            Console.WriteLine(pos2Class.y);


            Console.ReadKey();
        }

        private static void ValorTipoInteiro()
        {
            int x = 10;
            int y = 20;

            y = x; // valor por referencia

            Console.Write(x);
        }
    }
}
