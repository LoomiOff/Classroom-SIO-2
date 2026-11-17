using SLAM.utils;

namespace SLAM.programs.polymorph
{
    public class BuyableProduct : Product
    {
        public double BuyPrice { get; set; }

        public BuyableProduct(string reference, double sellPrice, double buyPrice) : base(reference, sellPrice)
        {
            BuyPrice = buyPrice;
        }

        public override double Cost()
        {
            return BuyPrice;
        }

        public override void Display()
        {
            Utils.Print("=== Produit Acheté ===");
            base.Display();
            Utils.Print($"Prix d'achat: {BuyPrice}€");
        }
    }
}
