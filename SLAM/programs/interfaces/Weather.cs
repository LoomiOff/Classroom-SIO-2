namespace SLAM.programs.interfaces
{
    public class Weather : IStats
    {
        public List<double> Temperatures { get; } = new List<double>();

        public double GetAverage()
        {
            double sum = 0;
            for (int i = 0; i < Temperatures.Count; i++)
                sum += Temperatures[i];

            return sum / Temperatures.Count;
        }

        public double GetStandardDeviation()
        {
            double average = GetAverage();
            double sum = 0.0;

            for (int i = 0; i < Temperatures.Count; i++)
            {
                double diff = Temperatures[i] - average;
                sum += diff * diff;
            }

            double variance = sum / Temperatures.Count;
            double standardDeviation = Math.Sqrt(variance);

            return standardDeviation;
        }
    }
}
