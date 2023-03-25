using System;
using EjercicioSemana8.DAO;
using EjercicioSemana8.Models;
while (true)
{
    Console.WriteLine("Selecciona una opción del menú");
    Console.WriteLine("1 - Guardar");
    Console.WriteLine("2 - Salir");
    int op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            Producto producto = new Producto();
            crudProductos CrudProductos = new crudProductos();
            Console.WriteLine("Por Favor Digite el Nombre");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Por Favor Digite La Descripcion");
            producto.Descripcion = Console.ReadLine();
            Console.WriteLine("Por Favor Digite El Precio");
            producto.Precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Por Favor Digite el Stock");
            producto.Stock = int.Parse(Console.ReadLine());
            CrudProductos.guardar(producto);
            break;
        case 2:
            break;
    }
    Console.WriteLine("Selecciona una opción");
    Console.WriteLine("1 - Ejecutar de nuevo");
    Console.WriteLine("2 - Salir");
    int seguir = int.Parse(Console.ReadLine());
    if (seguir.Equals(2))
    {
        break;
    }
    
}