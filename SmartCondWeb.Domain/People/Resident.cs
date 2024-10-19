using SmartCondWeb.Domain.Things;
using SmartCondWeb.Domain.Animal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCondWeb.Domain.People;

public class Resident:Person
{
    [Required]
    [DisplayName("Código do Morador")]
    public string UnitCodeResident { get; set; }
    [Required]
    [DisplayName("E-mail")]
    public string Email { get; set; }
    [Required]
    [DisplayName("Foto")]
    public string ImageURL { get; set; }
    public IEnumerable<Pet>? Pets { get; set; }
    public int UnitId { get; set; }
    [Required]
    [DisplayName("Unidade")]
    public Unit Unit { get; set; }
}
