using System.Drawing;

namespace SLAM.programs.heritages
{
    public class Meat : Food
    {
        private readonly string cooking;

        public Meat(string name, int nutritional, string cooking) : base(name, nutritional)
        {
            this.cooking = cooking;
        }

        public new void Eat()
        {
            base.Eat();
            Utils.PrintSuccess($"La cuisson était {cooking}.");
        }

        public string GetCooking() {  return cooking; }
    }
}
