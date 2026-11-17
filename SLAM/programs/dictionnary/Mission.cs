namespace SLAM.programs.dictionnary
{
    public class Mission
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Intervenant Intervenant { get; set; }
        public Dictionary<DateOnly, int> WorkedHours {  get; set; }

        public Mission(string name, string description, Intervenant intervenant, Dictionary<DateOnly, int> workedHours)
        {
            Name = name;
            Description = description;
            Intervenant = intervenant;
            WorkedHours = workedHours;
        }

        public void AddWorkedHour(DateOnly dateOnly, int hours)
        {
            if (WorkedHours.ContainsKey(dateOnly)) WorkedHours[dateOnly] += hours;
            else WorkedHours[dateOnly] = hours;
        }

        public int GetTotalWorkedHours()
        {
            int totalHours = 0;

            foreach (var hours in WorkedHours.Values)
            {
                totalHours += hours;
            }

            return totalHours;
        }
    }
}
