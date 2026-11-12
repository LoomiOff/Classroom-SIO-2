using SLAM.utils;

namespace SLAM.programs.heritages
{
    public class HeritageProgram : IProgram
    {
        public void Execute()
        {
            ManufacturedProduct pf;
            BuyableProduct pa;
            pf = new ManufacturedProduct("f01", "réveil matin", 150, 1, 10, 50);
            pa = new BuyableProduct("a01", "montre bracelet", 75, 1, 45);

            Utils.Print("Affichage d'un produit fabriqué:");
            pf.Display();

            Utils.Print("Affichage d'un produit acheté:");
            pa.Display();
        }
    }
}
