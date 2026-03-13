//Crear un procedimiento que solicite tres calificaciones y muestre el promedio del estudiante.

void Promedio(double a, double b, double c)
{
    double total = (a+ b + c) / 3;
    Console.WriteLine("El promedio total ingresado es = "+total);
}
Console.WriteLine("Ingrese la primera calificacion");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la primera calificacion");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la primera calificacion");
double nota3 = double.Parse(Console.ReadLine());

Promedio(nota1, nota2, nota3);  
