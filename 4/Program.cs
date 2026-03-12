// Crear una función que reciba el radio de un círculo y devuelva el área del círculo.

double AreaCirculo(int radio)
{
    return Math.PI * radio * radio;
}

Console.WriteLine("Ingrese el circulo");
int num = int.Parse(Console.ReadLine());

double area = AreaCirculo(num);

Console.WriteLine("El area de un circulo = "+ area);