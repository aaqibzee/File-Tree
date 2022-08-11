using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace File_Tree.Models
{
    public class DNode
    {
        public string DirName { get; set; }
        public int Level { get; set; }
        public List<string> Files { get; set; }
        public List<DNode> Directories { get; set; }
    }
}