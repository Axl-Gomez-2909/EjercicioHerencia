using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Vertebrado : Animal
    {
        public string? tipo;
        public bool patas;
        public bool domestico;
        public bool herviboro;
        public bool carnivoro;

        public void imprimir_Vertebrado()
        {
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("¿Tiene Patas?: " + patas);
            Console.WriteLine("¿Es doméstico?:  " + domestico);
            Console.WriteLine("¿Es hervíboro?: " + herviboro);
            Console.WriteLine("¿Es carnívoro?:  " + carnivoro);
        }
    }
}
