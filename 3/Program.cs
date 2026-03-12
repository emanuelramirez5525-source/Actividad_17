// Crear una función que reciba un número y devuelva su doble.

int doble(int a)
{
    return a * 2;
}

Console.WriteLine("Ingrese un número");
int num = int.Parse(Console.ReadLine());


int resultado = Doble(num);

Console.WriteLine("El doble es = "+ resultado);