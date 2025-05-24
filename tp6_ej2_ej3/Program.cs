<<<<<<< HEAD
﻿// See https://aka.ms/new-console-template for more information
/*Ejercicio 2.  Ingrese al branch CalculadoraV1 y construya un programa que sea una 
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar, 
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego 
pida dos números y que devuelva el resultado de la operación seleccionada. Además 
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo. */

=======
﻿/*Ejercicio 3. Ingrese al Branch CalculadoraV2  para implementar las mejoras en la 
calculadora.. Solicite al usuario un número y muestre por pantalla:  
● El valor absoluto de un número  
● El cuadrado 
● La raíz cuadrada  
● El seno 
● El Coseno  
● La parte entera de un tipo float.  
Luego de esto, solicite dos números al usuario y determine:  
● El Máximo entre los dos números 
● El Mínimo entre los dos números */
>>>>>>> CalculadoraV2
int opcion;
double numero1=0, numero2=0;
char controlDelDoWhile;

<<<<<<< HEAD
Console.WriteLine("PROGRAMA: CALCULADORA (V1)");
do
{
    Console.Write("¿Que calculo desea realizar?\n1.- SUMA\n2.- RESTA\n3.- MULTIPLICAR\n4.- DIVIDIR\nOtro.- Salir\nIngrese una opcion: ");
=======
Console.WriteLine("PROGRAMA: CALCULADORA (V2)");
do
{
    Console.Write("¿Que calculo desea realizar?\n5.- VALOR ABSOLUTO\n6.- CUADRADO\n7.- RAIZ CUADRADA\n8.- SENO\n9.- PARTE ENTERA\nOtro.- Salir\nIngrese una opcion: ");
>>>>>>> CalculadoraV2
    while (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.Write("Entrada invalida. Intente nuevamente: ");
    }
<<<<<<< HEAD
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
        if (numero2!=0)
        {
            Console.WriteLine($"Usted eligio DIVISION: {numero1} / {numero2} = {numero1 / numero2}");
        }else
        {
            Console.WriteLine($"No se puede realizar esa operacion");
        }
            
=======
    if (opcion > 4 && opcion < 10)
    {
        Console.Write("Ingrese un numero: ");
        double.TryParse(Console.ReadLine(), out numero1);
    }
    switch (opcion)
    {
        case 5:
            Console.WriteLine($"Usted eligio VALOR ABSOLUTO: |{numero1}| = {Math.Abs(numero1)}");
            break;
        case 6:
            Console.WriteLine($"Usted eligio CUADRADO: {numero1}^2 = {Math.Pow(numero1,2)}");
            break;
        case 7:
            Console.WriteLine($"Usted eligio RAIZ CUADRADA: √({numero1}) = {Math.Sqrt(numero1)}");
            break;
        case 8:
            Console.WriteLine($"Usted eligio SENO: sen({numero1}) = {Math.Sin(numero1)}");
            break;
        case 9:
            Console.WriteLine($"Usted eligio PARTE ENTERA: (int){numero1} = {Math.Truncate(numero1)}");
>>>>>>> CalculadoraV2
            break;
        default:
            Console.WriteLine("No se realizo ninguna operacion");
            break;
    }
<<<<<<< HEAD
    Console.Write("¿Desea realizar otro calculo?\ns.- Si\nn.- No\nIngrese una letra: ");
    controlDelDoWhile = Console.ReadLine()[0];
    
} while (controlDelDoWhile == 's');

Console.WriteLine("FIN DEL PROGRAMA");
=======
    Console.Write("¿Desea realizar otro calculo?\ns.- Si\nOtro.- No\nIngrese una letra: ");
    controlDelDoWhile = Console.ReadLine()[0];

} while (controlDelDoWhile == 's');

Console.WriteLine("EXTRA. MAXIMO y MINIMO entre un par de numeros: ");
Console.Write("Ingrese el primer numero: ");
double.TryParse(Console.ReadLine(), out numero1);
Console.Write("Ingrese el segundo numero: ");
double.TryParse(Console.ReadLine(), out numero2);
Console.WriteLine($"El MAXIMO entre {numero1} y {numero2} es: {Math.Max(numero1, numero2)}");
Console.WriteLine($"El MINIMO entre {numero1} y {numero2} es: {Math.Min(numero1, numero2)}");
Console.WriteLine("FIN DEL PROGRAMA");
>>>>>>> CalculadoraV2
