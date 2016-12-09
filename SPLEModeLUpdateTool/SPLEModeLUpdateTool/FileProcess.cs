using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SPLEModeLUpdateTool
{
    //class public yapıldı
    public class FileProcess
    {
        
        private static string[] feature_element;
        public static string[] readFeature(string txtfilepath)
        {
            string text = File.ReadAllText(txtfilepath);
            text = text.Substring(117);
            if (text!=null)
            {
                feature_element = text.Split(',');
            }
            int loop_count = feature_element.Length;
            int a = 0;
            string[] feature_arr=new string[loop_count / 6];
            for (int i = 0; i < loop_count / 6; i++)
            {

                for (int j = 0; j < 6; j++)
                {
                    if (j==0 || j==2)
                    {
                        feature_arr[i] = feature_arr[i] + feature_element[a] + ",";
                    }
                    a++;
                }
            }
            return feature_arr;


        }
        public static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
        }
    }
}
