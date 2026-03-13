// Crear un procedimiento que solicite el precio de un producto y muestre el precio con un descuento del 10%.

void Descuento(double precio)
{
    double descuento = precio - (precio * 0.10);
    Console.WriteLine("El precio es = " + precio + " y con el descuento del 10% es = " + descuento);
}

Console.WriteLine("Ingrese el precio de un producto");
double producto = double.Parse(Console.ReadLine());

Descuento(producto);