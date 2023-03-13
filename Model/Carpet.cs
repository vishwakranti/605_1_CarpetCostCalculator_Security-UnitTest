
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CarpetCostCalculator.Model
{
    public class Carpet
    {
        [Display(Name = "Carpet Width")]
        public decimal Width { get; set; }

        [Display(Name = "Carpet Length")]
        public decimal Length { get; set; }

        [Display(Name = "Carpet Type")]
        public string CarpetType { get; set; }

        [Display(Name = "Carpet Types")]
        public List<SelectListItem> CarpetTypes { get; } = new List<SelectListItem>();

        [Display(Name = "Do you want us to install the Carpet")]
        public bool Installation { get; set; }

        [Display(Name = "Do you want Underlay for your Carpet")]
        public bool Underlay { get; set; }

        public const decimal InstallationCost = 20.0m;
        public const decimal UnderlayCost = 20.0m;
        public const decimal PerSquareMeter = 20.0m;

        [Display(Name = "Room Area")]
        public decimal AreaOfCarpet { get; set; }

        [Display(Name = "Final Cost")]
        public decimal Cost { get; set; }


        public Carpet()
        {
            CarpetTypes.Add(new SelectListItem { Value = "100", Text = "Cotton" });
            CarpetTypes.Add(new SelectListItem { Value = "200", Text = "Wool" });
            CarpetTypes.Add(new SelectListItem { Value = "300", Text = "Merino" });
        }
    }
}
