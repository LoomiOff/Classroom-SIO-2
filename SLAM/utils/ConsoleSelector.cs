namespace SLAM.utils
{
    public class ConsoleSelector
    {
        private readonly List<ConsoleOption> _options = new();
        private readonly string _title;

        public ConsoleSelector(string title = "Liste des actions", params ConsoleOption[] options)
        {
            _title = title;
            _options.AddRange(options);
        }

        public ConsoleSelector AddOption(string description, Action action)
        {
            _options.Add(new ConsoleOption(description, action));
            return this;
        }

        public void Execute(bool loop = false)
        {
            if (_options.Count == 0) return;

            bool running = true;
            while (running)
            {
                DisplayOptions(loop);

                int choice = ReadOptionIndex(loop);
                if (loop && choice == 0)
                {
                    running = false;
                    continue;
                }

                ConsoleOption selected = loop ? _options[choice - 1] : _options[choice];

                Console.Clear();
                selected.Action.Invoke();

                if (!loop) running = false;
            }
        }

        private void DisplayOptions(bool includeExit)
        {
            Console.Clear();
            Utils.Print(_title);

            for (int i = 0; i < _options.Count; i++)
            {
                int displayIndex = includeExit ? i + 1 : i;
                Utils.Print($"{displayIndex}: {_options[i].Description}");
            }

            if (includeExit)
            {
                Utils.Print("0: Quitter");
            }
        }

        private int ReadOptionIndex(bool includeExit)
        {
            int min = 0;
            int max = includeExit ? _options.Count : _options.Count - 1;

            while (true)
            {
                int selectIndex = Utils.ReadInt("Quelle action faire ? ");
                if (selectIndex >= min && selectIndex <= max)
                {
                    return selectIndex;
                }

                Utils.Print($"Erreur : veuillez saisir un nombre entre {min} et {max}.");
            }
        }
    }
}
