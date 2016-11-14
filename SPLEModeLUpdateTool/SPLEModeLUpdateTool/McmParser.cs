using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace SPLEModeLUpdateTool
{
    class McmParser
    {
        string spath, sfile;

        public McmParser(string path, string file)
        {
            spath = path;
            sfile = file;
        }

        public void XmlParsing()
        {
            string target;
            string kayitdosya;
            
            XmlDocument xmlVerisi = new XmlDocument();
            xmlVerisi.Load(spath + "\\model\\chain\\"+sfile);
            XmlNodeList xmlNodeList = xmlVerisi.GetElementsByTagName("states"); 
            XmlNodeList xmltransition = xmlVerisi.GetElementsByTagName("transitions");

            if (!System.IO.Directory.Exists("modelparserresult"))
            System.IO.Directory.CreateDirectory("modelparserresult");
            kayitdosya = "modelparserresult\\" + sfile.Substring(0, sfile.IndexOf(".")) + ".txt";

            StreamWriter writer = new StreamWriter(kayitdosya);
                     
            foreach (XmlNode node in xmlNodeList)
            {

                string souter = node.OuterXml;
                
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(souter);

                string value = doc.SelectSingleNode("states/@uUID").Value;
                string name =  doc.SelectSingleNode("states/@name").Value;
                if (name == "State")
                    continue;
                foreach (XmlNode node2 in xmltransition)
                {
                    souter = node2.OuterXml;
                    doc.LoadXml(souter);
                    if (value == doc.SelectSingleNode("transitions/@targetState").Value)
                    {
                        target = doc.SelectSingleNode("transitions/probabilities/value/@value").Value;
                       
                        writer.WriteLine(name+"," + value +","+ target);

                    }

                }
            }

            writer.Close();


        }
        //input olarak mcm dosyasının adını alacak
        // model\chain pathden sonra gelenler alınacak
        //modelparserresult folder oluşturulacak. mcm resultlar parent name ine göre burada txt olarak tutulacak.
    }
}
