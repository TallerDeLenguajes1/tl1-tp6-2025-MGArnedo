// See https://aka.ms/new-console-template for more information
/*Ejercicio 2.  Ingrese al branch CalculadoraV1 y construya un programa que sea una 
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar, 
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego 
pida dos números y que devuelva el resultado de la operación seleccionada. Además 
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo. */

int opcion;
double numero1=0, numero2=0;
char controlDelDoWhile;

Console.WriteLine("PROGRAMA: CALCULADORA (V1)");
do
{
    Console.Write("¿Que calculo desea realizar?\n1.- SUMA\n2.- RESTA\n3.- MULTIPLICAR\n4.- DIVIDIR\nOtro.- Salir\nIngrese una numero: ");
    while (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.Write("Entrada invalida. Intente nuevamente: ");
    }
    if (opcion > 0 && opcion < 5)
    {
        Console.Write("Ingrese el primer numero: ");
        double.TryParse(Console.ReadLine(), out numero1);
        Console.Write("Ingrese el segundo numero: ");
        double.TryParse(Console.ReadLine(), out numero2);
    }
    switch (opcion)
    {
        case 1:
            Console.WriteLine($"Usted eligio SUMA: {numero1} + {numero2} = {numero1 + numero2}");
            break;
        case 2:
            Console.WriteLine($"Usted eligio RESTA: {numero1} - {numero2} = {numero1 - numero2}");
            break;
        case 3:
            Console.WriteLine($"Usted eligio MULTIPLICACION: {numero1} * {numero2} = {numero1 * numero2}");
            break;
        case 4:
            Console.WriteLine($"Usted eligio DIVISION: {numero1} / {numero2} = {numero1 / numero2}");
            break;
        default:
            Console.WriteLine("No se realizo ninguna operacion");
            break;
    }
    Console.Write("¿Desea realizar otro calculo?\ns.- Si\nn.- No\nIngrese una letra: ");
    controlDelDoWhile = Console.ReadLine()[0];
    
} while (controlDelDoWhile == 's');

Console.WriteLine("FIN DEL PROGRAMA");