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

            // uso do Join com linq

            var musicas = new List<Musica>
            {
                new Musica{Id=1,Nome="Sweet child",GeneroId=1},
                new Musica{Id=2,Nome="I Shot The Sheriff",GeneroId=2},
                new Musica{Id=3,Nome="Danubio azul",GeneroId=3}
            };

            var musicaquery = from m in musicas
                              join g in generos on m.GeneroId equals g.Id
                              select new { m, g };
            Console.WriteLine();

            foreach (var musica in musicaquery)
            {
                Console.WriteLine("{0}\t{1}\t{2}",musica.m.Id,musica.m.Nome,musica.g.Nome);
            }

            Console.ReadKey();
        }
    }

    class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
    class Musica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int GeneroId{ get; set; }
    }
}
