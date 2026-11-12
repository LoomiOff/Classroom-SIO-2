using SLAM.utils;

namespace SLAM.programs.abstrait
{
    public class SpellProgram : IProgram
    {
        public void Execute()
        {
            Spell fireSpell = new FireSpell();
            fireSpell.Cast();

            Utils.WaitForInput();

            Spell waterSpell = new WaterSpell();
            waterSpell.Cast();
        }
    }
}
