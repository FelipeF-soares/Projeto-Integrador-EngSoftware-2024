using SmartCondWeb.Domain.People;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCondWeb.Domain.Things;

public class Unit
{
    [Key]
    public int Id { get; set; }
    [Required]
    [DisplayName("Código da Unidade")]
    public string UnitCode { get; set; }
    [Required]
    [DisplayName("Numero do Apartamento")]
    public string UnitNumber { get; set; }
    [Required]
    [DisplayName("Bloco")]
    public string Building { get; set; }
    public int? HomeownerId { get; set; }
    public virtual Homeowner Homeowner { get; set; }
    public virtual ICollection<Resident>? Residents { get; set; }
    public virtual ICollection<Vehicle>? Vehicles { get; set; }
}
