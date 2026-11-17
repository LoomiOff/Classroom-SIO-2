using Microsoft.VisualStudio.TestTools.UnitTesting;
using SLAM.utils;

namespace SLAM.programs.dictionnary
{
    public class DictonnaryProgram : IProgram
    {
        public void Execute()
        {

            Intervenant intervenant = new Intervenant("Billy", 11.0);
            Mission mission = new Mission("Test", "test", intervenant, new());

            DateOnly date1 = new DateOnly(2007, 4, 4);
            mission.AddWorkedHour(date1, 5);
            int nbHours = mission.WorkedHours[date1];

            Assert.IsTrue(nbHours == 5, "résultat non conforme");

            DateOnly date2 = new DateOnly(2007, 4, 6);
            mission.AddWorkedHour(date2, 9);
            nbHours = mission.WorkedHours[date2];

            Assert.IsTrue(nbHours == 8, "résultat non conforme");
        }
    }
}
