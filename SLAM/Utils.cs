using System.Security.Cryptography;
using System.Text;

namespace SLAM
{
    public static class Utils
    {
        #region Constantes

        public static ConsoleColor
            MESSAGE_COLOR = ConsoleColor.DarkYellow,
            SUCCESS_COLOR = ConsoleColor.DarkGreen,
            ERROR_COLOR = ConsoleColor.DarkRed;

        #endregion

        #region Console

        public static void WaitForInput()
        {
            AskQuestion("Appuyer sur entrer pour continuer...");
            Console.ReadLine();
        }

        public static double ReadDouble(string message)
        {
            bool parsed = false;
            double valeur = 0.0;
            while (!parsed)
            {
                AskQuestion($"{message} (Double)");
                parsed = double.TryParse(Console.ReadLine(), out valeur);
                if (!parsed) PrintError("La valeur entrée n'est pas un double.");
            }

            return valeur;
        }

        public static int ReadInt(string message)
        {
            bool parsed = false;
            int valeur = 0;
            while (!parsed)
            {
                AskQuestion($"{message} (Entier)");
                parsed = int.TryParse(Console.ReadLine(), out valeur);
                if (!parsed) PrintError("La valeur entrée n'est pas un entier.");
            }

            return valeur;
        }

        public static uint ReadUInt(string message)
        {
            bool parsed = false;
            uint valeur = 0;
            while (!parsed)
            {
                AskQuestion($"{message} (Entier Positif)");
                parsed = uint.TryParse(Console.ReadLine(), out valeur);
                if (!parsed) PrintError("La valeur entrée n'est pas un entier positif.");
            }

            return valeur;
        }

        public static string ReadString(string message)
        {
            while (true)
            {
                AskQuestion($"{message} (Chaîne de caractères)");
                string? texte = Console.ReadLine();
                if (texte != null)
                    return texte;
                PrintError("Texte vide !");
            }

        }

        public static byte ReadByte(string message)
        {
            bool parsed = false;
            byte valeur = 0;
            while (!parsed)
            {
                AskQuestion($"{message} (Octet)");
                parsed = byte.TryParse(Console.ReadLine(), out valeur);
                if (!parsed) PrintError("La valeur entrée n'est pas un octet.");
            }

            return valeur;
        }

        public static void Print(string message)
        {
            Console.ForegroundColor = MESSAGE_COLOR;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void PrintSuccess(string message)
        {
            Console.ForegroundColor = SUCCESS_COLOR;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void PrintError(string message)
        {
            Console.ForegroundColor = ERROR_COLOR;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        #endregion Console

        #region Generic

        public static void AskQuestion(string question)
        {
            int cursorX = Console.CursorLeft;
            int cursorY = Console.CursorTop;

            int bottomPosition = Console.WindowHeight - 1;

            // Clear line
            Console.SetCursorPosition(0, bottomPosition);
            Console.Write(new string(' ', Console.WindowWidth - 1));

            Console.SetCursorPosition(0, bottomPosition);
            Console.Write(question + "\t");
        }

        public static string HashString(string str)
        {
            using (SHA256 hashFunction = SHA256.Create())
            {
                byte[] hash = hashFunction.ComputeHash(Encoding.UTF8.GetBytes(str));

                // Create a new Stringbuilder to collect the bytes
                // and create a string.
                var sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data
                // and format each one as a hexadecimal string.
                for (int i = 0; i < hash.Length; i++)
                {
                    sBuilder.Append(hash[i].ToString("x2"));
                }

                // Return the hexadecimal string.
                return sBuilder.ToString();
            }
        }

        #endregion Generic
    }

}
