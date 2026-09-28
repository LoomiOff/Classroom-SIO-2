using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace SLAM.programs.Exceptions
{
    internal class ExceptionProgram : IProgram
    {
        public void Execute()
        {
            Example1();

            Utils.Print("Appuyer sur entrer pour passer à l'erreur suivante.");
            Utils.WaitForInput();
            Console.Clear();

            Example2();

            Utils.Print("Appuyer sur entrer pour passer à l'erreur suivante.");
            Utils.WaitForInput();
            Console.Clear();

            Example3();

            Utils.Print("Appuyer sur entrer pour passer à l'exception suivante");
            Utils.WaitForInput();
            Console.Clear();

            Example4();

            Utils.Print("Appuyer sur entrer pour passer à l'exception suivante");
            Utils.WaitForInput();
            Console.Clear();

            Example5();
        }

        #region Privates

        private void Example1()
        {
            try
            {
                string text = "Ceci est un test";
                int number = Convert.ToInt32(text);
            }
            catch (FormatException ex)
            {
                Utils.PrintError(ex.ToString());
            }
        }

        private void Example2()
        {
            try
            {
                string nullString = null;
                nullString.Replace(",", ".");
            }
            catch (NullReferenceException ex)
            {
                Utils.PrintError("Une erreur de référence nulle : " + ex.StackTrace);
            }
        }

        private void Example3()
        {
            try
            {
                //string[] tab = new string[5];
                //tab[5] = "Une erreur";

                string nullString = null;
                nullString.Replace(",", ".");
            }
            catch (NullReferenceException ex)
            {
                Utils.PrintError("Une erreur de référence nulle : " + ex.ToString());
            }
            catch (IndexOutOfRangeException ex)
            {
                Utils.PrintError("Une erreur de taille de notre tableau : " + ex.ToString());
            }
        }

        private void Example4()
        {
            string dbHost = Utils.ReadString("Entrer l'adresse de la base de donnée.");
            string dbUser = Utils.ReadString("Entrer l'utilisateur de la base de donnée.");
            string dbMdp = Utils.ReadString("Entrer le mot de passe de la base de donnée.");
            
            MySqlConnection connection = null;

            try
            {
                string query = "SELECT title FROM film LIMIT 10;";
                string connectionStr = $"Server={dbHost};Database=sakila;Uid={dbUser};Pwd={dbMdp};";

                connection = new MySqlConnection(connectionStr);
                connection.Open();
                Utils.PrintSuccess($"La connexion à la base de donnée {dbHost} est succès.");

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                Utils.Print("Voici la liste des films:");
                while (reader.Read())
                {
                    Utils.Print($"- {reader["title"]}");
                }
            }
            catch (Exception ex)
            {
                Utils.PrintError("Une erreur avec la base de donnée : " + ex.ToString());
            }
            finally
            {
                if (connection != null) connection.Close();
                Utils.PrintSuccess($"La connexion à la base de donnée {dbHost} a était fermé."); 
            }
        }

        private void Example5()
        {
            while (true)
            {
                double number = Utils.ReadDouble("Entrer un nombre pour la racine carré");

                try
                {
                    if (number <= 0) throw new ArgumentOutOfRangeException();
                    else Utils.PrintSuccess($"Le résultat de racine carré {number} = {Math.Sqrt(number)}");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Utils.PrintError($"Impossible avec le nombre {number} : {ex.ToString()}");
                    Utils.WaitForInput();
                    break;
                }
            }
        }

        #endregion
    }
}
