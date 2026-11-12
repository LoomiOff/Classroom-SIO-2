namespace SLAM.programs.interfaces
{
    public class Student : IStats
    {
        public string Name { get; }
        public List<double> Marks { get; }

        public Student(string name, List<double> marks)
        {
            Name = name;
            Marks = marks;
        }

        public Student(string name)
        {
            Name = name;
            Marks = new();
        }

        public double GetAverage()
        {
            double sum = 0;
            for (int i = 0; i < Marks.Count; i++)
                sum += Marks[i];

            return sum / Marks.Count;
        }

        public double GetStandardDeviation()
        {
            double average = GetAverage();
            double sum = 0.0;

            for (int i = 0; i < Marks.Count; i++)
            {
                double diff = Marks[i] - average;
                sum += diff * diff;
            }

            double variance = sum / Marks.Count;
            double standardDeviation = Math.Sqrt(variance);

            return standardDeviation;
        }
    }
}
