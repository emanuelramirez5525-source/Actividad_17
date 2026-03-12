// Crear una función que reciba el precio de varios productos y devuelva el total de la compra.

double TotalCompra(double producto1, double producto2, double producto3, double producto4)
{
    double total = producto1+producto2+producto3+producto4;
    return total;
}

Console.WriteLine("Ingrese el precio del producto 1");
double precio1 = double.Parse(Console.ReadLine());


Console.WriteLine("Ingrese el precio del producto 2");
double precio2 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el precio del producto 3");
double precio3 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el precio del producto 4");
double precio4 = double.Parse(Console.ReadLine());

double totalCompra = TotalCompra(precio1, precio2, precio3, precio4);
Console.WriteLine("El total de la compra es = "+totalCompra);