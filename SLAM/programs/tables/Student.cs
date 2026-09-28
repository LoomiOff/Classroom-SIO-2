namespace SLAM.programs.Tables
{
    public class Student
    {

        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        #region Getters

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        #endregion
    }
}
