using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonutQueen_Models
{
    public class Donut: EntityId
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Naam { get; set; }

        [Required]
        public string Afbeelding { get; set; }

        [Required]
        public string Glazuur { get; set; }

        [Required]
        [Display(Name = "Vigan")]
        public bool IsVegan { get; set; }

        public string? Omschrijving { get; set; }

        [Required]
        public string Topping { get; set; }

        [Required]
        public string Vulling { get; set; }

        public decimal? Prijs { get; set; }



    }
}
