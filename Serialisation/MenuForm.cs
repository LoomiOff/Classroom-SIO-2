using Serialisation.classes;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using System.Xml.Serialization;

namespace Serialisation
{
    public partial class MenuForm : Form
    {
        private static readonly string FILE_NAME = "voiture";

        public MenuForm()
        {
            InitializeComponent();
        }

        #region Serialiser
        private void btnSerialiseXML_Click(object sender, EventArgs e)
        {
            Voiture voiture = new Voiture("121GFT93", "Twingo", "verte", 1235, new DateTime(2004, 12, 12));

            XmlSerializer serializer = new XmlSerializer(typeof(Voiture));
            using (FileStream fichier = new FileStream(FILE_NAME + ".xml", FileMode.Create))
            {
                serializer.Serialize(fichier, voiture);
            }

            MessageBox.Show("Sérialisation XML réussie !");
        }

        private void btnSerialiseBin_Click(object sender, EventArgs e)
        {
            Voiture voiture = new Voiture("4444GT93", "Golf", "bleue", 12450, new DateTime(2004, 1, 11));
            using (FileStream fs = new FileStream(FILE_NAME + ".bin", FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(voiture.Immatriculation);
                writer.Write(voiture.Modele);
                writer.Write(voiture.Couleur);
                writer.Write(voiture.NbKm);
                writer.Write(voiture.DateSortie.ToBinary());
            }
            MessageBox.Show("Sérialisation Binaire réussie !");
        }


        private void btnSerialiseJSON_Click(object sender, EventArgs e)
        {
            Voiture voiture = new Voiture("3333AB75", "Clio", "rouge", 45000, new DateTime(2018, 5, 20));

            string jsonString = JsonSerializer.Serialize(voiture);
            File.WriteAllText(FILE_NAME + ".json", jsonString);

            MessageBox.Show("Sérialisation JSON réussie !");
        }

        private void btnSerialiseSOAP_Click(object sender, EventArgs e)
        {
            Voiture voiture = new Voiture("268AB75", "Renault", "vert", 15060, new DateTime(2012, 4, 21));

            using (FileStream fichier = new FileStream(FILE_NAME + ".sr", FileMode.Create))
            {
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fichier, voiture);
            }

            MessageBox.Show("Sérialisation SOAP réussie !");
        }

        #endregion
        #region Deserialise

        private void btnDeserialiseXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Voiture));
            using (FileStream fichier = new FileStream(FILE_NAME + ".xml", FileMode.Open))
            {
                Voiture? voiture = serializer.Deserialize(fichier) as Voiture;

                if (voiture != null)
                {
                    txtInput.Text = $"{voiture.Immatriculation}" +
                        $" - {voiture.Modele}" +
                        $" - {voiture.Couleur}" +
                        $" - {voiture.NbKm}" +
                        $" - {voiture.DateSortie.ToString()}";
                }
                else MessageBox.Show("Erreur Deserialisation XML");
            }
        }

        private void btnDeserialiseBin_Click(object sender, EventArgs e)
        {
            if (!File.Exists("voiture.bin"))
            {
                MessageBox.Show("Fichier binaire introuvable !");
                return;
            }

            Voiture voiture = new Voiture();

            using (FileStream fs = new FileStream(FILE_NAME + ".bin", FileMode.Open))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                voiture.Immatriculation = reader.ReadString();
                voiture.Modele = reader.ReadString();
                voiture.Couleur = reader.ReadString();
                voiture.NbKm = reader.ReadInt32();
                voiture.DateSortie = DateTime.FromBinary(reader.ReadInt64());
            }

            txtInput.Text = $"{voiture.Immatriculation}" +
               $" - {voiture.Modele}" +
               $" - {voiture.Couleur}" +
               $" - {voiture.NbKm}" +
               $" - {voiture.DateSortie.ToString()}";
        }

        private void btnDeserialiseJSON_Click(object sender, EventArgs e)
        {
            string jsonString = File.ReadAllText(FILE_NAME + ".json");
            Voiture? voiture = JsonSerializer.Deserialize<Voiture>(jsonString);

            if (voiture != null)
            {
                txtInput.Text = $"{voiture.Immatriculation}" +
                   $" - {voiture.Modele}" +
                   $" - {voiture.Couleur}" +
                   $" - {voiture.NbKm}" +
                   $" - {voiture.DateSortie.ToString()}";
            }
            else MessageBox.Show("Erreur Deserialisation JSON");
        }

        private void btnDeserialiseSOAP_Click(object sender, EventArgs e)
        {
            if (!File.Exists(FILE_NAME + ".sr"))
            {
                MessageBox.Show("Fichier SOAP introuvable !");
                return;
            }

            using (FileStream fichier = new FileStream(FILE_NAME + ".sr", FileMode.Open))
            {
                SoapFormatter sf = new SoapFormatter();
                Voiture? voiture = sf.Deserialize(fichier) as Voiture;

                if (voiture != null)
                {
                    txtInput.Text = $"{voiture.Immatriculation}" +
                        $" - {voiture.Modele}" +
                        $" - {voiture.Couleur}" +
                        $" - {voiture.NbKm}" +
                        $" - {voiture.DateSortie.ToString()}";
                }
                else MessageBox.Show("Erreur Désérialisation SOAP");
            }
        }

        #endregion
    }
}
