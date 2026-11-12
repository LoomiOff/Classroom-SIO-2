namespace SLAM.utils
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
