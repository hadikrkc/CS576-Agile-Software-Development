using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SPLEModeLUpdateTool.Tests
{
    [TestClass]
    public class McmParserTest
    {
        
        [TestMethod]
        public void Test_XmlParsing()
        {
            McmParser Xmlpars = new McmParser("SPLE\\",  "3D.mcm");
            Xmlpars.XmlParsing();
            //Console.WriteLine(System.IO.Directory.Exists("modelparserresult"));
            Console.WriteLine(System.IO.Directory.Exists("modelparserresult"));
            if (!System.IO.Directory.Exists("modelparserresult")) { Assert.IsFalse(true); }
            else { Assert.IsFalse(false); }
            
        }
        [TestMethod]
        public void Test_WriteXmlNewValues()
        {
            McmParser Xmlpars = new McmParser("SPLE\\", "3D.mcm");
            Xmlpars.WriteXmlNewValues();
            //Console.WriteLine(System.IO.Directory.Exists("modelparserresult"));
            Console.WriteLine(System.IO.Directory.Exists("modelparserresult"));
            if (!System.IO.Directory.Exists("modelparserresult")) { Assert.IsFalse(true); }
            else { Assert.IsFalse(false); }

        }
    }
}
