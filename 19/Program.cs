// Crear una función que reciba el nombre de un estudiante y tres calificaciones y devuelva el promedio final.

double PromedioFinal(double nota1, double nota2, double nota3)
{
    double promedio = (nota1 + nota2 + nota3) / 3;
    return promedio;
    
}

Console.WriteLine("Ingrese un nombre de un estudiante");
string nombre = Console.ReadLine();

Console.WriteLine("Ingrese la primera calificación");
double n1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la segunda calificación");
double n2 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la tercera calificación");
double n3 = double.Parse(Console.ReadLine());

double promedioFinal = PromedioFinal(n1, n2, n3);
Console.WriteLine("El promedio final  de "+ nombre+ "es = "+promedioFinal);