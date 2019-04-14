using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HolaMundoAPI.Entities
{
    public class Autor
    {
        public int Id { set; get; }
        [Required]
        public string Nombre { set; get; }
    }
}
