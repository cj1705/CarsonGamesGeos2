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
        public static bool CreateFolder(string folder, string foldername)
        {
            try
            {
                Directory.CreateDirectory(folder + foldername);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool RemoveFolder(string folder, string foldername)
        {
            try
            {
                Directory.Delete(folder + foldername);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool CheckForFolder(string folder, string foldername)
        {
            try
            {
                Directory.GetFiles(folder + foldername);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
