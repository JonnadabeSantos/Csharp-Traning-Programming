using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp_Traning_Programming.Models
{
    public class Pessoa
    {   
        public string? My { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine( $"Olá, meu nome é {My}, e tenho { Idade } anos");

        }
    }
}