using System.ComponentModel.DataAnnotations;

namespace Infrastruture.Models;

public class Radio
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string? Name { get; set; }

    [Required]
    [MaxLength(300)]
    public string? Description { get; set; }

    [Required]
    [Display (Name = "Año")]
    public int ahno { get; set; }

    [Required]
    public int time { get; set; }
}
