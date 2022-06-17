using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Article : BaseModel
    {
        [Required(ErrorMessage ="You have to write a title !")]
        [MinLength(2)]
        public string Title { get; set; }

        [Required(ErrorMessage = "You must write at least 5 characters !")]
        [MinLength(10)]
        [Display(Name = "Article content")]
        public string Content { get; set; }

        public Guid MaterialId { get; set; }

        //[Required]
        public Material Material { get; set; }

        public string VideoUrl { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

    }
}
