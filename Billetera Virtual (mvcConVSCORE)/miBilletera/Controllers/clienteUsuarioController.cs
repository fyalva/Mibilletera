using System;
using System.Threading.Tasks;
using miBilletera.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using miBilletera.Models; // Importa el espacio de nombres que contiene la clase ClienteUsuario

namespace miBilletera.Controllers
{
    [Route("[controller]")]
    public class clienteUsuarioController : Controller
    {
        private readonly ILogger<clienteUsuarioController> _logger;
        private readonly clienteDB _context;

        public clienteUsuarioController(ILogger<clienteUsuarioController> logger, clienteDB context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

       [HttpPost(Name = "IngresarUsuario")]
public async Task<ActionResult<clienteUsuario>> IngresarCliente([FromBody] ClienteUsuario cliente)
{
    try
    {
        // Crear una instancia de ClienteDB
        var clienteDB = new ClienteDB();

        // Agregar el objeto ClienteUsuario a través de ClienteDB
        clienteDB.Cliente.Add(cliente);

        // Guardar los cambios en la base de datos
        await clienteDB.SaveChangesAsync();

        return CreatedAtAction("GetUsuarios", new { id = cliente.Idcliente }, cliente);
    }
    catch (Exception ex)
    {
        return BadRequest($"Error al ingresar el usuario: {ex.Message}");
    }
}
    }
}
