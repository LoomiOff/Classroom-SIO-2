namespace SLAM.programs.Tables
{
    public class Classe
    {
        #region Attributs

        private string name;
        private Student[] students;

        private int nbStudents = 0;

        #endregion

        public Classe(string name, int maxStudent)
        {
            this.name = name;
            this.students = new Student[maxStudent];
        }

        #region Getters

        public string GetName() { return name; }

        public int GetNbStudents() { return nbStudents; }

        public Student[] GetStudents() { return students; }

        public Student? GetAccount(string studentName)
        {
            for (int i = 0; i < nbStudents; i++)
            {
                if (students[i] != null && students[i].GetName() == studentName)
                    return students[i];
            }

            return null;
        }

        #endregion

        #region Adders

        public void AddStudent(Student student)
        {
            if (students.Length == nbStudents) return;

            students[nbStudents++] = student;
        }

        #endregion
    }
}
