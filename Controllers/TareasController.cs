namespace TP7
{
    using Microsoft.AspNetCore.Http.HttpResults;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class TareasController : ControllerBase
    {
        private ManejoTareas manejo = new ManejoTareas();
        private readonly ILogger<TareasController> _logger;

        public TareasController(ILogger<TareasController> logger)
        {
            _logger = logger;
            manejo = new ManejoTareas();
        }

        [HttpPost("AddTarea")]
        public IActionResult AddTarea(Tarea t)
        {
            if (this.manejo.TareaPorId(t.Id) != null)
            {
                return StatusCode(500, "El id de la tarea ingresada ya existe, ingrese una tarea con otro id");
            }
            else
            {
                this.manejo.crearNuevaTarea(t);
                return Ok(t);
            }
        }

        [HttpGet]
        [Route("BuscarTareaPorId")]
        public IActionResult BuscarTarea(int id)
        {
            Tarea t = this.manejo.TareaPorId(id);

            if (t != null)
            {
                return Ok(t);
            }
            else
            {
                return BadRequest("Tarea no encontrada");
            }
        }

        [HttpPut]
        [Route("actualizartarea/{id}")]
        public IActionResult ActualizarTarea([FromBody] Tarea tarea)
        {
            if (manejo.ActualizarTarea(tarea))
            {
                return Ok("Tarea actualizada " + tarea.Id);
            }
            else
            {
                return StatusCode(500, "No se pudo actualizar la tarea");
            }
        }

        [HttpDelete("EliminarTarea")]
        public IActionResult EliminarTarea(int id)
        {
            if (this.manejo.EliminarTarea(id))
            {
                return Ok($"Tarea {id} Eliminada");
            }
            else
            {
                return StatusCode(500, $"No se pudo eliminar la tarea {500}");
            }
        }

        [HttpGet("ListarTareas")]
        public IActionResult ListarTareas()
        {
            return Ok(this.manejo.ListarTareas());
        }

        [HttpGet("ListarTareasCompletadas")]
        public IActionResult ListarTareasCompletadas()
        {
            return Ok(this.manejo.ListarTareasCompletadas());
        }
    }
}