using SLAM.utils;

namespace SLAM.programs.Collections
{
    public class CardShuffleProgram : IProgram
    {
        public void Execute()
        {
            List<String> cards = new List<string>();

            while (true)
            {
                Utils.Print($"Vous possédez actuellement {cards.Count} cartes dans votre deck.");
                Utils.Print("================================");
                Utils.Print("0: Quittez.");
                Utils.Print("1: Tirer une carte.");
                Utils.Print("2: Ajouter une carte.");
                Utils.Print("3: Mélanger les cartes.");
                Utils.Print("================================");

                foreach (var card in cards)
                {
                    Console.Write(card + " ");
                }

                int actionInput = Utils.ReadInt("Entrer l'action à executer.");

                switch (actionInput)
                {
                    case 0:
                        return;

                    case 1:
                        {
                            if (cards.Count == 0)
                            {
                                Utils.PrintError("Vous ne possédez pas de carte.");
                                Utils.WaitForInput();
                                break;
                            }

                            String card = cards.First();
                            cards.Remove(card);

                            Utils.PrintSuccess($"Vous avez tiré la carte {card} !");
                            Utils.WaitForInput();
                            break;
                        }

                    case 2: 
                        {
                            string card = Utils.ReadString("Entrer le nom de la carte à ajouter ?");
                            cards.Add(card);
                            Utils.PrintSuccess($"La carte '{card}' a était ajouté.");
                            Utils.WaitForInput();
                            break;
                        }

                    case 3:
                        {
                            cards = [.. cards.Shuffle()];
                            break;
                        }
                }

                Console.Clear();
            }
        }
    }
}
