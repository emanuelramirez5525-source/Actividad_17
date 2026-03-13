// Crear un procedimiento que solicite dos números al usuario y muestre la suma de ambos.

void Suma(int a, int b)
{
    int total = a + b;
    Console.WriteLine("El resultado es = " + total);
}

Console.WriteLine("Ingrese un número");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese un segundo número");
int num2 = int.Parse(Console.ReadLine());

Suma(num, num2);