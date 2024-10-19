using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCondWeb.Domain.Things;

public class Vehicle
{
    [Key]
    public int Id { get; set; }
    [Required]
    [DisplayName("Marca")]
    public string Make { get; set; }
    [Required]
    [DisplayName("Modelo")]
    public string Model { get; set; }
    [Required]
    [DisplayName("Placa")]
    public string LicensePlate { get; set; }
    [Required]
    [DisplayName("Tipo")]
    public string Type { get; set; }
    [Required]
    [DisplayName("Numero da TAG")]
    public string TagNumber { get; set; }
    public int UnitId { get; set; }
    [Required]
    [DisplayName("Unidade")]
    public virtual Unit Unit { get; set; }
}
