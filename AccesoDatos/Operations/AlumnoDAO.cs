using AccesoDatos.Context;
using AccesoDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Operations
{
    public class AlumnoDAO
    {
        public ProyectoContext context = new ProyectoContext();

        public List<Alumno> seleccionarTodos()
        {
            var alumnos = context.Alumnos.ToList<Alumno>();
            return alumnos;
        }

        public Alumno seleccionar(int id)
        {
            var alumno = context.Alumnos.FirstOrDefault(c => c.Id == id);
            return alumno!;
        }

        ////public bool insertar(Alumno alumno)
        ////{
        ////    try
        ////    {
        ////        context.Alumnos.Add(alumno);
        ////        context.SaveChanges();
        ////        return true;
        ////    }
        ////    catch(Exception ex)
        ////    {
        ////        return false;
        ////    }

        ////}
        
        public bool insertar(string dni,string nombre, string direccion,int edad, string email)
        {
            try
            {
                Alumno alumno = new Alumno();
                alumno.Dni = dni;
                alumno.Nombre = nombre;
                alumno.Direccion = direccion;
                alumno.Edad = edad;
                alumno.Email = email;

                context.Alumnos.Add(alumno);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool actualizar(int id, string dni, string nombre, string direccion, int edad, string email)
        {
            try
            {
                var alumno = seleccionar(id);
                if (alumno == null)
                {
                    return false;
                }
                else
                {
                    alumno.Dni = dni;
                    alumno.Nombre = nombre;
                    alumno.Direccion = direccion;
                    alumno.Edad = edad;
                    alumno.Email = email;

                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}

    
