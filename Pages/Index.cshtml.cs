using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CarpetCostCalculator.Operations;
using CarpetCostCalculator.Model;

namespace CarpetCostCalculator.Pages
    
{
    [BindProperties]
    public class IndexModel : PageModel
    {

        public Carpet Carpet { get; set; }

        public void OnGet()
        {
            this.Carpet = new Carpet();
        }
        
        public void OnPost(Carpet carpet)
        {
            if (ModelState.IsValid)
            {
                carpet.RoomArea = CarpetOperations.CalcRoomArea(carpet.Width, carpet.Length);
                carpet.FinalCost = CarpetOperations.TotalInstallCost(carpet);
                carpet.Results = CarpetOperations.RoomAreaResults(carpet.RoomArea, carpet.FinalCost);

                //After calculation, assign the incoming model "carpet" to
                //the public property "Carpet" of the IndexModel
                this.Carpet = carpet;
            }
        }
    }

    
}