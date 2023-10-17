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
        private readonly ILogger<CuentaController> _logger;
        private readonly MiDbContext _context;
        public CuentaController(ILogger<CuentaController> logger, MiDbContext context)
        {
            _logger = logger;
            _context= context;
        }
[HttpGet (Name = "GetUsuarios")]
public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
{
    return await _context.Usuarios.ToListAsync();
}
    

//ingresar usuario nuevo

[HttpPost]
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








/////////









/*
[HttpPost(Name = "IngresarUsuario")]
public async Task<ActionResult<Usuario>> IngresarUsuario([FromBody] Usuario Usuario)
{
    try
    {
        _context.Usuarios.Add(Usuario);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetUsuarios", new { id = Usuario.IdUsuario }, Usuario);
    }
    catch (Exception ex)
    {
        return BadRequest($"Error al ingresar el usuario: {ex.Message}");
    }
}
/*
[HttpGet("{id}", Name = "GetUsuarioById")]
public async Task<ActionResult<Usuario>> GetUsuarioById(int id)
{
    var usuario = await _context.Usuarios.FindAsync(id);

    if (usuario == null)
    {
        return NotFound(); // Devuelve un resultado 404 si no se encuentra el usuario.
    }

    return usuario;
}

*/






}

}