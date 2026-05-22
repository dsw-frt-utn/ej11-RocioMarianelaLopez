using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave

using System.Collections.Generic;

public class CasoDictionary
{
   
    private Dictionary<int, Alumno> alumnosDic = new Dictionary<int, Alumno>();
    public void AgregarAlumno(int legajo, Alumno alumno)
    {
        alumnosDic.Add(legajo, alumno);
    }
    public Alumno BuscarAlumno(int legajo)
    {
        if (alumnosDic.ContainsKey(legajo))
        {
            return alumnosDic[legajo];
        }
        return null;
    }

    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return alumnosDic;
    }

    public void EliminarAlumno(int legajo)
    {
        alumnosDic.Remove(legajo);
    }
}

