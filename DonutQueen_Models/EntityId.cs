using System.ComponentModel.DataAnnotations;

namespace DonutQueen_Models;

public class EntityId
{
    [Key]
    public int Id { get; set; }
}
