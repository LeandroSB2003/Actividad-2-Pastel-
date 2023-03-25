using pastel;
using System.Collections.Generic;
using System.Linq;
class Pasteles
{

static void Main(string[] args){
int ContF=0;
int tc = 0;

Ingredientes ingredientes = new Ingredientes();
Pastel pastel = new Pastel();
List<Ingredientes> ListaIngredientes = new List<Ingredientes>();
List<Pastel> ListaPastel = new List<Pastel>();

while (true){


Console.WriteLine("Selecciona: \n" 
                 +"1. Agregar ingrediente \n"
                 +"2. Lista de ingredientes\n"
                 +"3. Cantidad de ingredientes\n"
                 +"4. Calcular costo\n"
                 +"5. Salir");
tc = Int32.Parse(Console.ReadLine());

if(tc==1)
{

var IngredientesL = new Ingredientes();
Console.WriteLine("Ingresa el nombre del ingrediente");
IngredientesL.Lista = Console.ReadLine();
Console.WriteLine("Ingresa la cantidad del ingrediente");
IngredientesL.Cantidad = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ingresa el precio del ingrediente");
IngredientesL.Precio = Int32.Parse(Console.ReadLine());
ListaIngredientes.Add(IngredientesL);

}if(tc==2)
{


foreach (Ingredientes IngredientesL in ListaIngredientes)
{

    Console.WriteLine("Hay " + IngredientesL.Lista + " con una cantidad de " + IngredientesL.Cantidad + " y un precio de " + IngredientesL.Precio + "\n");

}

}if(tc==3)
{

    int count = ListaIngredientes.Count;

    for (int i = 0; i < ListaIngredientes.Count; i++){

        Console.WriteLine(i);


    }

}if(tc==4)
{

if(ContF==0){


var IngredientesP = new Pastel();
Console.WriteLine("Ingresa el nombre del pastel");
IngredientesP.Nombre = Console.ReadLine();
Console.WriteLine("Ingresa el tamaño del pastel");
IngredientesP.Tama = Int32.Parse(Console.ReadLine());
ListaPastel.Add(IngredientesP);
ContF=1;

}

foreach (Pastel IngredientesP in ListaPastel)
{

Console.WriteLine("El pastel con el nombre " + IngredientesP.Nombre + "\n"
                 +"con un tamaño de " + IngredientesP.Tama + "\n");

}

foreach (Ingredientes IngredientesL in ListaIngredientes)
{    

int VF = IngredientesL.Precio+IngredientesL.Precio;

Console.WriteLine("Tiene " + IngredientesL.Lista 
                 +" dando un precio final de " + VF);


}

}if(tc==5)
{

break;

}
}
}
}