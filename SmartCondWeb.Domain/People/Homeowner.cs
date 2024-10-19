using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCondWeb.Domain.Things;

namespace SmartCondWeb.Domain.People;

public class Homeowner : Person
{
    [Required]
    [DisplayName("E-mail")]
    public string Email { get; set; }
    public virtual ICollection<Unit> Units { get; set; }
}
