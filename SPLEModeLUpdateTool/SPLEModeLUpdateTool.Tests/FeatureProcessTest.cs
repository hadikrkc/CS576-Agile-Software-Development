﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPLEModeLUpdateTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLEModeLUpdateTool.Tests
{
    [TestClass()]
    public class FeatureProcessTest
    {
        [TestMethod()]
        public void Test_updatetreeviaFetureTest()
        {
            Boolean b;
            b = FeatureProcess.updatetreeviaFeture("txtfolder\\model_subtree.txt");//Path'i degistirin
            Console.WriteLine(b);
            if (b == true) { Assert.IsFalse(true); }
            else { Assert.IsFalse(false); }
        }

        [TestMethod()]
        public void Test_ConsistenceScheckTest()
        {
            Boolean b;
            b = FeatureProcess.consistenceCheck("txtfolder\\model_subtree.txt");//Path'i degistirin
            Console.WriteLine(b);
            if (b == true) { Assert.IsFalse(false); }
            else { Assert.IsFalse(true); }
        }
    }
}