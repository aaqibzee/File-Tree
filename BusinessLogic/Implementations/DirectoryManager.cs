using System.IO;
using BusinessLogic.BusinessModels;
using BusinessLogic.Constants;
using BusinessLogic.Interfaces;


namespace BusinessLogic.Implementations
{
    public class DirectoryManager : IDirectoryManager
    {
        

        private IDirectoryClient _directoryClient;
        public DirectoryManager(IDirectoryClient directoryClient)
        {
            _directoryClient = directoryClient;
        }
        public DNodeModel GetSmallDirectoryStructure()
        {
            return _directoryClient.GetDirectoryStructure(new DirectoryInfo(CommonConstants.ShortPath));
        }
        public DNodeModel GetLargeDirectoryStructure()
        {
            return _directoryClient.GetDirectoryStructure(new DirectoryInfo(CommonConstants.LargePath));
        }
    }
}
