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
                string[] childandvalue = File.ReadAllLines("modelparserresult\\" + FileProcess.RemoveSpecialCharacters(parent_child[0]) + ".txt");
                for (int k = 0; k < childandvalue.Length; k++)
                {
                    string tmp = childandvalue[k].Split(',').ElementAt(0) + "," + childandvalue[k].Split(',').ElementAt(1) + ",0";
                    childandvalue[k] = tmp;
                }

                for (int i = 0; i < childandvalue.Length; i++)
                {
                    for (int j = 0; j < childs_arr.Length; j++)
                    {
                        if (childandvalue[i].Split(',').ElementAt(0) == (childs_arr[j]))
                        {
                            string str = childandvalue[i].Split(',').ElementAt(0) + "," + childandvalue[i].Split(',').ElementAt(1) + "," + childvalueList(childs_arr.Length).ElementAt(a).ToString();
                            childandvalue[i] = str;
                            a++;
                        }
                       
                    }

                }
                File.WriteAllLines("modelparserresult\\" + FileProcess.RemoveSpecialCharacters(parent_child[0]) + ".txt", childandvalue);
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

        public static void updateModel_new()
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
                string[] childandvalue = File.ReadAllLines("modelparserresult\\" + FileProcess.RemoveSpecialCharacters(parent_child[0]) + ".txt");
                
                for (int i = 0; i < childandvalue.Length; i++)
                {
                    bool flag = false;
                    for (int j = 0; j < childs_arr.Length; j++)
                    {
                        if (childandvalue[i].Split(',').ElementAt(0) == (childs_arr[j]))
                        {
                            string str = childandvalue[i].Split(',').ElementAt(0) + "," + childandvalue[i].Split(',').ElementAt(1) + "," + childandvalue[i].Split(',').ElementAt(2);
                            childandvalue[i] = str;
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        string str = childandvalue[i].Split(',').ElementAt(0) + "," + childandvalue[i].Split(',').ElementAt(1) + ",0";
                        childandvalue[i] = str;
                    }

                }
                double total = 0;
                for (int k = 0; k < childandvalue.Length; k++)
                {
                    total = total + Convert.ToDouble(childandvalue[k].Split(',').ElementAt(2));
                }
                double lastvalue=0;
                double childvalue;
                int c = 0;
                for (int l = 0; l < childandvalue.Length; l++)
                {
                    childvalue = ChildValuenew(Convert.ToDouble(childandvalue[l].Split(',').ElementAt(2)), 1 - total);
                   
                    if (childvalue!=0)
                    {
                        c++;
                    }
                    if (c == childs_arr.Length&&childs_arr.Length!=1)
                    {
                        string str = childandvalue[l].Split(',').ElementAt(0) + ',' + childandvalue[l].Split(',').ElementAt(1) + ',' + (1- Math.Round(lastvalue,3)).ToString();
                        childandvalue[l] = str;
                    }
                    else
                    {
                        string str = childandvalue[l].Split(',').ElementAt(0) + ',' + childandvalue[l].Split(',').ElementAt(1) + ',' + childvalue.ToString();
                        childandvalue[l] = str;
                    }
                    lastvalue = lastvalue + childvalue;
                }
                File.WriteAllLines("modelparserresult\\" + FileProcess.RemoveSpecialCharacters(parent_child[0]) + ".txt", childandvalue);

            }
        }
        static double ChildValuenew(double oldvalue,double deletevalue)
        {
            double newValue = 0;
            newValue = oldvalue * (1 / (1 - deletevalue));
            return Math.Round(newValue,3);
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

