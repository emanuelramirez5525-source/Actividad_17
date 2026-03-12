//Crear una función que reciba tres números y devuelva el promedio de los tres.

double Promedio (double a, double b, double c)
{
    double PromedioTotal = (a + b + c) / 3;
    return PromedioTotal;
}

Console.WriteLine("Ingrese el primer número");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número");
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tercer número");
double num3 = double.Parse(Console.ReadLine());

double PromedioTotal = Promedio(num1, num2, num3);

Console.WriteLine("El promedio de los 3 números es = " + PromedioTotal);