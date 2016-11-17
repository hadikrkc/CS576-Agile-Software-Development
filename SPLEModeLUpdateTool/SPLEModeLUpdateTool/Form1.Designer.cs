namespace SPLEModeLUpdateTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openfeaturemodel_tb = new System.Windows.Forms.TextBox();
            this.openfeaturemodel_bttn = new System.Windows.Forms.Button();
            this.openfeaturemodel_lbl = new System.Windows.Forms.Label();
            this.openmodel_lbl = new System.Windows.Forms.Label();
            this.openmodel_bttn = new System.Windows.Forms.Button();
            this.openmodelpath_tb = new System.Windows.Forms.TextBox();
            this.modelFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.updatemodel_bttn = new System.Windows.Forms.Button();
            this.chkfeaturetree_bttn = new System.Windows.Forms.Button();
            this.feature_list_rtb = new System.Windows.Forms.RichTextBox();
            this.modeltreeshow_rtb = new System.Windows.Forms.RichTextBox();
            this.exportmodel_btn = new System.Windows.Forms.Button();
            this.calculatenewfeature_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openfeaturemodel_tb
            // 
            this.openfeaturemodel_tb.Location = new System.Drawing.Point(12, 92);
            this.openfeaturemodel_tb.Name = "openfeaturemodel_tb";
            this.openfeaturemodel_tb.Size = new System.Drawing.Size(163, 20);
            this.openfeaturemodel_tb.TabIndex = 0;
            // 
            // openfeaturemodel_bttn
            // 
            this.openfeaturemodel_bttn.Location = new System.Drawing.Point(181, 92);
            this.openfeaturemodel_bttn.Name = "openfeaturemodel_bttn";
            this.openfeaturemodel_bttn.Size = new System.Drawing.Size(39, 23);
            this.openfeaturemodel_bttn.TabIndex = 1;
            this.openfeaturemodel_bttn.Text = "...";
            this.openfeaturemodel_bttn.UseVisualStyleBackColor = true;
            this.openfeaturemodel_bttn.Click += new System.EventHandler(this.openfeaturemodel_bttn_Click);
            // 
            // openfeaturemodel_lbl
            // 
            this.openfeaturemodel_lbl.AutoSize = true;
            this.openfeaturemodel_lbl.Location = new System.Drawing.Point(17, 76);
            this.openfeaturemodel_lbl.Name = "openfeaturemodel_lbl";
            this.openfeaturemodel_lbl.Size = new System.Drawing.Size(104, 13);
            this.openfeaturemodel_lbl.TabIndex = 2;
            this.openfeaturemodel_lbl.Text = "Open Feature Model";
            // 
            // openmodel_lbl
            // 
            this.openmodel_lbl.AutoSize = true;
            this.openmodel_lbl.Location = new System.Drawing.Point(12, 18);
            this.openmodel_lbl.Name = "openmodel_lbl";
            this.openmodel_lbl.Size = new System.Drawing.Size(97, 13);
            this.openmodel_lbl.TabIndex = 5;
            this.openmodel_lbl.Text = "Open Model Folder";
            // 
            // openmodel_bttn
            // 
            this.openmodel_bttn.Location = new System.Drawing.Point(181, 40);
            this.openmodel_bttn.Name = "openmodel_bttn";
            this.openmodel_bttn.Size = new System.Drawing.Size(39, 23);
            this.openmodel_bttn.TabIndex = 4;
            this.openmodel_bttn.Text = "...";
            this.openmodel_bttn.UseVisualStyleBackColor = true;
            this.openmodel_bttn.Click += new System.EventHandler(this.openmodel_bttn_Click);
            // 
            // openmodelpath_tb
            // 
            this.openmodelpath_tb.Location = new System.Drawing.Point(12, 43);
            this.openmodelpath_tb.Name = "openmodelpath_tb";
            this.openmodelpath_tb.Size = new System.Drawing.Size(163, 20);
            this.openmodelpath_tb.TabIndex = 3;
            // 
            // updatemodel_bttn
            // 
            this.updatemodel_bttn.Location = new System.Drawing.Point(423, 40);
            this.updatemodel_bttn.Name = "updatemodel_bttn";
            this.updatemodel_bttn.Size = new System.Drawing.Size(124, 23);
            this.updatemodel_bttn.TabIndex = 6;
            this.updatemodel_bttn.Text = "UPDATE MODEL";
            this.updatemodel_bttn.UseVisualStyleBackColor = true;
            this.updatemodel_bttn.Click += new System.EventHandler(this.updatemodel_bttn_Click);
            // 
            // chkfeaturetree_bttn
            // 
            this.chkfeaturetree_bttn.Location = new System.Drawing.Point(245, 92);
            this.chkfeaturetree_bttn.Name = "chkfeaturetree_bttn";
            this.chkfeaturetree_bttn.Size = new System.Drawing.Size(145, 23);
            this.chkfeaturetree_bttn.TabIndex = 7;
            this.chkfeaturetree_bttn.Text = "IMPORT FEATURE TREE";
            this.chkfeaturetree_bttn.UseVisualStyleBackColor = true;
            this.chkfeaturetree_bttn.Click += new System.EventHandler(this.chkfeaturetree_bttn_Click);
            // 
            // feature_list_rtb
            // 
            this.feature_list_rtb.Location = new System.Drawing.Point(20, 183);
            this.feature_list_rtb.Name = "feature_list_rtb";
            this.feature_list_rtb.Size = new System.Drawing.Size(237, 186);
            this.feature_list_rtb.TabIndex = 9;
            this.feature_list_rtb.Text = "";
            // 
            // modeltreeshow_rtb
            // 
            this.modeltreeshow_rtb.Location = new System.Drawing.Point(303, 183);
            this.modeltreeshow_rtb.Name = "modeltreeshow_rtb";
            this.modeltreeshow_rtb.Size = new System.Drawing.Size(373, 186);
            this.modeltreeshow_rtb.TabIndex = 10;
            this.modeltreeshow_rtb.Text = "";
            // 
            // exportmodel_btn
            // 
            this.exportmodel_btn.Location = new System.Drawing.Point(245, 40);
            this.exportmodel_btn.Name = "exportmodel_btn";
            this.exportmodel_btn.Size = new System.Drawing.Size(145, 23);
            this.exportmodel_btn.TabIndex = 11;
            this.exportmodel_btn.Text = "IMPORT MODEL";
            this.exportmodel_btn.UseVisualStyleBackColor = true;
            this.exportmodel_btn.Click += new System.EventHandler(this.exportmodel_btn_Click);
            // 
            // calculatenewfeature_btn
            // 
            this.calculatenewfeature_btn.Location = new System.Drawing.Point(423, 90);
            this.calculatenewfeature_btn.Name = "calculatenewfeature_btn";
            this.calculatenewfeature_btn.Size = new System.Drawing.Size(124, 23);
            this.calculatenewfeature_btn.TabIndex = 12;
            this.calculatenewfeature_btn.Text = "SHOW NEW TREE";
            this.calculatenewfeature_btn.UseVisualStyleBackColor = true;
            this.calculatenewfeature_btn.Visible = false;
            this.calculatenewfeature_btn.Click += new System.EventHandler(this.calculatenewfeature_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 381);
            this.Controls.Add(this.calculatenewfeature_btn);
            this.Controls.Add(this.exportmodel_btn);
            this.Controls.Add(this.modeltreeshow_rtb);
            this.Controls.Add(this.feature_list_rtb);
            this.Controls.Add(this.chkfeaturetree_bttn);
            this.Controls.Add(this.updatemodel_bttn);
            this.Controls.Add(this.openmodel_lbl);
            this.Controls.Add(this.openmodel_bttn);
            this.Controls.Add(this.openmodelpath_tb);
            this.Controls.Add(this.openfeaturemodel_lbl);
            this.Controls.Add(this.openfeaturemodel_bttn);
            this.Controls.Add(this.openfeaturemodel_tb);
            this.Name = "Form1";
            this.Text = "SPLE Model Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox openfeaturemodel_tb;
        private System.Windows.Forms.Button openfeaturemodel_bttn;
        private System.Windows.Forms.Label openfeaturemodel_lbl;
        private System.Windows.Forms.Label openmodel_lbl;
        private System.Windows.Forms.Button openmodel_bttn;
        private System.Windows.Forms.TextBox openmodelpath_tb;
        private System.Windows.Forms.FolderBrowserDialog modelFolderBrowserDialog;
        private System.Windows.Forms.Button updatemodel_bttn;
        private System.Windows.Forms.Button chkfeaturetree_bttn;
        private System.Windows.Forms.RichTextBox feature_list_rtb;
        private System.Windows.Forms.RichTextBox modeltreeshow_rtb;
        private System.Windows.Forms.Button exportmodel_btn;
        private System.Windows.Forms.Button calculatenewfeature_btn;
    }
}

