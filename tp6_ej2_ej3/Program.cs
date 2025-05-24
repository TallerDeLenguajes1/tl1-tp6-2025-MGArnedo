/*Ejercicio 3. Ingrese al Branch CalculadoraV2  para implementar las mejoras en la 
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
int opcion;
double numero1=0, numero2=0;
char controlDelDoWhile;

Console.WriteLine("PROGRAMA: CALCULADORA (V2)");
do
{
    Console.Write("¿Que calculo desea realizar?\n5.- VALOR ABSOLUTO\n6.- CUADRADO\n7.- RAIZ CUADRADA\n8.- SENO\n9.- PARTE ENTERA\nOtro.- Salir\nIngrese una opcion: ");
    while (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.Write("Entrada invalida. Intente nuevamente: ");
    }
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
            break;
        default:
            Console.WriteLine("No se realizo ninguna operacion");
            break;
    }
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
