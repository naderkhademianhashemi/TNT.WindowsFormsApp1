namespace TNT.WindowsFormsApp1.FRM
{
    partial class Frm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMyParcel = new System.Windows.Forms.Button();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtMyParcel = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.btnParcels = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFolderName = new System.Windows.Forms.Label();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnShowContent = new System.Windows.Forms.Button();
            this.txtPathSave = new System.Windows.Forms.TextBox();
            this.btnSave2File = new System.Windows.Forms.Button();
            this.txtPathBrows = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnMyParcel);
            this.splitContainer1.Panel1.Controls.Add(this.txtTo);
            this.splitContainer1.Panel1.Controls.Add(this.txtMyParcel);
            this.splitContainer1.Panel1.Controls.Add(this.txtFrom);
            this.splitContainer1.Panel1.Controls.Add(this.btnParcels);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1290, 697);
            this.splitContainer1.SplitterDistance = 428;
            this.splitContainer1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "code parcel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "from";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "to";
            // 
            // btnMyParcel
            // 
            this.btnMyParcel.Location = new System.Drawing.Point(104, 265);
            this.btnMyParcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnMyParcel.Name = "btnMyParcel";
            this.btnMyParcel.Size = new System.Drawing.Size(100, 28);
            this.btnMyParcel.TabIndex = 6;
            this.btnMyParcel.Text = "My parcel";
            this.btnMyParcel.UseVisualStyleBackColor = true;
            this.btnMyParcel.Click += new System.EventHandler(this.btnMyParcel_Click);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(79, 86);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(132, 22);
            this.txtTo.TabIndex = 5;
            // 
            // txtMyParcel
            // 
            this.txtMyParcel.Location = new System.Drawing.Point(104, 211);
            this.txtMyParcel.Margin = new System.Windows.Forms.Padding(4);
            this.txtMyParcel.Name = "txtMyParcel";
            this.txtMyParcel.Size = new System.Drawing.Size(132, 22);
            this.txtMyParcel.TabIndex = 5;
            this.txtMyParcel.Text = "117103925";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(79, 28);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(132, 22);
            this.txtFrom.TabIndex = 4;
            // 
            // btnParcels
            // 
            this.btnParcels.Location = new System.Drawing.Point(93, 139);
            this.btnParcels.Margin = new System.Windows.Forms.Padding(4);
            this.btnParcels.Name = "btnParcels";
            this.btnParcels.Size = new System.Drawing.Size(100, 28);
            this.btnParcels.TabIndex = 3;
            this.btnParcels.Text = "parcels";
            this.btnParcels.UseVisualStyleBackColor = true;
            this.btnParcels.Click += new System.EventHandler(this.btnParcels_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.lblFolderName);
            this.splitContainer2.Panel2.Controls.Add(this.txtFolderName);
            this.splitContainer2.Panel2.Controls.Add(this.btnCreateFile);
            this.splitContainer2.Panel2.Controls.Add(this.textBox1);
            this.splitContainer2.Panel2.Controls.Add(this.btnShowContent);
            this.splitContainer2.Panel2.Controls.Add(this.txtPathSave);
            this.splitContainer2.Panel2.Controls.Add(this.btnSave2File);
            this.splitContainer2.Panel2.Controls.Add(this.txtPathBrows);
            this.splitContainer2.Panel2.Controls.Add(this.btnBrowse);
            this.splitContainer2.Size = new System.Drawing.Size(858, 697);
            this.splitContainer2.SplitterDistance = 411;
            this.splitContainer2.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(411, 697);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "path browsed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "listBox1 SelectedItem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "content to save";
            // 
            // lblFolderName
            // 
            this.lblFolderName.AutoSize = true;
            this.lblFolderName.Location = new System.Drawing.Point(40, 503);
            this.lblFolderName.Name = "lblFolderName";
            this.lblFolderName.Size = new System.Drawing.Size(86, 16);
            this.lblFolderName.TabIndex = 18;
            this.lblFolderName.Text = "Folder Name";
            // 
            // txtFolderName
            // 
            this.txtFolderName.Location = new System.Drawing.Point(152, 503);
            this.txtFolderName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(203, 22);
            this.txtFolderName.TabIndex = 17;
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(187, 550);
            this.btnCreateFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(100, 28);
            this.btnCreateFile.TabIndex = 16;
            this.btnCreateFile.Text = "create file";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 196);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 107);
            this.textBox1.TabIndex = 15;
            // 
            // btnShowContent
            // 
            this.btnShowContent.Location = new System.Drawing.Point(54, 119);
            this.btnShowContent.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowContent.Name = "btnShowContent";
            this.btnShowContent.Size = new System.Drawing.Size(157, 28);
            this.btnShowContent.TabIndex = 14;
            this.btnShowContent.Text = "show file content";
            this.btnShowContent.UseVisualStyleBackColor = true;
            this.btnShowContent.Click += new System.EventHandler(this.btnShowContent_Click);
            // 
            // txtPathSave
            // 
            this.txtPathSave.Location = new System.Drawing.Point(165, 338);
            this.txtPathSave.Margin = new System.Windows.Forms.Padding(4);
            this.txtPathSave.Multiline = true;
            this.txtPathSave.Name = "txtPathSave";
            this.txtPathSave.Size = new System.Drawing.Size(214, 92);
            this.txtPathSave.TabIndex = 12;
            // 
            // btnSave2File
            // 
            this.btnSave2File.Location = new System.Drawing.Point(152, 451);
            this.btnSave2File.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave2File.Name = "btnSave2File";
            this.btnSave2File.Size = new System.Drawing.Size(100, 28);
            this.btnSave2File.TabIndex = 11;
            this.btnSave2File.Text = "save to file";
            this.btnSave2File.UseVisualStyleBackColor = true;
            this.btnSave2File.Click += new System.EventHandler(this.btnSave2File_Click);
            // 
            // txtPathBrows
            // 
            this.txtPathBrows.Location = new System.Drawing.Point(40, 51);
            this.txtPathBrows.Margin = new System.Windows.Forms.Padding(4);
            this.txtPathBrows.Name = "txtPathBrows";
            this.txtPathBrows.Size = new System.Drawing.Size(203, 22);
            this.txtPathBrows.TabIndex = 10;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(86, 83);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 697);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Frm";
            this.Text = "Frm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Button btnParcels;
        private System.Windows.Forms.Button btnMyParcel;
        private System.Windows.Forms.TextBox txtMyParcel;
        private System.Windows.Forms.TextBox txtPathBrows;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPathSave;
        private System.Windows.Forms.Button btnSave2File;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnShowContent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Label lblFolderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}