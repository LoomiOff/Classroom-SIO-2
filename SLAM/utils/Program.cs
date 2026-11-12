namespace SLAM.utils
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


            ConsoleSelector selector = new ConsoleSelector("Liste des programmes");
            for (int i = 0; i < PROGRAMS.Count; i++)
            {
                IProgram program = PROGRAMS[i];
                selector.AddOption(program.GetName(), () => {
                    program.Execute();
                    Utils.WaitForInput("Le programme est terminé. (Entrer pour continuer)");
                });
            }

            selector.Execute(loop: true);
        }

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
    }
}