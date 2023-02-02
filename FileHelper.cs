using System;
using System.Data;
using System.IO;
using System.Text;

    /// <summary>
    /// 檔操作
    /// </summary>
    public class FileHelper
    {
        #region 檢測指定目錄是否存在
        /// <summary>
        /// 檢測指定目錄是否存在
        /// </summary>
        /// <param name="directoryPath">目錄的絕對路徑</param>
        /// <returns>true/false</returns>
        public static bool IsExistDirectory(string directoryPath)
        {
            return Directory.Exists(directoryPath);
        }
        #endregion

        #region 檢測指定檔是否存在
        /// <summary>
        /// 檢測指定檔是否存在
        /// </summary>
        /// <param name="filePath">文件的絕對路徑</param>     
        /// <returns>true/false</returns>
        public static bool IsExistFile(string filePath)
        {
            return File.Exists(filePath);
        }
        #endregion

        #region 獲取指定目錄中的檔列表
        /// <summary>
        /// 獲取指定目錄中的檔列表
        /// </summary>
        /// <param name="directoryPath">指定目錄中的檔列表</param>    
        /// <returns>files array</returns>
        public static string[] GetFileNames(string directoryPath)
        {
            //如果目錄不存在，則拋出異常
            if (!IsExistDirectory(directoryPath))
            {
                throw new FileNotFoundException();
            }

            //獲取文件列表獲取文件列表
            return Directory.GetFiles(directoryPath);
        }
        #endregion

        #region 獲取指定目錄中所有子目錄列表,若要搜索嵌套的子目錄列表,請使用重載方法.
        /// <summary>
        /// 獲取指定目錄中所有子目錄列表,若要搜索嵌套的子目錄列表,請使用重載方法.
        /// </summary>
        /// <param name="directoryPath">指定目錄的絕對路徑</param>        
        public static string[] GetDirectories(string directoryPath)
        {
            try
            {
                return Directory.GetDirectories(directoryPath);
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 獲取指定目錄及子目錄中所有檔列表
        /// <summary>
        /// 獲取指定目錄及子目錄中所有檔列表
        /// </summary>
        /// <param name="directoryPath">指定目錄的絕對路徑</param>
        /// <param name="searchPattern">模式字串，"*"代表0或N個字元，"?"代表1個字元。
        /// 範例："Log*.xml"表示搜索所有以Log開頭的Xml檔。</param>
        /// <param name="isSearchChild">是否搜索子目錄</param>
        public static string[] GetFileNames(string directoryPath, string searchPattern, bool isSearchChild)
        {
            //如果目錄不存在，則拋出異常
            if (!IsExistDirectory(directoryPath))
            {
                throw new FileNotFoundException();
            }

            try
            {
                if (isSearchChild)
                {
                    return Directory.GetFiles(directoryPath, searchPattern, SearchOption.AllDirectories);
                }
                else
                {
                    return Directory.GetFiles(directoryPath, searchPattern, SearchOption.TopDirectoryOnly);
                }
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 檢測指定目錄是否為空
        /// <summary>
        /// 檢測指定目錄是否為空
        /// </summary>
        /// <param name="directoryPath">指定目錄的絕對路徑</param>        
        public static bool IsEmptyDirectory(string directoryPath)
        {
            try
            {
                //判斷是否存在檔
                string[] fileNames = GetFileNames(directoryPath);
                if (fileNames.Length > 0)
                {
                    return false;
                }

                //判斷是否存在檔夾
                string[] directoryNames = GetDirectories(directoryPath);
                if (directoryNames.Length > 0)
                {
                    return false;
                }

                return true;
            }
            catch
            {
                //這裏記錄日誌
                //LogHelper.WriteTraceLog(TraceLogLevel.Error, ex.Message);
                return true;
            }
        }
        #endregion

        #region 檢測指定目錄中是否存在指定的檔
        /// <summary>
        /// 檢測指定目錄中是否存在指定的檔,若要搜索子目錄請使用重載方法.
        /// </summary>
        /// <param name="directoryPath">指定目錄的絕對路徑</param>
        /// <param name="searchPattern">模式字串，"*"代表0或N個字元，"?"代表1個字元。
        /// 範例："Log*.xml"表示搜索所有以Log開頭的Xml檔。</param>        
        public static bool Contains(string directoryPath, string searchPattern)
        {
            try
            {
                //獲取指定的檔列表
                string[] fileNames = GetFileNames(directoryPath, searchPattern, false);

                //判斷指定檔是否存在
                if (fileNames.Length == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                //LogHelper.WriteTraceLog(TraceLogLevel.Error, ex.Message);
            }
        }

        /// <summary>
        /// 檢測指定目錄中是否存在指定的檔
        /// </summary>
        /// <param name="directoryPath">指定目錄的絕對路徑</param>
        /// <param name="searchPattern">模式字串，"*"代表0或N個字元，"?"代表1個字元。
        /// 範例："Log*.xml"表示搜索所有以Log開頭的Xml檔。</param> 
        /// <param name="isSearchChild">是否搜索子目錄</param>
        public static bool Contains(string directoryPath, string searchPattern, bool isSearchChild)
        {
            try
            {
                //獲取指定的檔列表
                string[] fileNames = GetFileNames(directoryPath, searchPattern, true);

                //判斷指定檔是否存在
                if (fileNames.Length == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                //LogHelper.WriteTraceLog(TraceLogLevel.Error, ex.Message);
            }
        }
        #endregion


 

   



        #region 移動文件(剪貼--粘貼)
       
        /// <summary>
        /// 移動文件(剪貼--粘貼)
        /// </summary>
        /// <param name="sourceFile">要移動的檔的路徑及全名(包括後綴)</param>
        /// <param name="targetPath">檔移動到新的位置</param>
        /// <param name="targetFileName">新的檔案名</param>
        public static void MoveFile(string sourceFile, string targetPath, string targetFileName)
        {
            sourceFile = sourceFile.Replace("/", "\\");
            targetPath = targetPath.Replace("/", "\\");
            if (!Directory.Exists(targetPath))
                Directory.CreateDirectory(targetPath);
            string targetFile = targetPath + "\\" + targetFileName;
            if (File.Exists(targetFile))
                File.Delete(targetFile);
            File.Move(sourceFile, targetFile);
        }
        #endregion

        #region 復制文件
        
        /// <summary>
        /// 復制文件
        /// </summary>
        /// <param name="sourceFile">要移動的檔的路徑及全名(包括後綴)</param>
        /// <param name="targetPath">檔移動到新的位置</param>
        /// <param name="targetFileName">新的檔案名</param>
        public static void CopyFile(string sourceFile, string targetPath, string targetFileName)
        {
            sourceFile = sourceFile.Replace("/", "\\");
            targetPath = targetPath.Replace("/", "\\");
            if (!Directory.Exists(targetPath))
                Directory.CreateDirectory(targetPath);
            string targetFile = targetPath + "\\" + targetFileName;
            if (File.Exists(targetFile))
                File.Delete(targetFile);
            File.Copy(sourceFile, targetFile);
        }
        #endregion

        #region 根據時間得到目錄名 / 格式:yyyyMMdd 或者 HHmmssff
        /// <summary>
        /// 根據時間得到目錄名yyyyMMdd
        /// </summary>
        /// <returns></returns>
        public static string GetDateDir()
        {
            return DateTime.Now.ToString("yyyyMMdd");
        }
        /// <summary>
        /// 根據時間得到檔案名HHmmssff
        /// </summary>
        /// <returns></returns>
        public static string GetDateFile()
        {
            return DateTime.Now.ToString("HHmmssff");
        }
        #endregion

        #region 復制文件夾
        /// <summary>
        /// 復制文件夾(遞歸)
        /// </summary>
        /// <param name="sourceDirectory">原始檔案夾路徑</param>
        /// <param name="targetDirectory">目標文件夾路徑</param>
        public static void CopyFolder(string sourceDirectory, string targetDirectory)
        {
            Directory.CreateDirectory(targetDirectory);

            if (!Directory.Exists(sourceDirectory)) return;

            string[] directories = Directory.GetDirectories(sourceDirectory);

            if (directories.Length > 0)
            {
                foreach (string d in directories)
                {
                    CopyFolder(d, targetDirectory + d.Substring(d.LastIndexOf("\\")));
                }
            }
            string[] files = Directory.GetFiles(sourceDirectory);
            if (files.Length > 0)
            {
                foreach (string s in files)
                {
                    File.Copy(s, targetDirectory + s.Substring(s.LastIndexOf("\\")), true);
                }
            }
        }
        #endregion

        #region 檢查檔,如果檔不存在則創建
        /// <summary>
        /// 檢查檔,如果檔不存在則創建  
        /// </summary>
        /// <param name="FilePath">路徑,包括檔案名</param>
        public static void ExistsFile(string FilePath)
        {
            //if(!File.Exists(FilePath))    
            //File.Create(FilePath);    
            //以上寫法會報錯,詳細解釋請看下文.........   
            if (!File.Exists(FilePath))
            {
                FileStream fs = File.Create(FilePath);
                fs.Close();
            }
        }
        #endregion

        #region 刪除指定文件夾對應其他文件夾裏的文件
        /// <summary>
        /// 刪除指定文件夾對應其他文件夾裏的文件
        /// </summary>
        /// <param name="varFromDirectory">指定檔夾路徑</param>
        /// <param name="varToDirectory">對應其他文件夾路徑</param>
        public static void DeleteFolderFiles(string varFromDirectory, string varToDirectory)
        {
            Directory.CreateDirectory(varToDirectory);

            if (!Directory.Exists(varFromDirectory)) return;

            string[] directories = Directory.GetDirectories(varFromDirectory);

            if (directories.Length > 0)
            {
                foreach (string d in directories)
                {
                    DeleteFolderFiles(d, varToDirectory + d.Substring(d.LastIndexOf("\\")));
                }
            }


            string[] files = Directory.GetFiles(varFromDirectory);

            if (files.Length > 0)
            {
                foreach (string s in files)
                {
                    File.Delete(varToDirectory + s.Substring(s.LastIndexOf("\\")));
                }
            }
        }
        #endregion

        #region 從檔的絕對路徑中獲取檔案名( 包含擴展名 )
        /// <summary>
        /// 從檔的絕對路徑中獲取檔案名( 包含擴展名 )
        /// </summary>
        /// <param name="filePath">文件的絕對路徑</param>        
        public static string GetFileName(string filePath)
        {
            //獲取文件的名稱
            FileInfo fi = new FileInfo(filePath);
            return fi.Name;
        }
        #endregion


        #region 創建壹個目錄
        /// <summary>
        /// 創建壹個目錄
        /// </summary>
        /// <param name="directoryPath">目錄的絕對路徑</param>
        public static void CreateDirectory(string directoryPath)
        {
            //如果目錄不存在則創建該目錄
            if (!IsExistDirectory(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }
        #endregion

        #region 創建壹個文件
        /// <summary>
        /// 創建壹個文件。
        /// </summary>
        /// <param name="filePath">文件的絕對路徑</param>
        public static void CreateFile(string filePath)
        {
            try
            {
                //如果檔不存在則創建該檔
                if (!IsExistFile(filePath))
                {
                    //創建壹個FileInfo對象
                    FileInfo file = new FileInfo(filePath);

                    //創建文件
                    FileStream fs = file.Create();

                    //關閉文件流
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                //LogHelper.WriteTraceLog(TraceLogLevel.Error, ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// 創建壹個文件,並將字節流寫入文件。
        /// </summary>
        /// <param name="filePath">文件的絕對路徑</param>
        /// <param name="buffer">二進制流數據</param>
        public static void CreateFile(string filePath, byte[] buffer)
        {
            try
            {
                //如果檔不存在則創建該檔
                if (!IsExistFile(filePath))
                {
                    //創建壹個FileInfo對象
                    FileInfo file = new FileInfo(filePath);

                    //創建文件
                    FileStream fs = file.Create();

                    //寫入二進制流
                    fs.Write(buffer, 0, buffer.Length);

                    //關閉文件流
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                //LogHelper.WriteTraceLog(TraceLogLevel.Error, ex.Message);
                throw ex;
            }
        }
        #endregion

        #region 獲取文字檔的行數
        /// <summary>
        /// 獲取文字檔的行數
        /// </summary>
        /// <param name="filePath">文件的絕對路徑</param>        
        public static int GetLineCount(string filePath)
        {
            //將文字檔的各行讀到壹個字串數組中
            string[] rows = File.ReadAllLines(filePath);

            //返回行數
            return rows.Length;
        }
        #endregion

        #region 獲取壹個文件的長度
        /// <summary>
        /// 獲取壹個文件的長度,單位為Byte
        /// </summary>
        /// <param name="filePath">文件的絕對路徑</param>        
        public static int GetFileSize(string filePath)
        {
            //創建壹個文件對象
            FileInfo fi = new FileInfo(filePath);

            //獲取文件的大小
            return (int)fi.Length;
        }
        #endregion

        #region 獲取指定目錄中的子目錄列表
        /// <summary>
        /// 獲取指定目錄及子目錄中所有子目錄列表
        /// </summary>
        /// <param name="directoryPath">指定目錄的絕對路徑</param>
        /// <param name="searchPattern">模式字串，"*"代表0或N個字元，"?"代表1個字元。
        /// 範例："Log*.xml"表示搜索所有以Log開頭的Xml檔。</param>
        /// <param name="isSearchChild">是否搜索子目錄</param>
        public static string[] GetDirectories(string directoryPath, string searchPattern, bool isSearchChild)
        {
            try
            {
                if (isSearchChild)
                {
                    return Directory.GetDirectories(directoryPath, searchPattern, SearchOption.AllDirectories);
                }
                else
                {
                    return Directory.GetDirectories(directoryPath, searchPattern, SearchOption.TopDirectoryOnly);
                }
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 向文字檔寫入內容

        /// <summary>
        /// 向文字檔中寫入內容
        /// </summary>
        /// <param name="filePath">文件的絕對路徑</param>
        /// <param name="text">寫入的內容</param>
        /// <param name="encoding">編碼</param>
        public static void WriteText(string filePath, string text, Encoding encoding)
        {
            //向文件寫入內容
            File.WriteAllText(filePath, text, encoding);
        }
        #endregion

        #region 向文字檔的尾部追加內容
        /// <summary>
        /// 向文字檔的尾部追加內容
        /// </summary>
        /// <param name="filePath">文件的絕對路徑</param>
        /// <param name="content">寫入的內容</param>
        public static void AppendText(string filePath, string content)
        {
            File.AppendAllText(filePath, content);
        }
        #endregion

        #region 將現有文件的內容復制到新文件中
        /// <summary>
        /// 將原始檔案的內容復制到目標文件中
        /// </summary>
        /// <param name="sourceFilePath">原始檔案的絕對路徑</param>
        /// <param name="destFilePath">目標文件的絕對路徑</param>
        public static void Copy(string sourceFilePath, string destFilePath)
        {
            File.Copy(sourceFilePath, destFilePath, true);
        }
        #endregion

       


        #region 從檔的絕對路徑中獲取檔案名( 不包含擴展名 )
        /// <summary>
        /// 從檔的絕對路徑中獲取檔案名( 不包含擴展名 )
        /// </summary>
        /// <param name="filePath">文件的絕對路徑</param>        
        public static string GetFileNameNoExtension(string filePath)
        {
            //獲取文件的名稱
            FileInfo fi = new FileInfo(filePath);
            return fi.Name.Split('.')[0];
        }
        #endregion

        #region 從文件的絕對路徑中獲取擴展名
        /// <summary>
        /// 從文件的絕對路徑中獲取擴展名
        /// </summary>
        /// <param name="filePath">文件的絕對路徑</param>        
        public static string GetExtension(string filePath)
        {
            //獲取文件的名稱
            FileInfo fi = new FileInfo(filePath);
            return fi.Extension;
        }
        #endregion

       

        #region 清空文件內容
        /// <summary>
        /// 清空文件內容
        /// </summary>
        /// <param name="filePath">文件的絕對路徑</param>
        public static void ClearFile(string filePath)
        {
            //刪除文件
            File.Delete(filePath);

            //重新創建該檔
            CreateFile(filePath);
        }
        #endregion

        #region 刪除指定目錄
        /// <summary>
        /// 刪除指定目錄及其所有子目錄
        /// </summary>
        /// <param name="directoryPath">指定目錄的絕對路徑</param>
        public static void DeleteDirectory(string directoryPath)
        {
            if (IsExistDirectory(directoryPath))
            {
                Directory.Delete(directoryPath, true);
            }
        }
        #endregion
    }


