using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.BusinessModels;

namespace BusinessLogic.Interfaces
{
    public interface IDirectoryClient
    {
        DNodeModel GetDirectoryStructure(DirectoryInfo info, int level = 0);
    }
}
