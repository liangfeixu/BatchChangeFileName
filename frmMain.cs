using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchChangeFileName
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.AllowDrop = true;
            base.DragEnter += new DragEventHandler(this.ctl_DragEnter);
            base.DragDrop += new DragEventHandler(this.ctl_DragDrop);
            this.WireDragDrop(base.Controls);
            //this.txtFolderPath.ReadOnly = true;

        }
        private List<FileModel> fileList;
        private bool previewFlag = false;

        #region 方法
        private void LoadFiles(bool showLog = true)
        {
            if (string.IsNullOrEmpty(this.txtFolderPath.Text))
            {
                MessageBox.Show("請先選擇文件夾路徑");
                return;
            }
            if (string.IsNullOrEmpty(this.txtFileType.Text))
            {
                MessageBox.Show("文件類型不能為空，所有請輸入“*”");
                return;
            }
            this.fileList = new List<FileModel>();
            richTextBoxLog.Clear();

            if (!Directory.Exists(this.txtFolderPath.Text.Trim()))
            {
                MessageBox.Show("文件夾路徑有誤，請檢查");
                return;
            }

            string[] fileList = FileHelper.GetFileNames(this.txtFolderPath.Text.Trim(), this.txtFileType.Text.Trim(), this.cbxIncludeSubFolder.Checked);
            int idx = 1;
            foreach (string file in fileList)
            {
                FileInfo fi = new FileInfo(file);

                FileModel fileModel = new FileModel();
                fileModel.SeqNo = idx++;
                fileModel.FullPath = fi.DirectoryName;
                fileModel.ThisFolderName = fi.Directory.Name;
                fileModel.ParentFolderName = fi.Directory.Parent.Name;
                fileModel.FileType = fi.Extension;

                fileModel.OrgFullFillPathName = fi.FullName;
                fileModel.OrgFileName = fi.Name.Replace(fileModel.FileType, "");
                if (showLog)
                    ShowFileLog(fileModel, fileModel.SeqNo, fileList.Count());
                this.fileList.Add(fileModel);
            }
            if (showLog)
                ShowLog(string.Format("已加載所有文件,共{0}個", this.fileList.Count));

        }
        private void ShowFileLog(FileModel fileModel, int idx = 1, int cnt = 0)
        {
            string msg = string.Empty;
            if (cnt > 0)
                msg = string.Format("{0}/{1}", idx, cnt);
            msg += " | " + fileModel.ParentFolderName + "/" + fileModel.ThisFolderName + " | " + fileModel.OrgFileName + fileModel.FileType;
            if (!string.IsNullOrEmpty(fileModel.NewFileName))
                msg += " --> " + fileModel.NewFileName + fileModel.FileType;
            ShowLog(msg.Trim());
        }


        private void ExecPreview(bool showLoadFileLog = false)
        {
            if (!this.cbxToSimplified.Checked && !this.cbxToTraditional.Checked && !this.cbxReplaceNum.Checked && !this.cbxThisFolderNameToFileNamePrefix.Checked && txtOldText.Text.Length == 0 && string.IsNullOrEmpty(txtAddFileNamePrefix.Text.Trim()) && this.cbbSeqBit.SelectedIndex <= 0)
            {
                MessageBox.Show("請至少選擇一個替換條件");
                return;
            }
            string[] oldTextArr = this.txtOldText.Text.Split(',');
            string[] newTextArr = this.txtNewText.Text.Split(',');

            if (oldTextArr.Length != newTextArr.Length)
            {
                MessageBox.Show("替換新舊文件數組不一致");
                return;
            }

            if (this.fileList == null)
            {
                LoadFiles(showLoadFileLog);
            }
            if (this.fileList.Count() == 1)
            {
                MessageBox.Show("當前文件夾沒有文件，請重新選擇");
                return;
            }


            foreach (var item in this.fileList)
            {
                item.NewFileName = item.OrgFileName;

                if (cbxReplace.Checked)
                    item.NewFileName = string.Empty;
                //替換數字
                if (this.cbxReplaceNum.Checked)
                {
                    item.NewFileName = (Regex.Replace(item.NewFileName, @"\d", "")).Trim();
                }

                if (cbbSeqBit.SelectedIndex > 0)
                {
                    if (rbtBefore.Checked)
                    {
                        item.NewFileName = ((item.SeqNo).ToString().PadLeft(cbbSeqBit.SelectedIndex, '0') + " " + item.NewFileName.Trim()).Trim();
                    }
                    else
                    {
                        item.NewFileName = (item.NewFileName.Trim() + " " + (item.SeqNo).ToString().PadLeft(cbbSeqBit.SelectedIndex, '0')).Trim();
                    }
                }

                //替換文字
                if (!string.IsNullOrEmpty(txtOldText.Text))
                {
                    for (int i = 0; i < oldTextArr.Length; i++)
                        item.NewFileName = (item.NewFileName.Replace(oldTextArr[i], newTextArr[i])).Trim();
                }
                //添加前綴
                if (!string.IsNullOrEmpty(txtAddFileNamePrefix.Text.Trim()))
                    item.NewFileName = (txtAddFileNamePrefix.Text + item.NewFileName).Trim();

                //添加當前文件夾為前綴
                if (this.cbxThisFolderNameToFileNamePrefix.Checked)
                {
                    item.NewFileName = (item.ThisFolderName + " - " + item.NewFileName).Trim();
                }
                //轉簡體
                if (this.cbxToSimplified.Checked)
                {
                    item.NewFileName = ToSimplified(item.NewFileName).Trim();
                }
                //轉繁體
                if (this.cbxToTraditional.Checked)
                {
                    item.NewFileName = ToTraditional(item.NewFileName).Trim();
                }


            }
            int idx = 1;
            foreach (var item in this.fileList)
            {
                ShowFileLog(item, idx++, this.fileList.Count());
            }
            ShowLog(string.Format("已生成所有新文件名,共{0}個", this.fileList.Count));
            previewFlag = true;
        }

        private void ExceReplace()
        {
            try
            {
                ButtonEnable(true);
                if (!previewFlag)
                    ExecPreview();
                int idx = 1;
                foreach (var item in this.fileList)
                {
                    string newFolderPath = item.FullPath;

                    if (!cbxOverwriveOldFile.Checked)
                    {
                        newFolderPath = Path.Combine(item.FullPath, "output");
                        if (!Directory.Exists(newFolderPath))
                        {
                            Directory.CreateDirectory(newFolderPath);
                        }
                    }
                    string newFullFilePath = Path.Combine(newFolderPath, item.NewFileName + item.FileType);


                    int i = 1;
                    while (File.Exists(newFullFilePath))
                    {
                        if (this.cbxOverwriveFile.Checked)
                            File.Delete(newFullFilePath);
                        else
                        {
                            newFullFilePath = Path.Combine(newFolderPath, item.NewFileName + "(" + i + ")" + item.FileType); ;
                            i++;
                        }
                    }
                    string msg = string.Empty;
                    if (item.OrgFileName.ToLower() != item.NewFileName.ToLower())
                        File.Move(item.OrgFullFillPathName, newFullFilePath);
                    else
                        msg = " (skip)";


                    ShowLog(string.Format("{0}/{1}: {2} --> {3}{4}", idx++, this.fileList.Count(), item.OrgFileName + item.FileType, item.NewFileName + item.FileType, msg));

                    // System.Threading.Thread.Sleep(3000);
                }
                ShowLog(string.Format("已完成,共{0}個", this.fileList.Count));
                ButtonEnable(false);
                previewFlag = false;
                this.fileList = null;
            }
            catch (Exception e)
            {
                ShowLog(e.Message.ToString());
            }
        }

        private void ButtonEnable(bool repFlag = true)
        {
            btnReplace.Enabled = false;
            if (repFlag)
            {
                btnLoadFile.Enabled = false;
                btnPreview.Enabled = false;
            }
            else
            {
                btnLoadFile.Enabled = true;
                btnPreview.Enabled = true;
            }
        }

        #endregion
        #region 簡繁體轉換
        internal const int LOCALE_SYSTEM_DEFAULT = 0x0800;
        internal const int LCMAP_SIMPLIFIED_CHINESE = 0x02000000;
        internal const int LCMAP_TRADITIONAL_CHINESE = 0x04000000;

        /// <summary> 
        /// 使用OS的kernel.dll做為簡繁轉換工具，只要有裝OS就可以使用，不用額外引用dll，但只能做逐字轉換，無法進行詞意的轉換 
        /// <para>所以無法將電腦轉成計算機</para> 
        /// </summary> 
        [System.Runtime.InteropServices.DllImport("kernel32", CharSet = System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
        internal static extern int LCMapString(int Locale, int dwMapFlags, string lpSrcStr, int cchSrc, [System.Runtime.InteropServices.Out] string lpDestStr, int cchDest);

        /// <summary> 
        /// 繁体转简体
        /// </summary> 
        /// <param name="pSource">要转换的繁体字</param> 
        /// <returns>转换后的简体字</returns> 
        public static string ToSimplified(string pSource)
        {
            String tTarget = new String(' ', pSource.Length);
            int tReturn = LCMapString(LOCALE_SYSTEM_DEFAULT, LCMAP_SIMPLIFIED_CHINESE, pSource, pSource.Length, tTarget, pSource.Length);
            return tTarget;
        }

        /// <summary> 
        /// 简体转繁体 
        /// </summary> 
        /// <param name="pSource">要转换的简体字</param> 
        /// <returns>转换后的繁体字</returns> 
        public static string ToTraditional(string pSource)
        {
            String tTarget = new String(' ', pSource.Length);
            int tReturn = LCMapString(LOCALE_SYSTEM_DEFAULT, LCMAP_TRADITIONAL_CHINESE, pSource, pSource.Length, tTarget, pSource.Length);
            return tTarget;
        }
        #endregion

        #region Show Event Log
        private delegate void logDelegate(object log, string color, bool showMs);
        public void ShowLog(object log, string color = "black", bool showMs = false)
        {
            if (richTextBoxLog.InvokeRequired)
                Invoke(new logDelegate(ShowLog), new object[] { log, color, showMs });
            else
            {
                string curTime = "[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "]";
                if (showMs) curTime = "[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "]";
                richTextBoxLog.SelectionStart = richTextBoxLog.TextLength;
                richTextBoxLog.SelectionLength = 0;
                richTextBoxLog.SelectionColor = Color.FromName(color);
                richTextBoxLog.AppendText(string.Format("{0} {1}{2}", curTime, log, Environment.NewLine));
                richTextBoxLog.SelectionStart = richTextBoxLog.TextLength;
                richTextBoxLog.SelectionLength = 0;
                richTextBoxLog.SelectionColor = Color.Black;
                richTextBoxLog.SelectionStart = richTextBoxLog.TextLength;
                richTextBoxLog.ScrollToCaret();
                Application.DoEvents();
            }
        }
        #endregion



        #region 控件事件處理
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.lblBitShow.Text = string.Empty;
            List<dynamic> collection = new List<dynamic>
            {
                new { id = 0, val = "" },
                new { id = 1, val = "#" },
                new { id = 2, val = "##" },
                new { id = 3, val = "###" },
                new { id = 4, val = "####" },
                new { id = 5, val = "#####" },
                new { id = 6, val = "######" }
            };



            this.cbbSeqBit.DisplayMember = "val";
            this.cbbSeqBit.ValueMember = "id";

            this.cbbSeqBit.DropDownStyle = ComboBoxStyle.DropDownList;


            this.cbbSeqBit.Items.Clear();
            this.cbbSeqBit.Items.AddRange(collection.ToArray());


        }
        private void picDialogOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            if (!string.IsNullOrEmpty(dialog.SelectedPath))
            {
                this.txtFolderPath.Text = dialog.SelectedPath;
            }
        }

        private void ctl_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);
                this.txtFolderPath.Text = data[0];
            }
        }

        private void ctl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.Move | DragDropEffects.Copy | DragDropEffects.Scroll;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void WireDragDrop(Control.ControlCollection ctls)
        {
            foreach (Control control in ctls)
            {
                control.AllowDrop = true;
                control.DragEnter += new DragEventHandler(this.ctl_DragEnter);
                control.DragDrop += new DragEventHandler(this.ctl_DragDrop);
                this.WireDragDrop(control.Controls);
            }
        }

        private void cbbSeqBit_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbSeqBit.SelectedIndex <= 0)
            {
                this.lblBitShow.Text = string.Empty;
            }
            else
            {
                this.lblBitShow.Text = "1".PadLeft(cbbSeqBit.SelectedIndex, '0');
            }

        }

        private void cbxToSimplified_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbxToSimplified.Checked)
            {
                this.cbxToTraditional.Checked = false;
            }
        }

        private void cbxToTraditional_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbxToTraditional.Checked)
            {
                this.cbxToSimplified.Checked = false;
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            try
            {
                LoadFiles();
            }
            catch (Exception ex)
            {
                ShowLog(ex.Message.ToString());
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                ExecPreview();
                btnReplace.Enabled = true;
            }
            catch (Exception ex)
            {
                ShowLog(ex.Message.ToString());
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {

            Thread th = new Thread(new ThreadStart(ExceReplace));
            th.Start();

        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Clear();
        }

        #endregion


    }
}
