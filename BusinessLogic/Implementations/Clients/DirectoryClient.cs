using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.BusinessModels;
using BusinessLogic.Interfaces;

namespace BusinessLogic.Implementations.Clients
{
    public class DirectoryClient : IDirectoryClient
    {
        public DNodeModel GetDirectoryStructure(DirectoryInfo info, int level = 0)
        {
            DNodeModel node = new DNodeModel();
            node.DirName = info.Name;
            node.Level = level;

            var files = info.GetFiles();
            if (files.Count() > 0)
            {
                node.Files = new List<string>();
                for (int i = 0; i < files.Count(); i++)
                {
                    node.Files.Add(files[i].Name);
                }
            }

            var dirs = info.GetDirectories();
            if (dirs.Count() > 0)
            {
                node.Directories = new List<DNodeModel>();
                ++level;
                for (int i = 0; i < info.GetDirectories().Count(); i++)
                {
                    node.Directories.Add(GetDirectoryStructure(dirs[i], level));
                }
            }
            return node;
        }
    }
}
