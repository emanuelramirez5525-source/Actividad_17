// Crear una función que reciba el salario por hora y las horas trabajadas y devuelva el salario total.

double SalarioTotal(double SalarioHora, double HorasTrabajadas)
{
    double total = SalarioHora * HorasTrabajadas;
    return total;
}
Console.WriteLine("Ingrese el salario por hora");
double salarioHora = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese las horas trabajadas");
double horasTrabajadas = double.Parse(Console.ReadLine());

double salarioTotal = SalarioTotal(salarioHora, horasTrabajadas);
Console.WriteLine("El Salario total es = "+ salarioTotal);

