namespace SLAM.programs.heritages
{
    public class RottenFood : Food
    {
        public RottenFood(string name, int nutritional) : base(name, nutritional) {}

        public new void Eat()
        {
            Utils.PrintError($"Vous avez mangé {name} ! Vous allez mourir !");
        }
    }
}
