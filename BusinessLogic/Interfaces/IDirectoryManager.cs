using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.BusinessModels;

namespace BusinessLogic.Interfaces
{
    public interface IDirectoryManager
    {
        DNodeModel GetSmallDirectoryStructure();
        DNodeModel GetLargeDirectoryStructure();
    }
}
