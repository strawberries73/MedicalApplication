using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicalApplication.Models
{
    public class CannabisPlantBaseViewModel
    {
        //Cannabis Plant ID applies to seed or clone
        [Key]
        public int PlantId { get; set; }

        // Types diferentiated by THC, CBD or Hybrid
        public int PlantTypeID { get; set; }

        // Name of strain
        [Display(Name = "Type name of cannabis strain")]
        public string TypeName { get; set; }

        // Cannabis flower image
        [Display(Name = "Image of cannabis flower")]
        public string UrlFlower { get; set; }

        // Information link for genetics of said strain
        [Display(Name = "Information on the genetics")]
        public string UrlInfo { get; set; }

    }
}