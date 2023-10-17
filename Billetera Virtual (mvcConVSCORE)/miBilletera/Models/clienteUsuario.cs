using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace miBilletera.Models
{
    public class clienteUsuario
    {
          [Key]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idcliente { get; set; }
        public string name { get; set; }="";
        public string apellido { get; set; }="";
        public string password { get; set; }="";
    }
}