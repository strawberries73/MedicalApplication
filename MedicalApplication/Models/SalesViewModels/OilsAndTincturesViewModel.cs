using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicalApplication.Models.ViewModels
{
    public class OilsAndTincturesViewModel
    {
        [Key]
        //Oils
        public int OralDropId { get; set; }
        public int OralSprayId { get; set; }
        public int CapsulesId { get; set; }
        public int StripsId { get; set; }

        // Tinctures
        public int TintureCapsId { get; set; }
        public int TinctureDropsId { get; set; }

        // Displays for Name of product and URL image
        [Display(Name = "Type Name of product")]
        public string TypeName { get; set; }

        [Display(Name = "Image of product")]
        public string UrlImage { get; set; }
    }
}