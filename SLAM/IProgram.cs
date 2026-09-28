namespace SLAM
{
    public interface IProgram
    {
        public string GetName()
        {
            return GetType().Name;
        }

        public abstract void Execute();
    }
}
