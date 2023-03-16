
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CarpetCostCalculator.Model
{
    public class Carpet
    {
        [Display(Name = "Carpet Width")]
        public float Width { get; set; }

        [Display(Name = "Carpet Length")]
        public float Length { get; set; }

        [Display(Name = "Carpet Type")]
        public string CarpetType { get; set; }

        [Display(Name = "Carpet Types")]
        public List<SelectListItem> CarpetTypes { get; } = new List<SelectListItem>();

        [Display(Name = "Do you want us to install the Carpet")]
        public bool Installation { get; set; }

        [Display(Name = "Do you want Underlay for your Carpet")]
        public bool Underlay { get; set; }

        public const float InstallationCost = 20.0F;
        public const float UnderlayCost = 20.0F;
        public const float PerSquareMeter = 20.0F;

        [Display(Name = "Room Area")]
        public float RoomArea { get; set; }

        [Display(Name = "Final Cost")]
        public float FinalCost { get; set; }

        [Display(Name = "Results")]
        public string? Results { get; set; } //make this property nullable, so that ModelState.IsValid is still true on post


        public Carpet()
        {
            CarpetTypes.Add(new SelectListItem { Value = "100", Text = "Cotton" });
            CarpetTypes.Add(new SelectListItem { Value = "200", Text = "Wool" });
            CarpetTypes.Add(new SelectListItem { Value = "300", Text = "Merino" });
        }
    }
}
