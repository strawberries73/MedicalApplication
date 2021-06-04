using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicalApplication.Models.ViewModels
{
    public class ConcentratesBaseViewModel
    {
        [Key]
        // Hash
        public int HashId { get; set; }
        public int TypeId { get; set; }

        // Rosin
        public int RosinId { get; set; }

        // Resin
        public int ResinId { get; set; }

        // Shatter
        public int ShatterId { get; set; }

        // Displays for Name of product and URL image
        [Display(Name = "Type Name of product")]
        public string TypeName { get; set; }

        [Display(Name = "Image of product")]
        public string UrlImage { get; set; }

      
    }
}