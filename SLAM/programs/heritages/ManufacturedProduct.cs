using SLAM.utils;

namespace SLAM.programs.heritages
{
    public class ManufacturedProduct : Product
    {
        private readonly int workbenchId;
        private readonly int hoursNeeded;
        private readonly int rawMaterialsPrice;

        public ManufacturedProduct(
            string reference, string name, int price,
            int workbenchId, int hoursNeeded, int rawMaterialsPrice
        ) : base(reference, name, price)
        {
            this.workbenchId = workbenchId;
            this.hoursNeeded = hoursNeeded;
            this.rawMaterialsPrice = rawMaterialsPrice;
        }

        public new void Display()
        {
            base.Display();
            Utils.Print($"- Numéro atelier: {workbenchId}");
            Utils.Print($"- Nombre d'heure nécessaire: {hoursNeeded}H");
            Utils.Print($"- Coût des matières: {rawMaterialsPrice}€");
        }

        public int GetWorkBenchId() {  return workbenchId; }
        public int GetHoursNeeded() { return hoursNeeded; }
        public int GetRawMaterialsPrice() { return rawMaterialsPrice; }
    }
}
