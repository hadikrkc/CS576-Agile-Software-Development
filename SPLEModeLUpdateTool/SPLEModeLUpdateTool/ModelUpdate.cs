using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLEModeLUpdateTool
{
    public class ModelUpdate
    {
        
        public static List<ModelTree> CreateModelTree()
        {
            List<ModelTree> model_tree_class = new List<ModelTree>();
            string[] text = File.ReadAllLines("txtfolder\\model_subtree.txt");
            string[] parent_child;
            // List<string> childs_arr=new List<string>();
            string[] childs_arr;
            double childvalue_;
            foreach (string line in text)
            {
                // Parent and child seperate
                // parent_child[0] => parent
                // parent_child[1] => child array
                parent_child = line.Split(':');
                childs_arr = parent_child[1].Split(',');
                /*foreach (string item in parent_child[1].Split(','))
                {
                    childs_arr.Add(item);
                }*/

                childvalue_ = 1 / Convert.ToDouble(childs_arr.Count());
                ModelTree modeltree = new ModelTree();
                modeltree.parent = parent_child[0];
                modeltree.childs = childs_arr;
                modeltree.childvalue = childvalue_;
                model_tree_class.Add(modeltree);
               // model_tree_class.Add(new ModelTree { parent = parent_child[0], childs= childs_arr, childvalue = childvalue_ });
                //childs_arr.Clear();

            }
            return model_tree_class;
        }
    }
}

