namespace MultiTool
{
    partial class mtForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mtForm));
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.bW1 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.oFolder = new System.Windows.Forms.ToolStripButton();
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customCriteria = new System.Windows.Forms.CheckBox();
            this.b1_2 = new System.Windows.Forms.Button();
            this.chkdOut = new System.Windows.Forms.CheckBox();
            this.atIM = new System.Windows.Forms.CheckBox();
            this.eHead = new System.Windows.Forms.CheckBox();
            this.numberOfLines = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfFiles = new System.Windows.Forms.Label();
            this.b1_1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Criteria_Cancel = new System.Windows.Forms.Button();
            this.btn_Criteria_Save = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.b2_1 = new System.Windows.Forms.Button();
            this.b2_2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(0, 28);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(492, 28);
            this.pBar.Step = 1;
            this.pBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar.TabIndex = 0;
            // 
            // bW1
            // 
            this.bW1.WorkerReportsProgress = true;
            this.bW1.WorkerSupportsCancellation = true;
            this.bW1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bW1_DoWork);
            this.bW1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bW1_ProgressChanged);
            this.bW1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bW_RunWorkerCompleted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oFolder});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(492, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // oFolder
            // 
            this.oFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oFolder.Image = ((System.Drawing.Image)(resources.GetObject("oFolder.Image")));
            this.oFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.oFolder.Name = "oFolder";
            this.oFolder.Size = new System.Drawing.Size(23, 22);
            this.oFolder.Text = "&Open";
            this.oFolder.Click += new System.EventHandler(this.oFolder_Click);
            // 
            // fbd1
            // 
            this.fbd1.Description = "Select a source folder";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customCriteria);
            this.panel1.Controls.Add(this.b1_2);
            this.panel1.Controls.Add(this.chkdOut);
            this.panel1.Controls.Add(this.atIM);
            this.panel1.Controls.Add(this.eHead);
            this.panel1.Controls.Add(this.numberOfLines);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numberOfFiles);
            this.panel1.Controls.Add(this.b1_1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 206);
            this.panel1.TabIndex = 12;
            // 
            // customCriteria
            // 
            this.customCriteria.AutoSize = true;
            this.customCriteria.Location = new System.Drawing.Point(363, 132);
            this.customCriteria.Name = "customCriteria";
            this.customCriteria.Size = new System.Drawing.Size(96, 17);
            this.customCriteria.TabIndex = 19;
            this.customCriteria.Text = "Custom Criteria";
            this.customCriteria.UseVisualStyleBackColor = true;
            this.customCriteria.CheckedChanged += new System.EventHandler(this.customChecked);
            // 
            // b1_2
            // 
            this.b1_2.Location = new System.Drawing.Point(9, 170);
            this.b1_2.Name = "b1_2";
            this.b1_2.Size = new System.Drawing.Size(75, 32);
            this.b1_2.TabIndex = 10;
            this.b1_2.Text = "Stop";
            this.b1_2.UseVisualStyleBackColor = true;
            this.b1_2.Click += new System.EventHandler(this.b1_2_Click_1);
            // 
            // chkdOut
            // 
            this.chkdOut.AutoSize = true;
            this.chkdOut.Checked = true;
            this.chkdOut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkdOut.Location = new System.Drawing.Point(363, 85);
            this.chkdOut.Name = "chkdOut";
            this.chkdOut.Size = new System.Drawing.Size(89, 17);
            this.chkdOut.TabIndex = 18;
            this.chkdOut.Text = "Checked Out";
            this.chkdOut.UseVisualStyleBackColor = true;
            // 
            // atIM
            // 
            this.atIM.AutoSize = true;
            this.atIM.Checked = true;
            this.atIM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.atIM.Location = new System.Drawing.Point(363, 62);
            this.atIM.Name = "atIM";
            this.atIM.Size = new System.Drawing.Size(104, 17);
            this.atIM.TabIndex = 17;
            this.atIM.Text = "At Iron Mountain";
            this.atIM.UseVisualStyleBackColor = true;
            // 
            // eHead
            // 
            this.eHead.AutoSize = true;
            this.eHead.Checked = true;
            this.eHead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.eHead.Location = new System.Drawing.Point(363, 39);
            this.eHead.Name = "eHead";
            this.eHead.Size = new System.Drawing.Size(105, 17);
            this.eHead.TabIndex = 16;
            this.eHead.Text = "Exclude headers";
            this.eHead.UseVisualStyleBackColor = true;
            // 
            // numberOfLines
            // 
            this.numberOfLines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numberOfLines.Location = new System.Drawing.Point(108, 69);
            this.numberOfLines.Name = "numberOfLines";
            this.numberOfLines.Size = new System.Drawing.Size(88, 21);
            this.numberOfLines.TabIndex = 15;
            this.numberOfLines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Number of lines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Number of files";
            // 
            // numberOfFiles
            // 
            this.numberOfFiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numberOfFiles.Location = new System.Drawing.Point(108, 39);
            this.numberOfFiles.Name = "numberOfFiles";
            this.numberOfFiles.Size = new System.Drawing.Size(32, 21);
            this.numberOfFiles.TabIndex = 12;
            this.numberOfFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b1_1
            // 
            this.b1_1.Location = new System.Drawing.Point(9, 132);
            this.b1_1.Name = "b1_1";
            this.b1_1.Size = new System.Drawing.Size(75, 32);
            this.b1_1.TabIndex = 11;
            this.b1_1.Text = "Start";
            this.b1_1.UseVisualStyleBackColor = true;
            this.b1_1.Click += new System.EventHandler(this.b1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Controls.Add(this.btn_Criteria_Cancel);
            this.panel3.Controls.Add(this.btn_Criteria_Save);
            this.panel3.Location = new System.Drawing.Point(9, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 199);
            this.panel3.TabIndex = 20;
            this.panel3.Visible = false;
            // 
            // btn_Criteria_Cancel
            // 
            this.btn_Criteria_Cancel.Location = new System.Drawing.Point(393, 163);
            this.btn_Criteria_Cancel.Name = "btn_Criteria_Cancel";
            this.btn_Criteria_Cancel.Size = new System.Drawing.Size(75, 32);
            this.btn_Criteria_Cancel.TabIndex = 12;
            this.btn_Criteria_Cancel.Text = "Cancel";
            this.btn_Criteria_Cancel.UseVisualStyleBackColor = true;
            this.btn_Criteria_Cancel.Click += new System.EventHandler(this.btn_Criteria_Cancel_Click);
            // 
            // btn_Criteria_Save
            // 
            this.btn_Criteria_Save.Location = new System.Drawing.Point(296, 163);
            this.btn_Criteria_Save.Name = "btn_Criteria_Save";
            this.btn_Criteria_Save.Size = new System.Drawing.Size(75, 32);
            this.btn_Criteria_Save.TabIndex = 11;
            this.btn_Criteria_Save.Text = "Save";
            this.btn_Criteria_Save.UseVisualStyleBackColor = true;
            this.btn_Criteria_Save.Click += new System.EventHandler(this.btn_Criteria_Save_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(338, -1);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(75, 23);
            this.btnToggle.TabIndex = 13;
            this.btnToggle.Text = "Switch";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // b2_1
            // 
            this.b2_1.Location = new System.Drawing.Point(9, 132);
            this.b2_1.Name = "b2_1";
            this.b2_1.Size = new System.Drawing.Size(75, 32);
            this.b2_1.TabIndex = 19;
            this.b2_1.Text = "Start";
            this.b2_1.UseVisualStyleBackColor = true;
            // 
            // b2_2
            // 
            this.b2_2.Location = new System.Drawing.Point(9, 170);
            this.b2_2.Name = "b2_2";
            this.b2_2.Size = new System.Drawing.Size(75, 32);
            this.b2_2.TabIndex = 20;
            this.b2_2.Text = "Stop";
            this.b2_2.UseVisualStyleBackColor = true;
            this.b2_2.Click += new System.EventHandler(this.b2_2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.b2_2);
            this.panel2.Controls.Add(this.b2_1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 206);
            this.panel2.TabIndex = 21;
            this.panel2.Visible = false;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(108, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 15;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Number of lines";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Number of files";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(108, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 21);
            this.label6.TabIndex = 12;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(465, 154);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // mtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 273);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mtForm";
            this.Text = "MultiTool";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pBar;
        private System.ComponentModel.BackgroundWorker bW1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton oFolder;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Button b1_2;
        private System.Windows.Forms.CheckBox chkdOut;
        private System.Windows.Forms.CheckBox atIM;
        private System.Windows.Forms.CheckBox eHead;
        private System.Windows.Forms.Label numberOfLines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numberOfFiles;
        private System.Windows.Forms.Button b1_1;
        private System.Windows.Forms.Button b2_1;
        private System.Windows.Forms.Button b2_2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox customCriteria;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Criteria_Cancel;
        private System.Windows.Forms.Button btn_Criteria_Save;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

