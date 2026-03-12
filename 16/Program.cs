//Crear una función que reciba una cantidad de minutos y devuelva el equivalente en horas.

double MinutosHoras (double Minutos)
{
    double resultado = (Minutos / 60);
    return resultado;
}

Console.WriteLine("Ingrese una cantidad de minutos");
double minuto = double.Parse(Console.ReadLine());

double equivalencia = MinutosHoras(minuto);
Console.WriteLine("La equivalencia de minutos a horas es = "+ equivalencia+ "hora(s)");
