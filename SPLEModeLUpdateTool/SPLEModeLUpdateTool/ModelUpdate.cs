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
            string[] text = File.ReadAllLines("txtfolder\\model_subtree.txt");
            string[] parent_child;
            string[] childs_arr;
            double childvalue_;
            foreach (string line in text)
            {
                // Parent and child seperate
                // parent_child[0] => parent
                // parent_child[1] => child array
                parent_child = line.Split(':');
                childs_arr = parent_child[1].Split(',');
                childvalue_ = 1 / Convert.ToDouble(childs_arr.Length);
                //lstemail.Add("JOhn", "Smith", "Los Angeles");
                model_tree_class.Add(new ModelTree { parent = parent_child[0], childs = childs_arr, childvalue = childvalue_ });

            }
            return model_tree_class;
        }
    }
}

