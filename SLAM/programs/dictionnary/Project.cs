namespace SLAM.programs.dictionnary
{
    public class Project
    {
        public string Name { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public double BillPrice { get; set; }
        public List<Mission> Missions { get; set; }

        public Project(string name, DateOnly start, DateOnly end, double billPrice)
        {
            Name = name;
            StartDate = start;
            EndDate = end;
            BillPrice = billPrice;
            Missions = new List<Mission>();
        }

        public double CumulCoutMO()
        {
           double result = 0;
           foreach(Mission mission in Missions)
            {
                result += mission.GetTotalWorkedHours() * mission.Intervenant.HourlyRate;
            }

           return result;
        }

        public double MargeBruteCourante()
        {
            return BillPrice - CumulCoutMO();
        }
    }
}
