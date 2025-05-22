// See https://aka.ms/new-console-template for more information
/*Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el 
texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del 
número sólo si éste es mayor a 0. 
Nota: Si observa un subrayado amarillo sugiriendo modificar las variables al tipo 
"nullable", abra el archivo de configuración de proyecto de extensión .csproj y elimine 
la línea que dice   <Nullable>enable</Nullable>. No olvide guardar el archivo.*/

double numero;
double numeroInvertido;
Console.WriteLine("PROGRAMA: INVERTIR NUMERO INGRESADO POR EL USUARIO");
Console.WriteLine("Ingrese un numero entero: ");
while (!double.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("Entrada invalida. Intente nuevamente: ");
}

if (numero > 0)
{
    numeroInvertido = 1 / numero;
    Console.WriteLine($"Número invertido: {numeroInvertido}");
}
else
{
    Console.WriteLine("El numero es menor o igual que cero por lo tanto no se puede invertir");
}
Console.WriteLine("FIN DEL PROGRAMA");
