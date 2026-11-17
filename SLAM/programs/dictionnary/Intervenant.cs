namespace SLAM.programs.dictionnary
{
    public class Intervenant
    {
        public string Name { get; set; }
        public double HourlyRate { get; set; }

        public Intervenant(string name, double hourlyRate)
        {
            Name = name;
            HourlyRate = hourlyRate;
        }
    }
}