namespace SLAM.programs.exceptions
{
    public class Product
    {
        private string name;
        private int quantity;
        private int minQuantity;

        public Product(string name, int quantity, int minQuantity)
        {
            this.name = name;
            this.quantity = quantity;
            this.minQuantity = minQuantity;

            CheckQuantityMin();
        }

        public string GetName() { return name; }
        public int GetQuantity() { return quantity; }
        public int GetMinQuantity() { return minQuantity; }

        public void SetName(string name) { this.name = name; }
        public void SetMinQuantity(int quantity) { this.minQuantity = quantity; }
        public void SetQuantity(int quantity)
        {
            this.quantity = Math.Max(0, quantity);
            CheckQuantityMin();
        }

        public void AddQuantity(int quantity) { SetQuantity(this.quantity + quantity); }
        public void RemoveQuantity(int quantity) { SetQuantity(this.quantity - quantity); }

        private void CheckQuantityMin()
        {
            if (quantity >= minQuantity) return;
            throw new ProductQuantityMinException(this);
        }
    }
}
