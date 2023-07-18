// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Reflection;
using Tarea2Inventario;

try
{
    var productos1 = new Productos() { Id = 123, Nombreproducto = "Espejo", Categoría = "Original" };
    var productos2 = new Productos() { Id = 124, Nombreproducto = "Discos", Categoría = "Alternativo" };
    var productos3 = new Productos() { Id = 125, Nombreproducto = "Cilindro", Categoría = "Original" };
    var clientes1 = new Clientes() { Nombrecliente = "Pablo", Cedula = 1715489868 };
    var clientes2 = new Clientes() { Nombrecliente = "Juan", Cedula = 1721105128 };
    var clientes3 = new Clientes() { Nombrecliente = "Alberto", Cedula = 1001244100 };
    var proveedores1 = new Proveedores() { Nombreproveedor = "Impormotos" };
    var proveedores2 = new Proveedores() { Nombreproveedor = "Motoparts" };
    Console.WriteLine(productos1);
    Console.WriteLine(productos2);
    Console.WriteLine(productos3);
    Console.WriteLine(clientes1);
    Console.WriteLine(clientes2);
    Console.WriteLine(clientes3);
    Console.WriteLine(proveedores1);
    Console.WriteLine(proveedores2);

}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
Console.WriteLine("Sigo en Pie..!");



/*
class Program

{
    static void Main(string[] args)
    {
        //Crear una instancia Producto y solicitar los datos
        Productos productos = new Productos();
        Console.WriteLine("DATOS DEL PRODUCTO");
        Console.WriteLine("Id del Producto: ");
        productos.Id =  double.Parse(Console.ReadLine());
        Console.Write("Nombre del Repuesto: ");
        productos.Nombreproducto = Console.ReadLine();
        Console.WriteLine("Categoría: ");
        productos.Categoría = Console.ReadLine();

        //Crear una instancia de clientes
        Clientes clientes = new Clientes();
        Console.WriteLine("DATOS DEL CLIENTE ");
        Console.WriteLine("Nombre del Cliente: ");
        clientes.Nombrecliente = Console.ReadLine();
        Console.WriteLine("Cédula: ");
        clientes.Cedula = int.Parse (Console.ReadLine());

        //Crear una instancia de Proveedores
        Proveedores proveedores = new Proveedores();
        Console.WriteLine("DATOS DEL PROVEEDOR");
        Console.WriteLine("Ingrese el nombre del proveedor: ");
        proveedores.Nombreproveedor = Console.ReadLine();
    }
}*/

