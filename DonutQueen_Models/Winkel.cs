using System.ComponentModel.DataAnnotations;

namespace DonutQueen_Models;

public class Winkel : EntityId
{
  //  public int Id { get; set; }
    [Required(ErrorMessage = "Gelieve een Naam in te vullen aub")]
    [MaxLength(50, ErrorMessage ="De ingevulde Naam is te lang. Maximale lengte is 50.")]
    public string Naam { get; set; }

    public string? Telefoonnummer { get; set; }

    [Required(ErrorMessage = "Gelieve een huisnummer in te vullen aub")]
    public int Nummer { get; set; }

    [Required(ErrorMessage = "Gelieve een postcode in te vullen aub")]
    public int Postcode { get; set; }

    [Required]
    [MaxLength(100, ErrorMessage = "De ingevulde Naam is te lang. Maximale lengte is 100.")]
    public string Straat { get; set; }

    [Required]
    [MaxLength(50, ErrorMessage = "De ingevulde Naam is te lang. Maximale lengte is 50.")]
    public string Gemeente { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

}
