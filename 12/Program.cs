//Crear una función que reciba la edad de una persona y devuelva un mensaje mostrando la edad ingresada.

string MostrarEdad(int edad)
{
    return "la edad de la persona es " + edad;
}

Console.WriteLine("Ingrese una edad ");
int edad = int.Parse(Console.ReadLine());

string mostrar = MostrarEdad(edad);
Console.WriteLine(mostrar);