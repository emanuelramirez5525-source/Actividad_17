//Crear una función que reciba un número en grados Celsius y devuelva el valor convertido a Fahrenheit.

double ConvertirCelsiusFarenheit(double celsius)
{
   double resultado = (celsius * 9 / 5) + 32;
    return resultado;
}

Console.WriteLine("Ingrese los grados Celsius");
double grados = double.Parse(Console.ReadLine());

double resultado = ConvertirCelsiusFarenheit(grados);
Console.WriteLine("El resultado es = " + resultado + " Farenheit");