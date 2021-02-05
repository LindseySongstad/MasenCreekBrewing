using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace MadsenCreekRazor.Models
{
    public class Beer
    {
        public int ID { get; set; }
        
        [Display(Name = "Name")]
        [Required]
        public string name { get; set; }
        
        [Display(Name = "Style")]
        public string style { get; set; }
        
        [Display(Name = "Description")]
        public string description { get; set; }
        
        [Display(Name="Untapped Link")]
        [DataType(DataType.Url)]
        public string untappedLink { get; set; }
        
        [Display(Name="Recipe Link")]
        [DataType(DataType.Url)]
        public string recipeLink { get; set; }
    }
}
