// Crear un procedimiento que solicite el número de estudiantes de un curso y muestre un mensaje indicando cuántos estudiantes hay en la clase.

void EstudiantesClases(int Cantidad)
{
    Console.WriteLine("El total de estudiantes que hay en la clase es = "+Cantidad);
}

Console.WriteLine("Ingrese el número de estudiantes de un curso");
int estudiantes = int.Parse(Console.ReadLine());

EstudiantesClases(estudiantes);