// Crear un procedimiento que solicite el nombre de un estudiante, su curso y tres calificaciones, y muestre un reporte simple con toda la información ingresada.

void ReporteInformacion(string nombre, string curso, double nota1, double nota2, double nota3)
{
    Console.WriteLine("El nombre del estudiante:" + nombre);
    Console.WriteLine("El curso:" + curso);
    Console.WriteLine("Calificaciones");
    Console.WriteLine("Nota1: "+nota1);
    Console.WriteLine("Nota2: " +nota2);
    Console.WriteLine("Nota3: "+ nota3);
}

Console.WriteLine("Ingrese el nombre del estudiante");
string Nombre = Console.ReadLine();

Console.WriteLine("Ingrese el curso");
string Curso = Console.ReadLine();

Console.WriteLine("Ingrese primera Calificación");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese segunda Calificación");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese tercera Calificación");
double nota3 = double.Parse(Console.ReadLine());

ReporteInformacion (Nombre, Curso, nota1, nota2, nota3);