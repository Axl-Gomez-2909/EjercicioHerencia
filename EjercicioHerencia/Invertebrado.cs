using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Invertebrado : Animal
    {
        public string? tipo;
        public bool tienepatas;
        public int numeroPatas;
        public bool tieneConcha;
       
        /*
         *Imprimir
         */
        public void imprimir_Invertebrado()
        {
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("¿Tiene Patas?: " + tienepatas);
            Console.WriteLine("¿Número de Patas?: " + numeroPatas);
            Console.WriteLine("¿Tiene Concha?: " + tieneConcha);
            
        }
    }
}
