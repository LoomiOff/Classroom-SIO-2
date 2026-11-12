using SLAM.programs.Tables;
using SLAM.utils;

namespace SLAM.programs.interfaces
{
    public class InterfaceProgram : IProgram
    {
        public void Execute()
        {
            Student std = new Student(Utils.ReadString("Entrer un nom d'élève"));
            Utils.PrintSuccess($"Création de l'élève {std.Name} avec {std.Marks.Count} notes.");

            ConsoleSelector selector = new ConsoleSelector($"Gestions des notes de {std.Name}");
            selector.AddOption("Ajouter une note", () =>
            {
                std.Marks.Add(Utils.ReadDouble("Entrer une note"));
            });
            selector.AddOption("Afficher les resultats", () =>
            {
                Utils.Print($"La moyenne de {std.Name} est {std.GetAverage()} et l'écart type est {std.GetStandardDeviation()}");
                Utils.WaitForInput();
            });
            selector.Execute();

            Console.Clear();

            Seller seller = new Seller(Utils.ReadString("Entrer un nom de vendeur"));
            Utils.PrintSuccess($"Création du vendeur {seller.Name} avec {seller.Sales.Count} ventes.");

            selector = new ConsoleSelector($"Gestions des ventes de {seller.Name}");
            selector.AddOption("Ajouter une vente", () =>
            {
                seller.Sales.Add(Utils.ReadDouble("Entrer une vente"));
            });
            selector.AddOption("Afficher les resultats", () =>
            {
                Utils.Print($"La moyenne des ventes de {seller.Name} est {seller.GetAverage()}€ et l'écart type est de {seller.GetStandardDeviation()}€");
                Utils.WaitForInput();
            });
            selector.Execute(loop: true);

            Weather weather = new Weather();

            selector = new ConsoleSelector($"Gestions des températures");
            selector.AddOption("Ajouter une température", () =>
            {
                weather.Temperatures.Add(Utils.ReadDouble("Entrer une température"));
            });
            selector.AddOption("Afficher les resultats", () =>
            {
                Utils.Print($"La moyenne des température est {weather.GetAverage()}°C et l'écart type est de {weather.GetStandardDeviation()}°C");
                Utils.WaitForInput();
            });
            selector.Execute(loop: true);
        }
    }
}
