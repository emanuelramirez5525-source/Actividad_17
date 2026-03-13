// Crear un procedimiento que solicite la base y la altura de un rectángulo y muestre su área.

void Area(double BaseRectangulo, double altura)
{
    double area = BaseRectangulo * altura;
    Console.WriteLine("El area de la base y altura de un rectangulo es = "+ area);
}

Console.WriteLine("Ingrese la base");
double BaseRect = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura del rectangulo");
double altura = double.Parse(Console.ReadLine());

Area(BaseRect, altura);