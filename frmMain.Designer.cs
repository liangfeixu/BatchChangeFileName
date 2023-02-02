namespace BatchChangeFileName
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.picDialogOpen = new System.Windows.Forms.PictureBox();
            this.cbxIncludeSubFolder = new System.Windows.Forms.CheckBox();
            this.cbxReplace = new System.Windows.Forms.CheckBox();
            this.txtOldText = new System.Windows.Forms.TextBox();
            this.cbxReplaceNum = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddFileNamePrefix = new System.Windows.Forms.TextBox();
            this.cbxThisFolderNameToFileNamePrefix = new System.Windows.Forms.CheckBox();
            this.lblOldNew = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.txtNewText = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.cbxOverwriveFile = new System.Windows.Forms.CheckBox();
            this.cbxOverwriveOldFile = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbSeqBit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBitShow = new System.Windows.Forms.Label();
            this.rbtBefore = new System.Windows.Forms.RadioButton();
            this.rbtAlter = new System.Windows.Forms.RadioButton();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxToTraditional = new System.Windows.Forms.CheckBox();
            this.cbxToSimplified = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDialogOpen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.Location = new System.Drawing.Point(14, 30);
            this.lblFolderPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(36, 15);
            this.lblFolderPath.TabIndex = 0;
            this.lblFolderPath.Text = "路徑:";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.AllowDrop = true;
            this.txtFolderPath.Location = new System.Drawing.Point(61, 27);
            this.txtFolderPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(666, 23);
            this.txtFolderPath.TabIndex = 1;
            // 
            // picDialogOpen
            // 
            this.picDialogOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDialogOpen.Image = ((System.Drawing.Image)(resources.GetObject("picDialogOpen.Image")));
            this.picDialogOpen.InitialImage = null;
            this.picDialogOpen.Location = new System.Drawing.Point(704, 28);
            this.picDialogOpen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picDialogOpen.Name = "picDialogOpen";
            this.picDialogOpen.Size = new System.Drawing.Size(21, 20);
            this.picDialogOpen.TabIndex = 2;
            this.picDialogOpen.TabStop = false;
            this.picDialogOpen.Click += new System.EventHandler(this.picDialogOpen_Click);
            // 
            // cbxIncludeSubFolder
            // 
            this.cbxIncludeSubFolder.AutoSize = true;
            this.cbxIncludeSubFolder.Location = new System.Drawing.Point(62, 69);
            this.cbxIncludeSubFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxIncludeSubFolder.Name = "cbxIncludeSubFolder";
            this.cbxIncludeSubFolder.Size = new System.Drawing.Size(104, 19);
            this.cbxIncludeSubFolder.TabIndex = 3;
            this.cbxIncludeSubFolder.Text = "包含子文件夾";
            this.cbxIncludeSubFolder.UseVisualStyleBackColor = true;
            // 
            // cbxReplace
            // 
            this.cbxReplace.AutoSize = true;
            this.cbxReplace.Location = new System.Drawing.Point(424, 61);
            this.cbxReplace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxReplace.Name = "cbxReplace";
            this.cbxReplace.Size = new System.Drawing.Size(94, 19);
            this.cbxReplace.TabIndex = 4;
            this.cbxReplace.Text = "名稱全替換:";
            this.cbxReplace.UseVisualStyleBackColor = true;
            // 
            // txtOldText
            // 
            this.txtOldText.AllowDrop = true;
            this.txtOldText.Location = new System.Drawing.Point(83, 23);
            this.txtOldText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOldText.Name = "txtOldText";
            this.txtOldText.Size = new System.Drawing.Size(330, 23);
            this.txtOldText.TabIndex = 5;
            // 
            // cbxReplaceNum
            // 
            this.cbxReplaceNum.AutoSize = true;
            this.cbxReplaceNum.Location = new System.Drawing.Point(530, 60);
            this.cbxReplaceNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxReplaceNum.Name = "cbxReplaceNum";
            this.cbxReplaceNum.Size = new System.Drawing.Size(78, 19);
            this.cbxReplaceNum.TabIndex = 6;
            this.cbxReplaceNum.Text = "替換數字";
            this.cbxReplaceNum.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "文件名前綴:";
            // 
            // txtAddFileNamePrefix
            // 
            this.txtAddFileNamePrefix.AllowDrop = true;
            this.txtAddFileNamePrefix.Location = new System.Drawing.Point(479, 33);
            this.txtAddFileNamePrefix.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddFileNamePrefix.Name = "txtAddFileNamePrefix";
            this.txtAddFileNamePrefix.Size = new System.Drawing.Size(108, 23);
            this.txtAddFileNamePrefix.TabIndex = 8;
            // 
            // cbxThisFolderNameToFileNamePrefix
            // 
            this.cbxThisFolderNameToFileNamePrefix.AutoSize = true;
            this.cbxThisFolderNameToFileNamePrefix.Location = new System.Drawing.Point(12, 75);
            this.cbxThisFolderNameToFileNamePrefix.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxThisFolderNameToFileNamePrefix.Name = "cbxThisFolderNameToFileNamePrefix";
            this.cbxThisFolderNameToFileNamePrefix.Size = new System.Drawing.Size(169, 19);
            this.cbxThisFolderNameToFileNamePrefix.TabIndex = 9;
            this.cbxThisFolderNameToFileNamePrefix.Text = "使用當前文件夾名做前綴";
            this.cbxThisFolderNameToFileNamePrefix.UseVisualStyleBackColor = true;
            // 
            // lblOldNew
            // 
            this.lblOldNew.AutoSize = true;
            this.lblOldNew.Location = new System.Drawing.Point(420, 27);
            this.lblOldNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOldNew.Name = "lblOldNew";
            this.lblOldNew.Size = new System.Drawing.Size(101, 15);
            this.lblOldNew.TabIndex = 10;
            this.lblOldNew.Text = "多個使用 \",\"分開";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(245, 556);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(88, 27);
            this.btnPreview.TabIndex = 12;
            this.btnPreview.Text = "預覽";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Enabled = false;
            this.btnReplace.Location = new System.Drawing.Point(404, 556);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(88, 27);
            this.btnReplace.TabIndex = 13;
            this.btnReplace.Text = "替換";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "文件過濾關鍵文件:";
            // 
            // txtFileType
            // 
            this.txtFileType.AllowDrop = true;
            this.txtFileType.Location = new System.Drawing.Point(332, 66);
            this.txtFileType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFileType.Name = "txtFileType";
            this.txtFileType.Size = new System.Drawing.Size(204, 23);
            this.txtFileType.TabIndex = 15;
            this.txtFileType.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "如“*.txt”";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(56, 556);
            this.btnLoadFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(113, 27);
            this.btnLoadFile.TabIndex = 17;
            this.btnLoadFile.Text = "刷新文件列表";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // txtNewText
            // 
            this.txtNewText.AllowDrop = true;
            this.txtNewText.Location = new System.Drawing.Point(83, 58);
            this.txtNewText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNewText.Name = "txtNewText";
            this.txtNewText.Size = new System.Drawing.Size(330, 23);
            this.txtNewText.TabIndex = 18;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(50, 61);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 15);
            this.lblTo.TabIndex = 19;
            this.lblTo.Text = "為:";
            // 
            // cbxOverwriveFile
            // 
            this.cbxOverwriveFile.AutoSize = true;
            this.cbxOverwriveFile.Location = new System.Drawing.Point(238, 75);
            this.cbxOverwriveFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxOverwriveFile.Name = "cbxOverwriveFile";
            this.cbxOverwriveFile.Size = new System.Drawing.Size(104, 19);
            this.cbxOverwriveFile.TabIndex = 20;
            this.cbxOverwriveFile.Text = "覆蓋同名文件";
            this.cbxOverwriveFile.UseVisualStyleBackColor = true;
            // 
            // cbxOverwriveOldFile
            // 
            this.cbxOverwriveOldFile.AutoSize = true;
            this.cbxOverwriveOldFile.Checked = true;
            this.cbxOverwriveOldFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxOverwriveOldFile.Location = new System.Drawing.Point(388, 75);
            this.cbxOverwriveOldFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxOverwriveOldFile.Name = "cbxOverwriveOldFile";
            this.cbxOverwriveOldFile.Size = new System.Drawing.Size(110, 19);
            this.cbxOverwriveOldFile.TabIndex = 21;
            this.cbxOverwriveOldFile.Text = "  替換原始文件";
            this.cbxOverwriveOldFile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "自動序號:";
            // 
            // cbbSeqBit
            // 
            this.cbbSeqBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSeqBit.FormattingEnabled = true;
            this.cbbSeqBit.Location = new System.Drawing.Point(180, 31);
            this.cbbSeqBit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbbSeqBit.Name = "cbbSeqBit";
            this.cbbSeqBit.Size = new System.Drawing.Size(72, 23);
            this.cbbSeqBit.TabIndex = 23;
            this.cbbSeqBit.SelectedIndexChanged += new System.EventHandler(this.cbbSeqBit_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "位";
            // 
            // lblBitShow
            // 
            this.lblBitShow.AutoSize = true;
            this.lblBitShow.Location = new System.Drawing.Point(300, 36);
            this.lblBitShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBitShow.Name = "lblBitShow";
            this.lblBitShow.Size = new System.Drawing.Size(31, 15);
            this.lblBitShow.TabIndex = 25;
            this.lblBitShow.Text = "0001";
            // 
            // rbtBefore
            // 
            this.rbtBefore.AutoSize = true;
            this.rbtBefore.Checked = true;
            this.rbtBefore.Location = new System.Drawing.Point(12, 33);
            this.rbtBefore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtBefore.Name = "rbtBefore";
            this.rbtBefore.Size = new System.Drawing.Size(38, 19);
            this.rbtBefore.TabIndex = 26;
            this.rbtBefore.TabStop = true;
            this.rbtBefore.Text = "前";
            this.rbtBefore.UseVisualStyleBackColor = true;
            // 
            // rbtAlter
            // 
            this.rbtAlter.AutoSize = true;
            this.rbtAlter.Location = new System.Drawing.Point(62, 33);
            this.rbtAlter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtAlter.Name = "rbtAlter";
            this.rbtAlter.Size = new System.Drawing.Size(38, 19);
            this.rbtAlter.TabIndex = 27;
            this.rbtAlter.Text = "後";
            this.rbtAlter.UseVisualStyleBackColor = true;
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Location = new System.Drawing.Point(18, 343);
            this.richTextBoxLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(709, 193);
            this.richTextBoxLog.TabIndex = 28;
            this.richTextBoxLog.Text = "";
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(566, 556);
            this.btnClearLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(88, 27);
            this.btnClearLog.TabIndex = 13;
            this.btnClearLog.Text = "清空日誌";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddFileNamePrefix);
            this.groupBox1.Controls.Add(this.cbxOverwriveOldFile);
            this.groupBox1.Controls.Add(this.rbtAlter);
            this.groupBox1.Controls.Add(this.cbxOverwriveFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbtBefore);
            this.groupBox1.Controls.Add(this.cbbSeqBit);
            this.groupBox1.Controls.Add(this.lblBitShow);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxThisFolderNameToFileNamePrefix);
            this.groupBox1.Location = new System.Drawing.Point(18, 226);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(709, 110);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxToTraditional);
            this.groupBox2.Controls.Add(this.cbxToSimplified);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbxReplaceNum);
            this.groupBox2.Controls.Add(this.lblTo);
            this.groupBox2.Controls.Add(this.txtOldText);
            this.groupBox2.Controls.Add(this.txtNewText);
            this.groupBox2.Controls.Add(this.cbxReplace);
            this.groupBox2.Controls.Add(this.lblOldNew);
            this.groupBox2.Location = new System.Drawing.Point(18, 110);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(709, 104);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // cbxToTraditional
            // 
            this.cbxToTraditional.AutoSize = true;
            this.cbxToTraditional.Location = new System.Drawing.Point(616, 25);
            this.cbxToTraditional.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxToTraditional.Name = "cbxToTraditional";
            this.cbxToTraditional.Size = new System.Drawing.Size(78, 19);
            this.cbxToTraditional.TabIndex = 21;
            this.cbxToTraditional.Text = "轉成繁體";
            this.cbxToTraditional.UseVisualStyleBackColor = true;
            this.cbxToTraditional.CheckedChanged += new System.EventHandler(this.cbxToTraditional_CheckedChanged);
            // 
            // cbxToSimplified
            // 
            this.cbxToSimplified.AutoSize = true;
            this.cbxToSimplified.Location = new System.Drawing.Point(530, 25);
            this.cbxToSimplified.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxToSimplified.Name = "cbxToSimplified";
            this.cbxToSimplified.Size = new System.Drawing.Size(78, 19);
            this.cbxToSimplified.TabIndex = 21;
            this.cbxToSimplified.Text = "轉成簡體";
            this.cbxToSimplified.UseVisualStyleBackColor = true;
            this.cbxToSimplified.CheckedChanged += new System.EventHandler(this.cbxToSimplified_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "文字替換:";
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(743, 601);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFileType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.cbxIncludeSubFolder);
            this.Controls.Add(this.picDialogOpen);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.lblFolderPath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件名修改工具";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDialogOpen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFolderPath;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.PictureBox picDialogOpen;
        private System.Windows.Forms.CheckBox cbxIncludeSubFolder;
        private System.Windows.Forms.CheckBox cbxReplace;
        private System.Windows.Forms.TextBox txtOldText;
        private System.Windows.Forms.CheckBox cbxReplaceNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddFileNamePrefix;
        private System.Windows.Forms.CheckBox cbxThisFolderNameToFileNamePrefix;
        private System.Windows.Forms.Label lblOldNew;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.TextBox txtNewText;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.CheckBox cbxOverwriveFile;
        private System.Windows.Forms.CheckBox cbxOverwriveOldFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbSeqBit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBitShow;
        private System.Windows.Forms.RadioButton rbtBefore;
        private System.Windows.Forms.RadioButton rbtAlter;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbxToTraditional;
        private System.Windows.Forms.CheckBox cbxToSimplified;
    }
}

