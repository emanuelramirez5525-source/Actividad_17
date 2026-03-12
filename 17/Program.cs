//Crear una función que reciba la cantidad de estudiantes y la nota de cada uno y devuelva el promedio del grupo.

double Promedio(double cantidadestudiante)
{
    double suma = 0;
    for (int i = 1; i <=cantidadestudiante; i++)
    {
        Console.WriteLine("Ingrese la nota de los estudiantes");
        double nota = double.Parse(Console.ReadLine());
        suma = suma + nota;
    }
    double promedio = suma / cantidadestudiante;
    return promedio;
}

Console.WriteLine("Ingrese la cantidad de estudiantes");
int cantidadestudiante = int.Parse(Console.ReadLine());

double PromedioTotal = Promedio(cantidadestudiante);
Console.WriteLine("EL Promedio total del grupo es = " + PromedioTotal);
