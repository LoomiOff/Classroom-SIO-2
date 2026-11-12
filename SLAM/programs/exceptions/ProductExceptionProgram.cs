using SLAM.utils;

namespace SLAM.programs.exceptions
{
    public class ProductExceptionProgram : IProgram
    {
        public void Execute()
        {
            Product product = new Product("Tomate", 100, 10);

            Utils.PrintSuccess($"Création du produit {product.GetName()} (quantité: {product.GetQuantity()}, min: {product.GetMinQuantity()}) !");
            Utils.WaitForInput();

            product.RemoveQuantity(50);
            Utils.PrintSuccess($"Suppresion de 50 {product.GetName()} ! (Reste: {product.GetQuantity()} {product.GetName()})");
            Utils.WaitForInput();

            try
            {
                Utils.PrintSuccess($"Suppresion de 50 {product.GetName()} !");
                product.RemoveQuantity(50);
            }
            catch (ProductQuantityMinException ex)
            {
                Utils.PrintError(ex.ToString());
            }
        }
    }
}
