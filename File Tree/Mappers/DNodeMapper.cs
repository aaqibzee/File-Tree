using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLogic.BusinessModels;
using File_Tree.Models;

namespace File_Tree.Mappers
{
    public static class DNodeMapper
    {
        public static DNode Map(this DNode node, DNodeModel model)
        {
            node.DirName = model.DirName;
            node.Files = model.Files;
            node.Level = model.Level;

            if (model.Directories != null)
            {
                node.Directories = new List<DNode>();
                foreach (var dir in model.Directories)
                {
                    node.Directories.Add(new DNode()
                    {

                    }.Map(dir));
                }
            }

            return node;
        }
    }
}