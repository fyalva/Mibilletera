using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using miBilletera.Data;
using miBilletera.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace miBilletera.Controllers
{
    [Route("[controller]")]
    public class CuentaController : Controller
    {
      //  private readonly ILogger<CuentaController> _logger;
        private readonly MiDbContext _context;
        public CuentaController(ILogger<CuentaController> logger, MiDbContext context)
        {
     //       _logger = logger;
            _context= context;
        }
[HttpGet (Name = "GetUsuarios")]
public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
{
    return await _context.Usuarios.ToListAsync();
}
    

//ingresar usuario nuevo

[HttpPost(Name = "IngresarCliente")]
public async Task<IActionResult> CrearUsuario([FromBody] Usuario Usuarios)
{
    if (ModelState.IsValid)
    {
        _context.Usuarios.Add(Usuarios);
        await _context.SaveChangesAsync();
        return CreatedAtAction("ObtenerUsuario", new { id = Usuarios.IdUsuario }, Usuarios);
    }
    return BadRequest(ModelState);
}
}
}