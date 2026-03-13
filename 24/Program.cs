// Crear un procedimiento que solicite el radio de un círculo y muestre el área del círculo.

void AreaCirculo(double radio)
{
    double total = Math.PI * (radio * radio);
    Console.WriteLine("El area de un circulo es = "+total);
}

Console.WriteLine("Ingrese el radio de un circulo");
double radio = double.Parse(Console.ReadLine());

AreaCirculo(radio);  