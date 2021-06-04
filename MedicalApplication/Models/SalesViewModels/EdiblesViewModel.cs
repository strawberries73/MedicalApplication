using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicalApplication.Models.ViewModels
{
    public class EdiblesViewModel
    {
        [Key]
        // Butter
        public int CannabutterId { get; set; }

        // Isolate
        public int IsolateId { get; set; }

        // Candy
        public int CandyId { get; set; }
        public int TypeId { get; set; }

        // Chocolate
        public int ChocolateId { get; set; }

        // Cookies
        public int CookieId { get; set; }

        // Soda
        public int SodaId { get; set; }

        // Displays for Name of product and URL image
        [Display(Name = "Type Name of product")]
        public string TypeName { get; set; }

        [Display(Name = "Image of product")]
        public string UrlImage { get; set; }
    }
}