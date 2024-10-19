using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCondWeb.Domain.People;

public abstract class Person
{
    [Key]
    public int Id { get; set; }
    [Required]
    [DisplayName("Nome Completo")]
    public string Name { get; set; }
    [Required]
    [DisplayName("CPF/CNPJ")]
    public string IdentificationDocument { get; set; }
    [Required]
    [DisplayName("Contato")]
    public string CellPhone { get; set; }
}
