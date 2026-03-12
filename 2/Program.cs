//Crear una función que reciba un número y devuelva su cuadrado


int Cuadrado(int a)
{
    return a * a;
}

Console.WriteLine("Ingrese un número");
int num = int.Parse(Console.ReadLine());

int resultado = Cuadrado(num);
Console.WriteLine("El cuadrado es = "+ resultado);