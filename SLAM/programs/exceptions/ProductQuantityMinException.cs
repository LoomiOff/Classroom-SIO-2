namespace SLAM.programs.exceptions
{
    public class ProductQuantityMinException : Exception
    {
        private readonly Product product;

        public ProductQuantityMinException(Product product)
        { 
            this.product = product; 
        }

        public Product getProduct() { return product; }
    }
}
