using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsonGamesGeos2.classes.File_Management
{
    public class Folders
    {
        public  bool CreateFolder(string path)
        {
            try
            {
                Directory.CreateDirectory(path);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public  bool RemoveFolder(string path)
        {
            try
            {
                Directory.Delete(path);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public  bool CheckForFolder(string folder)
        {
            try
            {
                Directory.GetFiles(folder);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
      
    }
}
