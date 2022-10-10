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
       
        [Required(ErrorMessage = "Gelieve een Naam in te vullen aub")]
        [MaxLength(50, ErrorMessage ="De ingevulde Naam is te lang. Maximale lengte is 50.")]
        public string Naam { get; set; }

        [Required(ErrorMessage = "Gelieve een Afbeelding naam in te vullen aub")]
        public string Afbeelding { get; set; }

        [Required(ErrorMessage = "Gelieve een Glazuur type in te vullen aub")]
        public string Glazuur { get; set; }

        [Required(ErrorMessage = "Gelieve aan te duiden of het vegan/non-vegan aub")]
        [Display(Name = "Vigan")]
        public bool IsVegan { get; set; }

        public string? Omschrijving { get; set; }

        [Required(ErrorMessage = "Gelieve een Omschrijving in te vullen aub")]
        public string Topping { get; set; }

        [Required(ErrorMessage = "Gelieve de Vulling type in te vullen aub")]
        public string Vulling { get; set; }

        public decimal? Prijs { get; set; }

        public ICollection<LeverancierDonut> LeverancierDonuts { get; set; }



    }
}
