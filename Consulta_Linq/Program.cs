using System;
using System.Collections.Generic;
using System.Linq;

namespace Consulta_Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            // sem usa o linq
            var generos = new List<Genero>
           {
               new Genero{Id=01,Nome="rock"},
               new Genero{Id=02,Nome="Forro"},
               new Genero{Id=03,Nome ="Rock classico"},
               new Genero{Id=04,Nome ="Samba"}

           };

            foreach (var genero in generos)
            {
                if (genero.Nome.Contains("Rock"))
                {
                    Console.WriteLine("{0}\t{1}", genero.Id, genero.Nome);
                }
            }

            Console.WriteLine();


            // usando linq

            var query = from g in generos
                        where g.Nome.Contains("Rock")
                        select g;

            foreach (var g in query)
            {
                Console.WriteLine("{0}\t{1}", g.Id, g.Nome);
            }

            Console.ReadKey();
        }
    }

    class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
