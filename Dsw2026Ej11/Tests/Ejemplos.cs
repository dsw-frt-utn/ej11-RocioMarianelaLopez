using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        casoList.AgregarAlumno(new Alumno(1, "Ana", 8.5));
        casoList.AgregarAlumno(new Alumno(2, "Juan", 7.0));
        casoList.AgregarAlumno(new Alumno(3, "Pedro", 9.2));

        Console.WriteLine("--- Todos los alumnos ---");
        foreach (var a in casoList.ObtenerLista()) Console.WriteLine(a.ToString());

        Console.WriteLine("\n--- Buscar alumno 'Ana' ---");
        var existente = casoList.BuscarPorNombre("Ana");
        Console.WriteLine(existente != null ? existente.ToString() : "No existe");

        Console.WriteLine("\n--- Buscar alumno 'Marcos' ---");
        var noExistente = casoList.BuscarPorNombre("Marcos");
        Console.WriteLine(noExistente != null ? noExistente.ToString() : "No existe");

        Console.WriteLine("\n--- Eliminar a Ana y listar ---");
        casoList.EliminarAlumno(existente);
        foreach (var a in casoList.ObtenerLista()) Console.WriteLine(a.ToString());

        Console.WriteLine("\n--- Eliminar posición 0 y listar ---");
        casoList.EliminarAlumnoEnPosicion(0);
        foreach (var a in casoList.ObtenerLista()) Console.WriteLine(a.ToString());
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos


    public static void EjemploDictionary()
    {
        CasoDictionary casoDict = new CasoDictionary();

        casoDict.AgregarAlumno(101, new Alumno(1, "Ana", 8.5));
        casoDict.AgregarAlumno(102, new Alumno(2, "Juan", 7.0));
        casoDict.AgregarAlumno(103, new Alumno(3, "Pedro", 9.2));

        Console.WriteLine("--- Todos los alumnos (Diccionario) ---");
        foreach (var kvp in casoDict.ObtenerDiccionario())
        {
            Console.WriteLine($"Legajo {kvp.Key}: {kvp.Value.ToString()}");
        }

        Console.WriteLine("\n--- Buscar legajo 102 ---");
        var existente = casoDict.BuscarAlumno(102);
        Console.WriteLine(existente != null ? existente.ToString() : "No existe");

        Console.WriteLine("\n--- Buscar legajo 999 ---");
        var noExistente = casoDict.BuscarAlumno(999);
        Console.WriteLine(noExistente != null ? noExistente.ToString() : "No existe");

        Console.WriteLine("\n--- Eliminar legajo 101 y listar ---");
        casoDict.EliminarAlumno(101);
        foreach (var kvp in casoDict.ObtenerDiccionario())
        {
            Console.WriteLine($"Legajo {kvp.Key}: {kvp.Value.ToString()}");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine("1. Primer libro: " + casoLinq.GetPrimero().Titulo);
        Console.WriteLine("2. Último libro: " + casoLinq.GetUltimo().Titulo);
        Console.WriteLine($"3. Suma precios: {casoLinq.GetTotalPrecios():C2}");
        Console.WriteLine($"4. Promedio precios: {casoLinq.GetPromedioPrecios():C2}");

        Console.WriteLine("\n5. Libros con Id > 15:");
        foreach (var l in casoLinq.GetListById()) Console.WriteLine(l.Titulo);

        Console.WriteLine("\n6. Libros en formato string:");
        foreach (var s in casoLinq.GetLibros()) Console.WriteLine(s);

        Console.WriteLine("\n7. Mayor precio: " + casoLinq.GetMayorPrecio().Titulo);
        Console.WriteLine("8. Menor precio: " + casoLinq.GetMenorPrecio().Titulo);

        Console.WriteLine("\n9. Libros con precio > promedio:");
        foreach (var l in casoLinq.GetMayorPromedio()) Console.WriteLine(l.Titulo);

        Console.WriteLine("\n10. Libros ordenados desc:");
        foreach (var l in casoLinq.GetLibrosOrdenadosDesc()) Console.WriteLine(l.Titulo);
    }
}
