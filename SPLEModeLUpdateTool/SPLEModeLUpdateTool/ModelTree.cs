﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLEModeLUpdateTool
{
    public class ModelTree
    {
        public string parent { set; get; }
        //public List<string> childs = new List<string>();
        public string[] childs { set; get; }
        public double childvalue { set; get; }

        public ModelTree()
        {
            childs = childs;
            parent = parent;
            childvalue = childvalue;
        }

    }

}
