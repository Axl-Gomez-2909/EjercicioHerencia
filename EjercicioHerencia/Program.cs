using System;
using EjercicioHerencia;
#region Vertebrados
//Instancia de objeto y llamado de la clase vertebrado
Vertebrado vertebrado = new Vertebrado();
vertebrado.nombre = "Ballena jorobada ";
vertebrado.color = "Negra en el dorso, con coloración blanca que cubre los surcos ventrales ";
vertebrado.tamano = "Grande";
vertebrado.familia = "Balaenopteridae";
vertebrado.tipo = "Mamífero";
vertebrado.patas = false;
vertebrado.domestico= false;
vertebrado.herviboro = false;
vertebrado.carnivoro = true;

if (vertebrado.validar())
{
    vertebrado.imprimir();
    vertebrado.imprimir_Vertebrado();
}
else
{
    Console.WriteLine("Ingrese todos los datos");
}
Console.WriteLine("----------------------------------------------------------------------------------------------------------");
//----------------------------------------------------------------------------------------------------------------------------------------//
Vertebrado vertebrado2 = new Vertebrado();
vertebrado2.nombre = "Cocodrilo";
vertebrado2.color = "Verde oscuro o marrón, con líneas transversales más oscuras";
vertebrado2.tamano = "Mediano";
vertebrado2.familia = "Crocodylidae";
vertebrado2.tipo = "Reptil";
vertebrado2.patas = true;
vertebrado2.domestico = false;
vertebrado2.herviboro = false;
vertebrado2.carnivoro = true;

if (vertebrado2.validar())
{
    vertebrado2.imprimir();
    vertebrado2.imprimir_Vertebrado();
}
else
{
    Console.WriteLine("Ingrese todos los datos");
}
Console.WriteLine("----------------------------------------------------------------------------------------------------------");


#endregion
//----------------------------------------------------------------------------------------------------------------------------------------//
#region Invertevados
//Instancia de objeto y llamado de la clase invertebrado
Invertebrado invertebrado = new Invertebrado();
invertebrado.nombre = "Tarántula";
invertebrado.color = "Negras";
invertebrado.tamano = "Pequeña";
invertebrado.familia = "Theraphosidae";
invertebrado.tipo = "Aracnido";
invertebrado.tienepatas= true;
invertebrado.numeroPatas = 8;
invertebrado.tieneConcha = false;
if (invertebrado.validar())
{
    invertebrado.imprimir();
    invertebrado.imprimir_Invertebrado();
}
else
{
    Console.WriteLine("Ingrese todos los datos");
}
Console.WriteLine("----------------------------------------------------------------------------------------------------------");
//----------------------------------------------------------------------------------------------------------------------------------------//
Invertebrado invertebrado2 = new Invertebrado();
invertebrado2.nombre = "Pulpo";
invertebrado2.color = "Marrón";
invertebrado2.tamano = "Mediano";
invertebrado2.familia = "Octopodidae";
invertebrado2.tipo = "Molusco";
invertebrado2.tienepatas = false;
invertebrado2.numeroPatas = 0;
invertebrado2.tieneConcha = false;
if (invertebrado2.validar())
{
    invertebrado2.imprimir();
    invertebrado2.imprimir_Invertebrado();
}
else
{
    Console.WriteLine("Ingrese todos los datos");
}
#endregion