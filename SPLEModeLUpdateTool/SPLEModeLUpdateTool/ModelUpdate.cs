using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLEModeLUpdateTool
{
    class ModelUpdate
    {
        
        public static List<ModelTree> CreateModelTree()
        {
            List<ModelTree> model_tree_class = new List<ModelTree>();
            string[] text = File.ReadAllLines("C:\\txtfolder\\model_subtree.txt");
            string[] parent_child;
            string[] childs_arr;
            foreach (string line in text)
            {
                // Parent and child seperate
                // parent_child[0] => parent
                // parent_child[1] => child array
                parent_child = line.Split(':');
                childs_arr = parent_child[1].Split(',');
                //lstemail.Add("JOhn", "Smith", "Los Angeles");
                model_tree_class.Add(new ModelTree { parent = parent_child[0], childs = childs_arr, childvalue = 1 / childs_arr.Length });

            }
            return model_tree_class;
        }
    }
}

