using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WebDp.Models
{
    public class Book
    {
        [Required]
        [Key]
        public int BId { get; set; }
        [Display(Name ="Book Title")]
        [Required]
        public string BTitle { get; set; }
        [Display(Name ="Category")]
        public string BType { get; set; }
        [Display(Name ="Price")]
        [DataType(DataType.Currency)]
        public double BPrice { get; set; }
        [Display(Name ="Author Name")]
        [Required]
        public string BAuthor { get; set; }
        [Display(Name ="Publisher")]
        [Required]
        public string BPublisher { get; set; }
        [Display(Name ="Realease Date")]
        [DataType(DataType.DateTime)]
        public DateTime BRelease { get; set; }
    }
}
