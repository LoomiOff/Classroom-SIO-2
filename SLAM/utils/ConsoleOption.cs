using System.Linq.Expressions;

namespace SLAM.utils
{
    public class ConsoleOption
    {
        public string Description { get; }
        public Action Action { get; }

        public ConsoleOption(string description, Action action)
        {
            Description = description;
            Action = action;
        }
    }
}
