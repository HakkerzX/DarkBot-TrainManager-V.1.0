using System;
using System.Linq;

namespace DarkBotTrainManager.Services
{
    public class PathCutService : IPathCutService
    {
        public string GetFolderNameFromPath(string path)
        {
            return String.Join(@"\", path.Split('\\').Reverse().Take(1));
        }
    }
}
