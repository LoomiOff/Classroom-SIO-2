using SLAM.utils;

namespace SLAM.programs.polymorph
{
    public class ManufacturedProduct : Product
    {
        public double HourlyProductionCost { get; set; }
        public double ProductionTime { get; set; }
        public double RawMaterialCost { get; set; }

        public ManufacturedProduct(string reference, double sellPrice, double hourlyProductionCost, double productionTime, double rawMaterialcost) : base(reference, sellPrice)
        {
            HourlyProductionCost = hourlyProductionCost;
            ProductionTime = productionTime;
            RawMaterialCost = RawMaterialCost;
        }

        public override double Cost()
        {
            return HourlyProductionCost * ProductionTime + RawMaterialCost;
        }

        public override void Display()
        {
            Utils.Print("=== Produit Fabriqué ===");
            base.Display();
            Utils.Print($"Coût horaire: {HourlyProductionCost}€" +
                $"\nTemps de production: {ProductionTime}H" +
                $"\nPrix des ressources: {RawMaterialCost}€");
        }
    }
}
