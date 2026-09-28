namespace SLAM.programs.heritages
{
    public class ObjectProgram : IProgram
    {
        public void Execute()
        {
            Object obj = new object();
            Utils.Print($"Objet type : {obj.GetType()}");

            Food food = new Food("Pomme", 78);
            Utils.Print($"Food toString: {food.ToString()}");

            Object foodObj = food;
            Utils.Print($"food class equals food objet: {food.Equals(foodObj).ToString()}");

        }
    }
}
