using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using miBilletera.Data;
using miBilletera.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using static miBilletera.Models.ClienteUsuario;


namespace miBilletera.Controllers
{ //config.EnableCors(); [EnableCors( "*")]

    [Route("[controller]")]
    public class ClienteUsuarioController : Controller
    {
        private readonly ILogger<ClienteUsuarioController> _logger;
        private readonly ClienteDB _context;
        public ClienteUsuarioController(ILogger<ClienteUsuarioController> logger, ClienteDB context)
        {
            _logger = logger;
            _context= context;
        }

//[EnableCors("AllowOrigin")]
[HttpGet (Name = "GetClienteCliente")]
public async Task<ActionResult<IEnumerable<ClienteUsuario>>> GetClientes()
{
    return await _context.Clientes.ToListAsync();
}
//[EnableCors("AllowOrigin")]
 [HttpPost(Name = "IngresarClienteUsuarios")]
public async Task<IActionResult> CrearClientes([FromBody] ClienteUsuario Clientes) 
{
    if (ModelState.IsValid)
    {
        _context.Clientes.Add(Clientes);
        await _context.SaveChangesAsync();
        return CreatedAtAction("ObtenerCliente", new { id = Clientes.Idcliente}, Clientes);

    }
    return BadRequest(ModelState);
}}
    }
