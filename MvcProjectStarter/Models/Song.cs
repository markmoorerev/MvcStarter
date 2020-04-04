using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProjectStarter.Models
{
    public class Song
    {
        public int id { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string title { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Display(Name = "Genre")]
        [Required]
        public string genre { get; set; }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "Artist Default error msg.")]
        [StringLength(30)]
        [Display(Name = "Artist")]
        [Required] 
        public string artist { get; set; }

        [StringLength(30)]
        [Display(Name = "Album")]
        [Required]
        public string album { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

    }
}
