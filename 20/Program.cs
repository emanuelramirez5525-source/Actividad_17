// Crear una función que reciba la cantidad de días trabajados y el pago diario y devuelva el salario total del empleado.


double SalarioEmpleado(int DiasTrabajos, double PagoDiario)
{
    double total = DiasTrabajos * PagoDiario;
    return total;
}
Console.WriteLine("Ingrese la cantidad de días");
int cantidadDias = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el pago Diario");
double salarioDiario = double.Parse(Console.ReadLine());

double salarioTotal = SalarioEmpleado(cantidadDias, salarioDiario);
Console.WriteLine("El Salario total es = " + salarioTotal);
