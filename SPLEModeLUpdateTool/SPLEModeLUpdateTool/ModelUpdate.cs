using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SPLEModeLUpdateTool
{
    public class ModelUpdate
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

        public static void updateModel()
        {

            List<ModelTree> model_tree_class = new List<ModelTree>();
            string[] text = File.ReadAllLines("txtfolder\\model_subtree_guncel.txt");
            string[] parent_child;
            string[] childs_arr;
            double childvalue_;
            foreach (string line in text)
            {
                parent_child = line.Split(':');
                childs_arr = parent_child[1].Split(',');
                int a = 0;
                string[] value = File.ReadAllLines("modelparserresult\\" + FileProcess.RemoveSpecialCharacters(parent_child[0]) + ".txt");
                for (int k = 0; k < value.Length; k++)
                {
                    string tmp = value[k].Split(',').ElementAt(0) + "," + value[k].Split(',').ElementAt(1) + ",0";
                    value[k] = tmp;
                }

                for (int i = 0; i < value.Length; i++)
                {
                    for (int j = 0; j < childs_arr.Length; j++)
                    {
                        if (value[i].Split(',').ElementAt(0) == (childs_arr[j]))
                        {
                            string str = value[i].Split(',').ElementAt(0) + "," + value[i].Split(',').ElementAt(1) + "," + childvalueList(childs_arr.Length).ElementAt(a).ToString();
                            value[i] = str;
                            a++;
                        }
                       
                    }

                }
                File.WriteAllLines("modelparserresult\\" + FileProcess.RemoveSpecialCharacters(parent_child[0]) + ".txt", value);
                /*
                 childvalue_ = 1 / Convert.ToDouble(childs_arr.Count());
                 ModelTree modeltree = new ModelTree();
                 modeltree.parent = parent_child[0];
                 modeltree.childs = childs_arr;
                 modeltree.childvalue = childvalue_;
                 model_tree_class.Add(modeltree);
                 */
                // model_tree_class.Add(new ModelTree { parent = parent_child[0], childs= childs_arr, childvalue = childvalue_ });
                //childs_arr.Clear();

            }
        }
        static List<double> childvalueList(int child)
        {
            List<double> deger = new List<double>();
            double C, D = 1.0;
            int counter = child;


            for (int i = 0; i < child; i++)
            {
                C = (D / counter);
                C = Math.Round(C, 3);
                deger.Add(C);
                D = D - C;

                counter = counter - 1;
            }

            return deger;
        }
    }
}

