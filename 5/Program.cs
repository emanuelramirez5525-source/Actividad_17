// Crear una función que reciba la base y la altura de un rectángulo y devuelva su área.

double Area(int Base, int Altura)
{
    return Base * Altura;
}
Console.WriteLine("Ingrese la base");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura");
int n2 = int.Parse(Console.ReadLine());

double area = Area(n1, n2);
Console.WriteLine("La área es = "+ area);
