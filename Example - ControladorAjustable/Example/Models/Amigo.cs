using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Example.Models
{
    public class Amigo
    {
        public int Id { set; get; }

        public string Nombre { set; get; }
        public string Email { set; get; }
        public string Ciudad { set; get; }

        public string rutaFoto { set; get; }
            
     }
}
