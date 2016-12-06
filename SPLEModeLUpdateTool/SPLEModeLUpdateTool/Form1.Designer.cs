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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.status_rtb = new System.Windows.Forms.RichTextBox();
            this.status_lbl = new System.Windows.Forms.Label();
            this.consistence_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openfeaturemodel_tb
            // 
            this.openfeaturemodel_tb.Location = new System.Drawing.Point(110, 79);
            this.openfeaturemodel_tb.Name = "openfeaturemodel_tb";
            this.openfeaturemodel_tb.Size = new System.Drawing.Size(113, 20);
            this.openfeaturemodel_tb.TabIndex = 0;
            // 
            // openfeaturemodel_bttn
            // 
            this.openfeaturemodel_bttn.Location = new System.Drawing.Point(229, 77);
            this.openfeaturemodel_bttn.Name = "openfeaturemodel_bttn";
            this.openfeaturemodel_bttn.Size = new System.Drawing.Size(34, 23);
            this.openfeaturemodel_bttn.TabIndex = 1;
            this.openfeaturemodel_bttn.Text = "...";
            this.openfeaturemodel_bttn.UseVisualStyleBackColor = true;
            this.openfeaturemodel_bttn.Click += new System.EventHandler(this.openfeaturemodel_bttn_Click);
            // 
            // openfeaturemodel_lbl
            // 
            this.openfeaturemodel_lbl.AutoSize = true;
            this.openfeaturemodel_lbl.Location = new System.Drawing.Point(6, 82);
            this.openfeaturemodel_lbl.Name = "openfeaturemodel_lbl";
            this.openfeaturemodel_lbl.Size = new System.Drawing.Size(104, 13);
            this.openfeaturemodel_lbl.TabIndex = 2;
            this.openfeaturemodel_lbl.Text = "Open Feature Model";
            // 
            // openmodel_lbl
            // 
            this.openmodel_lbl.AutoSize = true;
            this.openmodel_lbl.Location = new System.Drawing.Point(3, 48);
            this.openmodel_lbl.Name = "openmodel_lbl";
            this.openmodel_lbl.Size = new System.Drawing.Size(97, 13);
            this.openmodel_lbl.TabIndex = 5;
            this.openmodel_lbl.Text = "Open Model Folder";
            // 
            // openmodel_bttn
            // 
            this.openmodel_bttn.Location = new System.Drawing.Point(229, 43);
            this.openmodel_bttn.Name = "openmodel_bttn";
            this.openmodel_bttn.Size = new System.Drawing.Size(34, 23);
            this.openmodel_bttn.TabIndex = 4;
            this.openmodel_bttn.Text = "...";
            this.openmodel_bttn.UseVisualStyleBackColor = true;
            this.openmodel_bttn.Click += new System.EventHandler(this.openmodel_bttn_Click);
            // 
            // openmodelpath_tb
            // 
            this.openmodelpath_tb.Location = new System.Drawing.Point(110, 46);
            this.openmodelpath_tb.Name = "openmodelpath_tb";
            this.openmodelpath_tb.Size = new System.Drawing.Size(113, 20);
            this.openmodelpath_tb.TabIndex = 3;
            // 
            // updatemodel_bttn
            // 
            this.updatemodel_bttn.Enabled = false;
            this.updatemodel_bttn.Location = new System.Drawing.Point(710, 161);
            this.updatemodel_bttn.Name = "updatemodel_bttn";
            this.updatemodel_bttn.Size = new System.Drawing.Size(124, 23);
            this.updatemodel_bttn.TabIndex = 6;
            this.updatemodel_bttn.Text = "UPDATE MODEL";
            this.updatemodel_bttn.UseVisualStyleBackColor = true;
            this.updatemodel_bttn.Click += new System.EventHandler(this.updatemodel_bttn_Click);
            // 
            // chkfeaturetree_bttn
            // 
            this.chkfeaturetree_bttn.Location = new System.Drawing.Point(283, 82);
            this.chkfeaturetree_bttn.Name = "chkfeaturetree_bttn";
            this.chkfeaturetree_bttn.Size = new System.Drawing.Size(115, 23);
            this.chkfeaturetree_bttn.TabIndex = 7;
            this.chkfeaturetree_bttn.Text = "IMPORT FEATURE TREE";
            this.chkfeaturetree_bttn.UseVisualStyleBackColor = true;
            this.chkfeaturetree_bttn.Click += new System.EventHandler(this.chkfeaturetree_bttn_Click);
            // 
            // feature_list_rtb
            // 
            this.feature_list_rtb.Location = new System.Drawing.Point(20, 259);
            this.feature_list_rtb.Name = "feature_list_rtb";
            this.feature_list_rtb.Size = new System.Drawing.Size(237, 110);
            this.feature_list_rtb.TabIndex = 9;
            this.feature_list_rtb.Text = "";
            // 
            // modeltreeshow_rtb
            // 
            this.modeltreeshow_rtb.Location = new System.Drawing.Point(303, 259);
            this.modeltreeshow_rtb.Name = "modeltreeshow_rtb";
            this.modeltreeshow_rtb.Size = new System.Drawing.Size(373, 110);
            this.modeltreeshow_rtb.TabIndex = 10;
            this.modeltreeshow_rtb.Text = "";
            // 
            // exportmodel_btn
            // 
            this.exportmodel_btn.Location = new System.Drawing.Point(283, 43);
            this.exportmodel_btn.Name = "exportmodel_btn";
            this.exportmodel_btn.Size = new System.Drawing.Size(115, 23);
            this.exportmodel_btn.TabIndex = 11;
            this.exportmodel_btn.Text = "IMPORT MODEL";
            this.exportmodel_btn.UseVisualStyleBackColor = true;
            this.exportmodel_btn.Click += new System.EventHandler(this.exportmodel_btn_Click);
            // 
            // calculatenewfeature_btn
            // 
            this.calculatenewfeature_btn.Location = new System.Drawing.Point(710, 190);
            this.calculatenewfeature_btn.Name = "calculatenewfeature_btn";
            this.calculatenewfeature_btn.Size = new System.Drawing.Size(124, 23);
            this.calculatenewfeature_btn.TabIndex = 12;
            this.calculatenewfeature_btn.Text = "SHOW NEW TREE";
            this.calculatenewfeature_btn.UseVisualStyleBackColor = true;
            this.calculatenewfeature_btn.Visible = false;
            this.calculatenewfeature_btn.Click += new System.EventHandler(this.calculatenewfeature_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.consistence_btn);
            this.groupBox1.Controls.Add(this.status_lbl);
            this.groupBox1.Controls.Add(this.status_rtb);
            this.groupBox1.Controls.Add(this.openmodelpath_tb);
            this.groupBox1.Controls.Add(this.openmodel_lbl);
            this.groupBox1.Controls.Add(this.exportmodel_btn);
            this.groupBox1.Controls.Add(this.openfeaturemodel_lbl);
            this.groupBox1.Controls.Add(this.chkfeaturetree_bttn);
            this.groupBox1.Controls.Add(this.openfeaturemodel_tb);
            this.groupBox1.Controls.Add(this.openmodel_bttn);
            this.groupBox1.Controls.Add(this.openfeaturemodel_bttn);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 217);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SPLE Model Update";
            // 
            // status_rtb
            // 
            this.status_rtb.Location = new System.Drawing.Point(10, 149);
            this.status_rtb.Name = "status_rtb";
            this.status_rtb.Size = new System.Drawing.Size(253, 62);
            this.status_rtb.TabIndex = 12;
            this.status_rtb.Text = "";
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Location = new System.Drawing.Point(10, 130);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(50, 13);
            this.status_lbl.TabIndex = 13;
            this.status_lbl.Text = "STATUS";
            // 
            // consistence_btn
            // 
            this.consistence_btn.Location = new System.Drawing.Point(443, 37);
            this.consistence_btn.Name = "consistence_btn";
            this.consistence_btn.Size = new System.Drawing.Size(75, 44);
            this.consistence_btn.TabIndex = 14;
            this.consistence_btn.Text = "Consistence Check";
            this.consistence_btn.UseVisualStyleBackColor = true;
            this.consistence_btn.Click += new System.EventHandler(this.consistence_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 415);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calculatenewfeature_btn);
            this.Controls.Add(this.modeltreeshow_rtb);
            this.Controls.Add(this.feature_list_rtb);
            this.Controls.Add(this.updatemodel_bttn);
            this.Name = "Form1";
            this.Text = "SPLE Model Update";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.RichTextBox status_rtb;
        private System.Windows.Forms.Button consistence_btn;
    }
}

