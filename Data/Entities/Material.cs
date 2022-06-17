using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Material : BaseModel
    {

        [Required(ErrorMessage = "You have to write a title !")]
        [StringLength(100, MinimumLength = 2)]
        [Display(Name = "Material Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You have to write the durability of the material" )]
        [Display(Name = "Durability in years")]
        public int DurabilityYears { get; set; }
    }
}
