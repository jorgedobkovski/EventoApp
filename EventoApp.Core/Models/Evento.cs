using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoApp.Core.Models
{
    public class Evento
    {
        public int Id { get; set; }

        [StringLength (100)]
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTimeOffset Inicio { get; set; }
        public DateTimeOffset Fim { get; set; }
        public String? Image { get; set; }


    }
}
