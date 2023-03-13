namespace CarpetCostCalculator.Operations
{
    public static class CarpetOperations
    {

        public static decimal CalculateRoomArea(decimal length, decimal width)
        {
            return length * width;
        }

        public static decimal CalculateCarpetFinalCost(int carpetTypeCost, decimal areaOfCarpet, 
                                                        bool installation, bool underlay,       
                                  
                                                        decimal installationCost, decimal underlayCost,
                                                        decimal costPerSquareMeter)
        {
            decimal finalCost = carpetTypeCost * areaOfCarpet *costPerSquareMeter;
            if (installation)
                finalCost = finalCost + installationCost;

            if (underlay)
                finalCost = finalCost + underlayCost;
            return finalCost;
        }

    }
}
