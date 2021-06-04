using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicalApplication.Models.ViewModels
{
    public class CuredFlowerViewModel
    {
        [Key]

        public int FlowerId { get; set; }

        public int PreRollId { get; set; }

        public int PreGroundId { get; set; }

        public int Keif { get; set; }

        // Displays for Name of product and URL image
        [Display(Name = "Type Name of strain")]
        public string TypeName { get; set; }

        [Display(Name = "Flower image")]
        public string UrlImage { get; set; }

    }
}