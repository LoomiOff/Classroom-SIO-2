using SLAM.utils;

namespace SLAM.programs.polymorph
{
    public abstract class Product
    {
        public string Reference { get; set; }
        public double SellPrice { get; set; }

        public Product(string reference, double sellPrice)
        {
            Reference = reference;
            SellPrice = sellPrice;
        }

        public virtual double Cost() { return 0; }
        
        public virtual double Margin() { return SellPrice - Cost(); }

        public virtual void Display()
        {
            Utils.Print($"Reference: {Reference}" +
                $"\nPrix: {SellPrice}€" +
                $"\nCoût: {Cost()}€" +
                $"\nMarge: {Margin()}€");
        }

    }
}
