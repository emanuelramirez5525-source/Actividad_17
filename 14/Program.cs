// Crear una función que reciba la distancia recorrida y el tiempo empleado y devuelva la velocidad promedio.

double VelocidadPromedio(double distanciaRecorrida, double tiempoEmpleado)
{
    double total = (distanciaRecorrida / tiempoEmpleado);
    return total;
}

Console.WriteLine("Ingrese la distancia recorrida");
double distancia = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tiempo empleado");
double tiempo = double.Parse(Console.ReadLine());

double velocidadPromedio = VelocidadPromedio(distancia, tiempo);
Console.WriteLine("La velocidad promedio es = " + velocidadPromedio);
