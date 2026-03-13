// Crear un procedimiento que solicite la edad de una persona y muestre el año aproximado de nacimiento.

void AñoAproximado(int Edad)
{
    int anioActual = 2026;
    int nacimiento = anioActual - Edad;

    Console.WriteLine("La año aproximado es = "+ nacimiento);

}

Console.WriteLine("Ingrese la edad de la persona");
int edad = int.Parse(Console.ReadLine());

AñoAproximado(edad);

