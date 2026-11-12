using SLAM.utils;

namespace SLAM.programs.heritages
{
    public class Food
    {
        protected string name;
        protected int nutritional;

        public Food(string name, int nutritional)
        {
            this.name = name;
            this.nutritional = nutritional;
        }

        public void Eat()
        {
            Utils.PrintSuccess($"Miam miam, vous mangez {name} ! Vous ingurgitez {nutritional} nutriment(s).");
        }

        public string GetName() { return name; }
        public int GetNutritional() { return nutritional; }

        public void SetName(string name) { this.name = name; }
        public void SetNutritional(int nutritional) { this.nutritional = nutritional; }
    }
}
