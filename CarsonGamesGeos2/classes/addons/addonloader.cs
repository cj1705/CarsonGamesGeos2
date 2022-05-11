using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarsonGamesGeos2.classes.addons
{
    public class addonloader
    {
        public void LoadAddons()
        {
            Console.Log log = new Console.Log();
            classes.File_Management.Folders folders = new classes.File_Management.Folders();

            if (folders.CheckForFolder("./addons"))
            {
                foreach (var file in Directory.GetFiles("./addons"))
                {
                    Assembly SampleAssembly = Assembly.LoadFrom(file);
                    Type myType = SampleAssembly.GetTypes()[0];

                    MethodInfo Method = myType.GetMethod("AddonMain");  
                    if (Method == null)
                    {
                        log.Info(SampleAssembly.GetName() + " Failed to load, Main() was not found!");
                        return;
                    }
                    object myInstance = Activator.CreateInstance(myType);
                    Method.Invoke(myInstance, null);
                  log.Info(SampleAssembly.FullName);
                }
            }
            else
            {
                Directory.CreateDirectory("./addons");
                log.Info("Making addon Folder");
            }
        }
    }
}
