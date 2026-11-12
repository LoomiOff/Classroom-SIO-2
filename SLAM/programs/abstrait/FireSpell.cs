using SLAM.utils;

namespace SLAM.programs.abstrait
{
    public class FireSpell : Spell
    {
        public FireSpell() : base("Sort de feu") {}

        protected override void OnCast()
        {
            Utils.Print("Boom énorme explosion de feu");
        }
    }
}
