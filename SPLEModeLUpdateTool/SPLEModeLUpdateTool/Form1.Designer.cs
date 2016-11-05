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
            this.openmodel_tb = new System.Windows.Forms.TextBox();
            this.modelFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.updatemodel_bttn = new System.Windows.Forms.Button();
            this.chkfeaturetree_bttn = new System.Windows.Forms.Button();
            this.modelupdate_lbl = new System.Windows.Forms.Label();
            this.feature_list_rtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // openfeaturemodel_tb
            // 
            this.openfeaturemodel_tb.Location = new System.Drawing.Point(12, 43);
            this.openfeaturemodel_tb.Name = "openfeaturemodel_tb";
            this.openfeaturemodel_tb.Size = new System.Drawing.Size(163, 20);
            this.openfeaturemodel_tb.TabIndex = 0;
            // 
            // openfeaturemodel_bttn
            // 
            this.openfeaturemodel_bttn.Location = new System.Drawing.Point(194, 40);
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
            this.openfeaturemodel_lbl.Location = new System.Drawing.Point(13, 25);
            this.openfeaturemodel_lbl.Name = "openfeaturemodel_lbl";
            this.openfeaturemodel_lbl.Size = new System.Drawing.Size(104, 13);
            this.openfeaturemodel_lbl.TabIndex = 2;
            this.openfeaturemodel_lbl.Text = "Open Feature Model";
            // 
            // openmodel_lbl
            // 
            this.openmodel_lbl.AutoSize = true;
            this.openmodel_lbl.Location = new System.Drawing.Point(17, 77);
            this.openmodel_lbl.Name = "openmodel_lbl";
            this.openmodel_lbl.Size = new System.Drawing.Size(97, 13);
            this.openmodel_lbl.TabIndex = 5;
            this.openmodel_lbl.Text = "Open Model Folder";
            // 
            // openmodel_bttn
            // 
            this.openmodel_bttn.Location = new System.Drawing.Point(194, 92);
            this.openmodel_bttn.Name = "openmodel_bttn";
            this.openmodel_bttn.Size = new System.Drawing.Size(39, 23);
            this.openmodel_bttn.TabIndex = 4;
            this.openmodel_bttn.Text = "...";
            this.openmodel_bttn.UseVisualStyleBackColor = true;
            this.openmodel_bttn.Click += new System.EventHandler(this.openmodel_bttn_Click);
            // 
            // openmodel_tb
            // 
            this.openmodel_tb.Location = new System.Drawing.Point(12, 95);
            this.openmodel_tb.Name = "openmodel_tb";
            this.openmodel_tb.Size = new System.Drawing.Size(163, 20);
            this.openmodel_tb.TabIndex = 3;
            // 
            // updatemodel_bttn
            // 
            this.updatemodel_bttn.Location = new System.Drawing.Point(468, 292);
            this.updatemodel_bttn.Name = "updatemodel_bttn";
            this.updatemodel_bttn.Size = new System.Drawing.Size(138, 44);
            this.updatemodel_bttn.TabIndex = 6;
            this.updatemodel_bttn.Text = "UPDATE MODEL";
            this.updatemodel_bttn.UseVisualStyleBackColor = true;
            // 
            // chkfeaturetree_bttn
            // 
            this.chkfeaturetree_bttn.Location = new System.Drawing.Point(12, 135);
            this.chkfeaturetree_bttn.Name = "chkfeaturetree_bttn";
            this.chkfeaturetree_bttn.Size = new System.Drawing.Size(138, 23);
            this.chkfeaturetree_bttn.TabIndex = 7;
            this.chkfeaturetree_bttn.Text = "CHECK FETURE TREE";
            this.chkfeaturetree_bttn.UseVisualStyleBackColor = true;
            this.chkfeaturetree_bttn.Click += new System.EventHandler(this.chkfeaturetree_bttn_Click);
            // 
            // modelupdate_lbl
            // 
            this.modelupdate_lbl.AutoSize = true;
            this.modelupdate_lbl.Location = new System.Drawing.Point(474, 349);
            this.modelupdate_lbl.Name = "modelupdate_lbl";
            this.modelupdate_lbl.Size = new System.Drawing.Size(35, 13);
            this.modelupdate_lbl.TabIndex = 8;
            this.modelupdate_lbl.Text = "label1";
            // 
            // feature_list_rtb
            // 
            this.feature_list_rtb.Location = new System.Drawing.Point(20, 183);
            this.feature_list_rtb.Name = "feature_list_rtb";
            this.feature_list_rtb.Size = new System.Drawing.Size(406, 186);
            this.feature_list_rtb.TabIndex = 9;
            this.feature_list_rtb.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 381);
            this.Controls.Add(this.feature_list_rtb);
            this.Controls.Add(this.modelupdate_lbl);
            this.Controls.Add(this.chkfeaturetree_bttn);
            this.Controls.Add(this.updatemodel_bttn);
            this.Controls.Add(this.openmodel_lbl);
            this.Controls.Add(this.openmodel_bttn);
            this.Controls.Add(this.openmodel_tb);
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
        private System.Windows.Forms.TextBox openmodel_tb;
        private System.Windows.Forms.FolderBrowserDialog modelFolderBrowserDialog;
        private System.Windows.Forms.Button updatemodel_bttn;
        private System.Windows.Forms.Button chkfeaturetree_bttn;
        private System.Windows.Forms.Label modelupdate_lbl;
        private System.Windows.Forms.RichTextBox feature_list_rtb;
    }
}

