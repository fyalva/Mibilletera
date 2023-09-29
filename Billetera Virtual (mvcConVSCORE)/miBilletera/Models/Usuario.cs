using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miBilletera.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }="";
        public string SegundoNombre { get; set; }="";
        public string Apellidos { get; set; }="";
        public string Evidencia1 { get; set; }="";
        public string Evidencia2 { get; set; }="";
        public string Evidencia3 { get; set; }="";
        public string Estado { get; set; }="";
        public string Coloquio { get; set; }="";
    }
}