// Crear un procedimiento que solicite el nombre de una persona y muestre un saludo personalizado.

void SaludoPersonalizado(string nombre)
{
    Console.WriteLine("Hola " + nombre + " Como estas?? =D");
}

Console.WriteLine("Ingrese el nombre de una persona");
string nombre = Console.ReadLine();

SaludoPersonalizado(nombre);

