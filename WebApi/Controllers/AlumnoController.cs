using AccesoDatos.Models;
using AccesoDatos.Operations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        private AlumnoDAO alumnoDAO = new AlumnoDAO();

        [HttpGet("alumnosProfesor")]
        public List<AlumnoProfesor> GetAlumnosProfesor(string usuario)
        {
            return alumnoDAO.seleccionarAlumnosProfesor(usuario);
        }

        [HttpGet("alumno")]
        public Alumno GetAlumno(int id)
        {
            return alumnoDAO.seleccionar(id);
        }

        [HttpPut("alumno")]
        public bool ActualizarAlumno([FromBody] Alumno alumn)
        {
            return alumnoDAO.actualizar(alumn.Id,alumn.Dni,alumn.Nombre,alumn.Direccion,alumn.Edad,alumn.Email);
        }
    }


}
