namespace Serialisation.classes
{
    [Serializable]
    public class Voiture
    {
        public string Immatriculation { get; set; } = string.Empty;
        public string Modele { get; set; } = string.Empty;
        public string Couleur { get; set; } = string.Empty;
        public int NbKm { get; set; }
        public DateTime DateSortie { get; set; }

        public Voiture() {}

        public Voiture(string immatriculation, string modele, string couleur, int nbKm, DateTime dateSortie)
        {
            Immatriculation = immatriculation;
            Modele = modele;
            Couleur = couleur;
            NbKm = nbKm;
            DateSortie = dateSortie;
        }
    }
}
