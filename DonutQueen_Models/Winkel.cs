using System.ComponentModel.DataAnnotations;

namespace DonutQueen_Models;

public class Winkel : EntityId
{
  //  public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Naam { get; set; }

    public string? Telefoonnummer { get; set; }

    [Required]
    public int Nummer { get; set; }

    [Required]
    public int Postcode { get; set; }

    [Required]
    [MaxLength(100)]
    public string Straat { get; set; }

    [Required]
    [MaxLength(50)]
    public string Gemeente { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

}
