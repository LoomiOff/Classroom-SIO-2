using SLAM.utils;

namespace SLAM.programs.abstrait
{
    public abstract class Spell
    {
        protected readonly string name;

        public Spell(string name)
        {
            this.name = name;
        }

        public string GetName() { return name; }

        public void Cast()
        {
            Utils.Print($"Le sort {name} vient d'être lancé.");
            OnCast();
            Utils.Print($"Le sort vient de se finir");
        }

        protected abstract void OnCast();
    }
}