using SLAM.programs;

namespace SLAM
{
    public static class Program
    {

        public static List<IProgram> PROGRAMS = new List<IProgram>();

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            LoadPrograms();

            if (PROGRAMS.Count == 0)
            {
                Utils.PrintError("Impossible de démarrer avec aucun programme.");
                return;
            }

            while (true)
            {
                ShowPrograms();

                IProgram? selectedProgram = AskProgram();
                Console.Clear();

                if (selectedProgram == null) break;
                selectedProgram.Execute();

                Utils.PrintSuccess($"Le programme {selectedProgram.GetName()} est terminé. (Appuyer pour continuer)");
                Utils.WaitForInput();
                Console.Clear();
            }
        }

        #region Private

        private static void LoadPrograms()
        {
            var programTypes = typeof(IProgram)
                .Assembly
                .GetTypes()
                .Where(type =>
                    typeof(IProgram).IsAssignableFrom(type) &&
                    type is { IsInterface: false, IsAbstract: false });

            foreach (var type in programTypes)
            {
                if (Activator.CreateInstance(type) is IProgram program)
                {
                    PROGRAMS.Add(program);
                }
            }

            Utils.Print($"Initialisation avec {PROGRAMS.Count()} programmes.");
        }


        private static void ShowPrograms()
        {
            Utils.Print("0: Stopper le programme.");

            for (int i = 0; i < PROGRAMS.Count; i++)
            {
                IProgram program = PROGRAMS[i];
                Utils.Print($"{i + 1}: {program.GetName()}.");
            }
        }

        private static IProgram? AskProgram()
        {
            int selectedIndex = Utils.ReadInt("Quels programmes désirez-vous executer ? (Entrer l'index)");
            while (selectedIndex < 0 || selectedIndex > PROGRAMS.Count)
            {
                Utils.PrintError("Merci d'entrer un index valide.");
                selectedIndex = Utils.ReadInt("");
            }

            if (selectedIndex == 0) return null;
            return PROGRAMS[selectedIndex - 1];
        }

        #endregion
    }
}