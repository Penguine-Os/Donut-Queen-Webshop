using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonutQueen_Models
{
    public class Leverancier: EntityId
    {
        [Required(ErrorMessage = "Gelieve een Naam in te vullen aub")]
        [MaxLength(50, ErrorMessage = "De ingevulde Naam is te lang. Maximale lengte is 50.")]
        [Display(Name = "Leverancier")]
        public string Naam { get; set; }
        [Display(Name = "Achternaam")]
        public string? NaamContactpersoon { get; set; }
        [Display(Name = "Voornaam")]
        public string? VoornaamContactpersoon { get; set; }

        [Required(ErrorMessage = "Gelieve een Emailadress in te vullen aub")]
        [MaxLength(50, ErrorMessage = "De ingevulde Naam is te lang. Maximale lengte is 50.")]
        public string Emailadres { get; set; }
        
        [Required(ErrorMessage = "Gelieve een Straat in te vullen aub")]
        [MaxLength(50, ErrorMessage = "De ingevulde Naam is te lang. Maximale lengte is 50.")]
        public string Straat { get; set; }

        [Required]
        public int Huisnummer { get; set; }

        [Required]
        public int PostCode { get; set; }

        public ICollection<LeverancierDonut> LeverancierDonuts { get; set; }

    }
}
