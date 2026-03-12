// Crear una función que reciba un número y devuelva el cubo del número.

int Cubo(int a)
{
    return a * a * a;
}

Console.WriteLine("Ingrese un número");
int num = int.Parse(Console.ReadLine());

int resultado = Cubo(num);
Console.WriteLine("El cubo es = "+resultado);