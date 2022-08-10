using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BusinessModels
{
    public class DNodeModel
    {
        public string DirName { get; set; }
        public int Level { get; set; }
        public List<string> Files { get; set; }
        public List<DNodeModel> Directories { get; set; }
    }
}
