using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace CarsonGamesGeos2.classes
{
    public class usermangemnt
    {
       
        public Dictionary<string, string> users = new Dictionary<string, string>();
        encryption encyption = new encryption();

        public Boolean CheckPasswrd(string a, string b)
        {
            users = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(File.ReadAllText("./config/" + "users.txt"));
            //   Console.WriteLine(users["admin"]);
            try
            {
                var key = "b14ca5898a4e4133bbce2ea2315a1916"; //testing key

                string encryptedpass = users[a];
                string enteredpass = b;
                string encrypedcheck = encyption.EncryptString(enteredpass);

                if (encryptedpass == encrypedcheck)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                return false;
            }
            // return true;
        }

    
    string usrname = " ";
    string usrpath;
    string pas;
    bool isadmin;
        string imgpath;
   
    bool logs;
    public Dictionary<string, string> config = new Dictionary<string, string>();
        Color bkcolor;
        Color menucolor;
        Color cgformcolor;
    

    public bool Setup(string username, string password, bool admin, string imagepath, Color cgcolor,Color bk,Color menuclr, bool log)
    {
            bkcolor = bk;
            menucolor = menuclr;
            cgformcolor = cgcolor;
            imgpath = imagepath;
           

        if (log == true)
        {
            logs = true;
            using (StreamWriter sw = new StreamWriter("./logs/" + "addusr.txt"))
            {

                sw.WriteLine("Creating log");
                sw.WriteLine("Creating User");
                sw.Dispose();

            }
        }

        usrname = username;
        pas = password;
        isadmin = admin;
         

        Directory.CreateDirectory("Users/" + usrname);
        usrpath = "Users/" + usrname + "/";
           
        users = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(File.ReadAllText("./settings/users/userlst.txt"));

        if (users.ContainsKey(username))
        {
           // Properties.execptionthrown.Default.addusr = "1";
          //  Program.MainFrm.OpenForm(new geos.error.Messagebox("User already exists!"), "Dialog");
            return true;
        }
        var key = "b14ca5898a4e4133bbce2ea2315a1916";
        string passwrd = encyption.EncryptString(pas);

      
        users.Add(username, passwrd);
        using (StreamWriter sw = new StreamWriter("./settings/users/userlst.txt"))
        {

            _ = sw.WriteAsync(new JavaScriptSerializer().Serialize(users));
            sw.Dispose();

        } // sw goes out of scope here, and is disposed automatically
        if (createFiles() != true)
        {
            return true;

        }
        else
        {
            if (log == true)
            {
                using (StreamWriter sw = new StreamWriter("./logs/" + "addusr.txt"))
                {


                    sw.WriteLine("Writting Settings");
                    sw.Dispose();

                }
            }
            return true;
        }


    }
    bool createFiles()
    {
        Directory.CreateDirectory(usrpath + "/settings");
        Directory.CreateDirectory(usrpath + "/apps");
        Directory.CreateDirectory(usrpath + "/desktop");

        //File.Create(".//"+usrpath+"settings/colors.txt");
        config.Add("backcolor", "white");
        using (StreamWriter sw = new StreamWriter(usrpath + "settings/colors.txt"))
        {

            sw.WriteLine(new JavaScriptSerializer().Serialize(config));
            sw.Dispose();

        } // sw goes out of scope here, and is disposed automatically    
        config.Clear();
        //  File.Create(usrpath + "settings/admin.txt");
        config.Add("admin", isadmin.ToString());
        using (StreamWriter sw = new StreamWriter(usrpath + "settings/admin.txt"))
        {

            sw.WriteLine(new JavaScriptSerializer().Serialize(config));
            sw.Dispose();

        } // sw goes out of scope here, and is disposed automatically    
        config.Clear();

        config.Add("bcolor", bkcolor.ToArgb().ToString());
        config.Add("menucolor", menucolor.ToArgb().ToString());
        if (cgformcolor.ToArgb().ToString() == "0")
        {
           cgformcolor = Color.Black;


        }

        config.Add("cgformcolor", cgformcolor.ToArgb().ToString());

        using (StreamWriter sw = new StreamWriter(usrpath + "settings/color.txt"))
        {

            sw.WriteLine(new JavaScriptSerializer().Serialize(config));
            sw.Dispose();

        } // sw goes out of scope here, and is disposed automatically    
        config.Clear();
        if (logs == true)
        {
            using (StreamWriter sw = new StreamWriter("./logs/" + "addusr.txt"))
            {

                sw.WriteLine("Done");
                sw.Dispose();

            }
        }
        if(imgpath != null)
            {
                Directory.CreateDirectory(usrpath + "settings/misc");
                File.Copy(imgpath, usrpath + "settings/misc/" + "image.png");
            }

            Directory.CreateDirectory("./settings/fts");
            return true;

    }
    public bool AddSettings(string user, string file, string key, string value)
    {
        usrpath = "Users/" + user + "/";

        if (File.Exists(usrpath + "settings/" + file + ".txt"))
        {
            
            config = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(File.ReadAllText(usrpath + "settings/" + file + ".txt"));
            config.Add(key, value);


            using (StreamWriter sw = new StreamWriter(usrpath + "settings/" + file + ".txt"))
            {


                sw.WriteLine(new JavaScriptSerializer().Serialize(config));
                sw.Dispose();

            }
            config.Clear();
            return true;
        }
        else
        {
            config.Clear();
         
            config.Add(key, value);
          
          
            File.Create(usrpath + "settings/" + file + ".txt");
            while (File.Exists(usrpath + "settings/" + file + ".txt"))
            {
                Thread.Sleep(10);
                StringBuilder fileloc = new StringBuilder();
                fileloc.Append(usrpath + "settings/" + file + ".txt");
                string filel = fileloc.ToString();
                StreamWriter sw = new StreamWriter(filel);


                sw.WriteLine(new JavaScriptSerializer().Serialize(config));
                sw.Dispose();


                config.Clear();
                return true;
            }

             
            return true;

        }

    }

}

}
