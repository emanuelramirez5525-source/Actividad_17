// Crear una función que reciba el precio de un producto y el porcentaje de descuento y devuelva el precio final.

double PrecioFinal(double precio, double descuento)
{
    double PrecioFinal = precio - (precio * descuento / 100);
    return PrecioFinal;
}

Console.WriteLine("Ingrese el precio");
double precio = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad del descuento");
double descuento = double.Parse(Console.ReadLine());

Double FinalPrecio = PrecioFinal(precio, descuento);
Console.WriteLine("El precio final es = "+FinalPrecio);