using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CarpetCostCalculator.Operations;
using CarpetCostCalculator.Model;

namespace CarpetCostCalculator.Pages
    
{
    [BindProperties]
    public class IndexModel : PageModel
    {

        public Carpet Carpet = new Carpet();
        
        public void OnGet()
        {

        }
        
        public void OnPost(Carpet carpet)
        {
            if(ModelState.IsValid)
            {
                Carpet.AreaOfCarpet = CarpetOperations.CalculateRoomArea(carpet.Width, carpet.Length);
                Carpet.Cost = CarpetOperations.CalculateCarpetFinalCost(Int32.Parse(carpet.CarpetType), 
                                                                        Carpet.AreaOfCarpet, 
                                                                        carpet.Installation,
                                                                        carpet.Underlay,
                                                                        Carpet.InstallationCost,
                                                                        Carpet.UnderlayCost, Carpet.PerSquareMeter);

            }
        }
    }

    
}