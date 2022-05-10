using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsonGamesGeos2.classes.File_Management
{
    public  class Files
    {
        public bool CreateFile(string path)
        {
            try
            {
                File.Create(path);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool RemoveFile(string path)
        {
            try
            {
                File.Delete(path);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool CheckForFile(string file)
        {
            try
            {
                if(File.Exists(file))
                 return true;
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public string Read(string file)
        {
            try
            {
                string result = " ";
                FileInfo fi = new FileInfo(file);
                FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
                StreamReader sr = new StreamReader(fs);
                result = sr.ReadToEnd();
                sr.Close();
                fs.Close();
                return result;
            }
            catch (Exception ex)
            {
                return "-2";
            }
        }
       
    }
}
