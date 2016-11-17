using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLEModeLUpdateTool
{
    class FeatureProcess
    {
        public static void updatetreeviaFeture(string path)
        {
            string[] feature_arr = FileProcess.readFeature(path);
            string[] text = File.ReadAllLines("txtfolder\\model_subtree.txt");
            string parent_child;
            string[] childs_arr;
            int c = 0;
            for (int i = 0; i < text.Length; i++)
            {
                parent_child = text[i].Split(':').ElementAt(0);
                childs_arr = text[i].Split(':').ElementAt(1).Split(',');
                string chilstr = "";
                for (int j = c; j < feature_arr.Length; j++)
                {
                    if ((parent_child == feature_arr[j].Split(',').ElementAt(0)) && (feature_arr[j].Split(',').ElementAt(1) == "0"))
                    {
                        parent_child = "";
                        c = j;
                        break;

                    }
                    else if ((parent_child == feature_arr[j].Split(',').ElementAt(0)) && (feature_arr[j].Split(',').ElementAt(1) == "1"))
                    {

                        for (int k = 0; k < childs_arr.Length; k++)
                        {
                            for (int l = j; l < feature_arr.Length; l++)
                            {
                                if ((childs_arr[k] == feature_arr[l].Split(',').ElementAt(0) && (feature_arr[l].Split(',').ElementAt(1) == "0")))
                                {
                                    childs_arr[k] = "null";
                                    c = j;
                                    break;

                                }
                                else if ((childs_arr[k] == feature_arr[l].Split(',').ElementAt(0) && (feature_arr[l].Split(',').ElementAt(1) == "1")))
                                {
                                    chilstr = chilstr + childs_arr[k] + ",";
                                }
                            }
                        }
                        c = j;
                        break;
                    }
                }
                if (parent_child != "")
                {
                    CreateLogFile(parent_child + ":" + chilstr.TrimEnd(',') + "\n");
                }

            }
        }
        public static void CreateLogFile(string b)
        {

            if (!System.IO.File.Exists("txtfolder\\model_subtree_guncel.txt"))
                System.IO.File.WriteAllText("txtfolder\\model_subtree_guncel.txt", b);
            //Dosya = File.CreateText("txtfolder\\model_subtree_guncel.txt");
            else
            {
                File.AppendAllText("txtfolder\\model_subtree_guncel.txt", b);
            }

            //  Dosya.Write(b);
            //Dosya.Close();
        }
    }
}
