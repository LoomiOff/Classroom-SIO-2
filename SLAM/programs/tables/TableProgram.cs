using SLAM.programs.Collections;
using SLAM.utils;

namespace SLAM.programs.Tables
{
    public class TableProgram : IProgram
    {
        public void Execute()
        {


            string classeName = Utils.ReadString("Entrer un nom de classe.");
            int nbStudent = Utils.ReadInt("Entrer le nombre d'élèves.");
            Classe classe = new Classe(classeName, nbStudent);

            Utils.PrintSuccess($"La classe '{classe.GetName()}' a était créée avec {classe.GetStudents().Length} élèves maximum.");

            for (int i = 0; i < nbStudent; i++)
            {
                Student student = new Student(
                    Utils.ReadString("Entrer un nom d'élève."),
                    Utils.ReadInt("Entrer l'age de l'élève.")
                );

                classe.AddStudent(student);
                Utils.PrintSuccess($"L'élève {student.GetName()} ({student.GetAge()} ans) a était ajouté à la classe");
            }

            Utils.PrintSuccess($"La classe possède désormais {classe.GetNbStudents()} élèves.");
        }
    }
}
