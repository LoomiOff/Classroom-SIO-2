using SLAM.utils;

namespace SLAM.programs.heritages
{
    public class FoodProgram : IProgram
    {
        public void Execute()
        {
            string meatName = Utils.ReadString("Entrer un nom de viande.");
            int nutritionalValue = Utils.ReadInt("Entrer la valeur nutrionnelle.");
            string cookingValue = Utils.ReadString("Entrer une cuisson ?");
            Meat mf = new Meat(meatName, nutritionalValue, cookingValue);

            mf.Eat();

            string rottenName = Utils.ReadString("Entrer un nom de fruit.") + " Avarié";
            nutritionalValue = Utils.ReadInt("Entrer la valeur nutrionnelle.");
            RottenFood rf = new RottenFood(rottenName, nutritionalValue);

            rf.Eat();
        }
    }
}
