using TareaClase16_Cuadrilateros.Cuadrilateros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

int x1 = 0; int y1 = 0; int x2 = 0; int y2 = 0; int x3 = 0; int y3 = 0; int x4 = 0; int y4 = 0;
int figura = 0;
do {
    Console.WriteLine("\nVamos a calcular el área de un cuadrilátero:");
    Console.WriteLine("\n1 : Cuadrado");
    Console.WriteLine("\n2 : Rectángulo");
    Console.WriteLine("\n3 : Trapecio");
    Console.WriteLine("\n4 : Salir");
    Console.WriteLine("\n--Ingrese una opción (1 a 4):");
    figura = int.Parse(Console.ReadLine());

    switch (figura) {
        case 1:
            Console.WriteLine("\n---Cuadrado---");
            IngresoCoordenadas();

            Cuadrado miCuadrado = new Cuadrado(x1, y1, x2, y2, x3, y3, x4, y4);
            Console.WriteLine($"\n El área del Cuadrado es: {miCuadrado.Area()}");
            break;
        case 2:
            Console.WriteLine("\n---Rectángulo---");
            IngresoCoordenadas();

            Rectangulo miRectangulo = new Rectangulo(x1, y1, x2, y2, x3, y3, x4, y4);
            Console.WriteLine($"\n El área del Rectangulo es: {miRectangulo.Area()}");
            break;
        case 3:
            Console.WriteLine("\n---Trapecio---");
            IngresoCoordenadas();

            Trapecio miTrapecio = new Trapecio(x1, y1, x2, y2, x3, y3, x4, y4);
            Console.WriteLine($"\n El área del Trapecio es: {miTrapecio.Area()}");
            break;
        case 4:
            Console.WriteLine($"\n -------------------FIN-------------------");
            Console.WriteLine($"\n -----------Hasta la vista baby-----------");
            break;
        default:
            Console.WriteLine("\n---Opcion no disponible---");
            break;
    }//switch
} while (figura!=4);

    void IngresoCoordenadas(){
    Console.WriteLine("\nIngrese coordenada X1:");
    x1 = int.Parse(Console.ReadLine());
    Console.WriteLine("\nIngrese coordenada Y1:");
    y1 = int.Parse(Console.ReadLine());
    Console.WriteLine("\nIngrese coordenada X2:");
    x2 = int.Parse(Console.ReadLine());
    Console.WriteLine("\nIngrese coordenada Y2:");
    y2 = int.Parse(Console.ReadLine());
    Console.WriteLine("\nIngrese coordenada X3:");
    x3 = int.Parse(Console.ReadLine());
    Console.WriteLine("\nIngrese coordenada Y3:");
    y3 = int.Parse(Console.ReadLine());
    Console.WriteLine("\nIngrese coordenada X4:");
    x4 = int.Parse(Console.ReadLine());
    Console.WriteLine("\nIngrese coordenada Y4:");
    y4 = int.Parse(Console.ReadLine());
}
