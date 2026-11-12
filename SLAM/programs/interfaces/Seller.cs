namespace SLAM.programs.interfaces
{
    public class Seller : IStats
    {
        public string Name { get; }
        public List<double> Sales { get; }

        public Seller(string name)
        {
            Name = name;
            Sales = new();
        }

        public double GetAverage()
        {
            double sum = 0;
            for (int i = 0; i < Sales.Count; i++)
                sum += Sales[i];

            return sum / Sales.Count;
        }

        public double GetStandardDeviation()
        {
            double average = GetAverage();
            double sum = 0.0;

            for (int i = 0; i < Sales.Count; i++)
            {
                double diff = Sales[i] - average;
                sum += diff * diff;
            }

            double variance = sum / Sales.Count;
            double standardDeviation = Math.Sqrt(variance);

            return standardDeviation;
        }
    }
}
