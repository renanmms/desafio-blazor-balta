using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace desafio.Models;

[Table("IBGE")]
public class IBGE
{
    [Key]
    public String Id { get; set; }

    public string State { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

}