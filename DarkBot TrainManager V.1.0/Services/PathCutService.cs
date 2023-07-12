using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
