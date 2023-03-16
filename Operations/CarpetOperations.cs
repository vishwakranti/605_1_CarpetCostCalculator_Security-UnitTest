using CarpetCostCalculator.Model;

namespace CarpetCostCalculator.Operations
{
    public static class CarpetOperations
    {
        //Calculate the area of the room
        //Return room area
        public static float CalcRoomArea(float length, float width)
        {
            return length * width;
        }
        //Returns the room area and cost of carpet as a string to show on the result page
        //<Returns>Text of roomarea and TotalInstallationCost from below "Room Area" + "roomArea" + "Sqm $" + final cost;

        public static string RoomAreaResults(float roomArea, float finalCost)
        {
           // return string.Format("Room Area {0:N3} Sqm $ {1:N3}", roomArea, finalCost);
           return "Room Area " + roomArea + " Sqm $" + finalCost;
        }

        //Calculate the cost of the carpet installation including installation and underlay costs and carpet types
        //param name="carpet">input a carpet class</param> 
        //<returns>Total cost
        public static Single TotalInstallCost(Carpet carpet)
        {
            carpet.FinalCost = Int32.Parse(carpet.CarpetType) * carpet.RoomArea * Carpet.PerSquareMeter;

            if(carpet.Installation)
            {
                carpet.FinalCost = carpet.FinalCost + Carpet.InstallationCost;
            }

            if(carpet.Underlay)
            {
                carpet.FinalCost = carpet.FinalCost + Carpet.UnderlayCost;
            }

            return carpet.FinalCost;

        }


        public static float CalculateCarpetFinalCost(int carpetTypeCost, float areaOfCarpet, 
                                                        bool installation, bool underlay,       
                                  
                                                        float installationCost, float underlayCost,
                                                        float costPerSquareMeter)
        {
            float finalCost = carpetTypeCost * areaOfCarpet * costPerSquareMeter;
            if (installation)
                finalCost = finalCost + installationCost;

            if (underlay)
                finalCost = finalCost + underlayCost;
            return finalCost;
        }

    }
}
