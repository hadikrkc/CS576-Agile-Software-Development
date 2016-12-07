using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (System.IO.File.Exists("txtfolder\\model_subtree_guncel.txt"))
                System.IO.File.Delete("txtfolder\\model_subtree_guncel.txt");
        }
        private bool flag = true;
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
                openmodelpath_tb.Text = modelFolderBrowserDialog.SelectedPath;
            }
        }

        private void chkfeaturetree_bttn_Click(object sender, EventArgs e)
        {
            if (openfeaturemodel_tb.Text=="")
            {
                MessageBox.Show("Please Select feature Model!");
            }
            else
            {
                int a = 1;
                feature_list_rtb.Clear();
                foreach (string item in FileProcess.readFeature(openfeaturemodel_tb.Text))
                {
                    feature_list_rtb.AppendText(a + ". feature -> " + item + "\n");
                    a++;
                }
                //status_rtb.Clear();
                status_rtb.AppendText("*** Feature tree imported ***\n");
            }
            info_pnl.Visible = true;
           
        }

        private void updatemodel_bttn_Click(object sender, EventArgs e)
        {
            if (status_rtb.Text.Contains("Feature tree imported") && status_rtb.Text.Contains("Model imported"))
            {
                if (File.Exists("txtfolder\\model_subtree_guncel.txt"))
                    File.Delete("txtfolder\\model_subtree_guncel.txt");
                flag = FeatureProcess.updatetreeviaFeture(openfeaturemodel_tb.Text);
                ModelUpdate.updateModel();
                //bu kısım mcm den parse edilerek oluşturlan txt lerde value değerlerini güncelleyerek mcm'e tekrar yazdıracak.
                foreach (ModelTree item in ModelUpdate.CreateModelTree())
                {
                    McmParser Xmlpars = new McmParser(openmodelpath_tb.Text, item.parent + ".mcm");
                    Xmlpars.WriteXmlNewValues();
                }
                //status_rtb.Clear();
                status_rtb.AppendText("*** Model updated ***\n");
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please Import Feature Model and MAtelo Model!");
            }
           
        }

        private void exportmodel_btn_Click(object sender, EventArgs e)
        {
            if (openmodelpath_tb.Text == "")
            {
                MessageBox.Show("Please Select Matelo Project!");
            }
            else
            {
                foreach (ModelTree item in ModelUpdate.CreateModelTree())
                {
                    McmParser Xmlpars = new McmParser(openmodelpath_tb.Text, item.parent + ".mcm");
                    Xmlpars.XmlParsing();
                }
                //status_rtb.Clear();
                status_rtb.AppendText("*** Model imported ***\n");

            }
        }
        public void eskifonk_calculatenewfeature_btn_Click()
        {
            string[] feature_arr = FileProcess.readFeature(openfeaturemodel_tb.Text);
            List<ModelTree> updatedModelTree = new List<ModelTree>(ModelUpdate.CreateModelTree());
            foreach (ModelTree item in ModelUpdate.CreateModelTree())
            {

                for (int i = 0; i < feature_arr.Length; i++)
                {
                    if ((item.parent == feature_arr[i].Split(',').ElementAt(0)) && (feature_arr[i].Split(',').ElementAt(1) == "1"))
                    {
                        foreach (string child in item.childs)
                        {
                            for (int j = i; j < feature_arr.Length; j++)
                            {
                                if (child == feature_arr[j].Split(',').ElementAt(0) && (feature_arr[j].Split(',').ElementAt(1) == "0"))
                                {
                                    List<string> childs_list = new List<string>(item.childs);
                                    childs_list.Remove(child);
                                    item.childs = childs_list.ToArray();
                                    item.childvalue = 1 / item.childs.Length;
                                    //numbers.RemoveAt(numbers.IndexOf(4));
                                }
                            }
                        }
                    }
                    else if ((item.parent == feature_arr[i].Split(',').ElementAt(0)) && (feature_arr[i].Split(',').ElementAt(1) == "0"))
                    {
                        updatedModelTree.Remove(item);
                    }
                }
            }
            updatedModelTree = ModelUpdate.CreateModelTree();
            foreach (ModelTree item in updatedModelTree)
            {
                modeltreeshow_rtb.AppendText(item.parent.ToString().ToUpper() + "\n");
                foreach (var child in item.childs)
                {
                    modeltreeshow_rtb.AppendText("  --" + child.ToString().ToUpper() + " =>  child_value: " + item.childvalue.ToString() + "\n");
                }
            }
        }

        private void consistence_btn_Click(object sender, EventArgs e)
        {
            if (openmodelpath_tb.Text!="" && openfeaturemodel_tb.Text!="")
            {
                //status_rtb.Clear();
                flag = FeatureProcess.consistenceCheck(openfeaturemodel_tb.Text);
                if (flag)
                {
                    status_rtb.AppendText("*** SPLE Tree fetures and Model features are consistence\n");
                }
                else
                {
                    status_rtb.AppendText("*** SPLE Tree fetures and Model features are not consistence\n");
                }
            }
            else
            {
                MessageBox.Show("Please Select Feature Model and Matelo Model!");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            modeltreeshow_rtb.Clear();
            modeltreeshow_rtb.AppendText(File.ReadAllText("txtfolder\\model_subtree_guncel.txt"));
            label2.Visible = true;
            modeltreeshow_rtb.Visible = true;
        }

    }
}
