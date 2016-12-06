using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace SPLEModeLUpdateTool
{
    public class McmParser
    {
        string spath, sfile;

        public McmParser(string path, string file)
        {
            spath = path;
            sfile = file;
        }

        public void WriteXmlNewValues()
        {

            string kayitdosya;
            string sline = "";

            XmlDocument xmlVerisi = new XmlDocument();
            xmlVerisi.Load(spath + "\\model\\chain\\" + sfile);

            XmlNodeList xmltransition = xmlVerisi.GetElementsByTagName("transitions");
            if (!System.IO.Directory.Exists("modelparserresult"))
            {
                MessageBox.Show("modelparserresult folder ı yok !!!\nLütfen Önce XmlParsing Methodunu çalıştırınız...");
                return;
            }

            kayitdosya = "modelparserresult\\" + sfile.Substring(0, sfile.IndexOf(".")) + ".txt";
            StreamReader reader = new StreamReader(kayitdosya);
            char[] delimeterChars = { ',' };

            while (sline != null)
            {
                sline = reader.ReadLine();

                if (sline != null)
                {
                    string[] swords = sline.Split(delimeterChars);

                    foreach (XmlNode node2 in xmltransition)
                    {
                        XmlNode item = node2.SelectSingleNode("//transitions");
                        if (node2.Attributes["targetState"].Value == swords[1])
                        {
                            node2.LastChild.LastChild.Attributes["value"].Value = swords[2];
                        }
                    }
                    xmlVerisi.Save(spath + "\\model\\chain\\" + sfile);
                }
            }
            reader.Close();
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
