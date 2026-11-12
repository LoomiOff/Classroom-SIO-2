using SLAM.utils;

namespace SLAM.programs.heritages
{
    public class BuyableProduct : Product
    {
        private readonly int supplierId;
        private readonly int supplierPrice;

        public BuyableProduct(
            string reference, string name, int price,
            int supplierId, int supplierPrice
        ) : base(reference, name, price)
        {
            this.supplierId = supplierId;
            this.supplierPrice = supplierPrice;
        }

        public new void Display()
        {
            base.Display();
            Utils.Print($"- Numéro de fournisseur: {supplierId}");
            Utils.Print($"- Prix d'achat: {supplierPrice}€");
        }

        public int GetSupplierId() { return supplierId; }
        public int GetSupplierPrice() { return supplierPrice; }
    }
}
