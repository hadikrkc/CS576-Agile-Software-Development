using System.IO;
using System.Linq;

namespace SPLEModeLUpdateTool
{
   public class FeatureProcess
    {
        public static bool updatetreeviaFeture(string path)
        {
            string[] feature_arr = FileProcess.readFeature(path);
            string[] text = File.ReadAllLines("txtfolder\\model_subtree.txt");
            string parent_child;
            string[] childs_arr;
            int c = 0;
            bool flag = true;
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
                                else
                                {
                                    flag = false;
                                }
                            }
                        }
                        c = j;
                        break;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                if (parent_child != "")
                {
                    CreateLogFile(parent_child + ":" + chilstr.TrimEnd(',') + "\n");
                }

            }
            return flag;
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

        public static bool consistenceCheck(string path)
        {
            bool flag = true;
            string[] feature_arr = FileProcess.readFeature(path);
            string text = File.ReadAllText("txtfolder\\model_subtree.txt").ToLower();
            for (int i = 0; i < feature_arr.Length; i++)
            {
               
                    if (!(text.Contains(feature_arr[i].Split(',').ElementAt(0).ToLower())))
                    {
                        flag = false;
                        break;
                    } 
              
               
            }

            return flag;

        }
        public static void CreateNewTreeValue()
        {
            if (System.IO.Directory.Exists("modelparserresult"))
            {
                    
            }
        }
    }
}
