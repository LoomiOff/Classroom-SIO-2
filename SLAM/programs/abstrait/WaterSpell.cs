using SLAM.utils;

namespace SLAM.programs.abstrait
{
    public class WaterSpell : Spell
    {
        public WaterSpell() : base("Sort d'eau") {}

        protected override void OnCast()
        {
            Utils.Print("Un jet d'eau apparait !");
        }
    }
}
