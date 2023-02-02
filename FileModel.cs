using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchChangeFileName
{
    public class FileModel
    {

        public FileModel()
        {
            this.NewFileName = string.Empty;
            this.NewFullFillPathName = string.Empty;
        }
        public int SeqNo { get; set; }
        public string FullPath { get; set; }
        public string ParentFolderName { get; set; }
        public string ThisFolderName { get; set; }
        public string FileType { get; set; }

        public string OrgFullFillPathName { get; set; }
        public string OrgFileName { get; set; }
        public string NewFileName { get; set; }
        public string NewFullFillPathName { get; set; }
    }
}
