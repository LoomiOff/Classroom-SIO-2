using SLAM.utils;

namespace SLAM.programs.heritages
{
    public class Product
    {
        protected readonly string reference;
        protected readonly string name;
        protected readonly int price;

        public Product(string reference, string name, int price)
        {
            this.reference = reference;
            this.name = name;
            this.price = price;
        }

        public void Display()
        {
            Utils.Print($"- Référence: {reference}");
            Utils.Print($"- Nom: {name}");
            Utils.Print($"- prix de vente: {price}€");
        }

        public string GetReference() { return reference; }
        public string GetName() { return name; }
        public int GetPrice() { return price; }
    }
}
