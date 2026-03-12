// Crear una función que reciba el peso en kilogramos y devuelva el peso en libras.

double KilogramosLibras (double Kilogramos)
{
    return Kilogramos * 2.20462;
}

Console.WriteLine("Ingrese los kilogramos");
double kg = double.Parse(Console.ReadLine());

double libras = KilogramosLibras(kg);

Console.WriteLine("El peso en libras es = "+libras);