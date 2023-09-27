using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace miBilletera.Controllers
{
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
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
    }
}
/*    public class UsuarioController : ApiController
    {
        string cadena = ConfigurationManager.ConnectionStrings["MiCadena"].ConnectionString;
        // GET: api/Usuario
        [HttpGet]
        public IHttpActionResult  Get()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conector = new SqlConnection())
            {
                conector.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM Usuario", conector);
                adaptador.Fill(dt);

            }
            return Ok(dt);
        }

        // GET: api/Usuario/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Usuario
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Usuario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
        }
    }
}
*/