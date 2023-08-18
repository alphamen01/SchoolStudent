using AccesoDatos.Models;
using AccesoDatos.Operations;
using System;

public class Program
{
    private static void Main(string[] args)
    {      
        AlumnoDAO opAlumno = new AlumnoDAO();

        Console.WriteLine("*******************************************");
        //opAlumno.insertar("0009", "Loida", "alisos", 35, "loida@gmail.com");
        //opAlumno.actualizar(14,"0019", "Loida", "chimbote", 35, "luz@gmail.com");
        //opAlumno.eliminar(14);
        var alumnoasig = opAlumno.seleccionarAlumnosAginaturas();

        foreach (AlumnoAsignatura alasig in alumnoasig)
        {
            Console.WriteLine(alasig.NombreAlumno + " - " + alasig.NombreAsignatura);
        }

        var alumnos = opAlumno.seleccionarTodos();

        foreach (var item in alumnos)
        {
            Console.WriteLine(item.Nombre);
        }

        Console.WriteLine("-----------------------------------");

        /*Console.WriteLine("Ingrese el id:");
        var id = int.Parse(Console.ReadLine()!);
        var alumno = opAlumno.seleccionar(id);

        Console.WriteLine(alumno.Nombre);*/
        /*
        ////Alumno alumno = new Alumno()
        ////{
        ////    Nombre = "Blanca",
        ////    Dni = "00000000",
        ////    Direccion = "Los  liris",
        ////    Edad = 66,
        ////    Email = "lesg.22.com"
        ////};
        //--//Alumno alumno = new Alumno();
        //--//alumno.Nombre = "Luis";
        //--//alumno.Dni = "88811188";
        //--//alumno.Direccion = "Los pinos";
        //--//alumno.Edad = 26;
        //--//alumno.Email = "lesg.com";

        ////opAlumno.insertar(alumno!);
        */
        Console.WriteLine("*******************************************");

    }
}