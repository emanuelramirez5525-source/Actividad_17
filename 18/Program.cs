// Crear una función que reciba la cantidad de productos comprados y el precio de cada uno y devuelva el total de la factura.


double TotalFactura(double cantidadproductos)
{
    double suma = 0;
    for (int i = 1; i <= cantidadproductos; i++)
    {
        Console.WriteLine("Ingrese el precio de los productos comprados" + i);
        double producto = double.Parse(Console.ReadLine());
        suma = suma + producto; 
    }
    
    return suma;

    
}

Console.WriteLine("Ingrese la cantidad de productos comprados");
int productos = int.Parse(Console.ReadLine());

double total = TotalFactura(productos);
Console.WriteLine("El total de la fractura es = "+ total);


