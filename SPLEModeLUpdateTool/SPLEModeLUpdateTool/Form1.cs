﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPLEModeLUpdateTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openfeaturemodel_bttn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                openfeaturemodel_tb.Text = fdlg.FileName;
            }
        }

        private void openmodel_bttn_Click(object sender, EventArgs e)
        {
            modelFolderBrowserDialog.ShowNewFolderButton = true;

            // Kontrolü göster
            DialogResult result = modelFolderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                openmodel_tb.Text = modelFolderBrowserDialog.SelectedPath;
            }
        }

        private void chkfeaturetree_bttn_Click(object sender, EventArgs e)
        {
            int a = 1;
           
            foreach (string item in FileProcess.readFeature(openfeaturemodel_tb.Text))
            {
                feature_list_rtb.AppendText(a+". feature -> "+item+"\n");
                a++;
            }
           
        }

        private void updatemodel_bttn_Click(object sender, EventArgs e)
        {
            string denemegthub;
            foreach (ModelTree item in ModelUpdate.CreateModelTree())
            {
                modeltreeshow_rtb.AppendText(item.parent.ToString().ToUpper() + "\n");
                foreach (var child in item.childs)
                {
                    modeltreeshow_rtb.AppendText("  --"+ child.ToString().ToUpper() + " =>  child_value: " + item.childvalue.ToString() + "\n");
                 }
            }
           
            
        }
    }
}
