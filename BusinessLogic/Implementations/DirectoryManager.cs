using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.BusinessModels;
using BusinessLogic.Interfaces;

namespace BusinessLogic.Implementations
{
    public class DirectoryManager : IDirectoryManager
    {
        private const string smallDirPath = @"C:\Users\hp\Downloads\Visa Docs\Returns";
        private const string largeDirPath = "";

        private IDirectoryClient _directoryClient;
        public DirectoryManager(IDirectoryClient directoryClient)
        {
            _directoryClient = directoryClient;
        }
        public DNodeModel GetSmallDirectoryStructure()
        {
            return _directoryClient.GetDirectoryStructure(new DirectoryInfo(smallDirPath));
        }
        public DNodeModel GetLargeDirectoryStructure()
        {
            return _directoryClient.GetDirectoryStructure(new DirectoryInfo(largeDirPath));
        }
    }
}
