using System;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

namespace Service
{
    public class MyService
    {
        private readonly string file;

        public MyService(string file = "data.xml")
        {
            this.file = file;
        }

        public int CalculateSomething()
        {
            return -NativeDll.GetNumber(); 
        }

        public string ProductType()
        {
            // we do not want to use reg key for the install location
            // and command line app can be call for a different directory
            // let's ensure to look where we are
            try
            {
                var currentFolder = Directory.GetParent(Assembly.GetCallingAssembly().Location).FullName;
                var doc = XDocument.Load(Path.Combine(currentFolder, file));
                
                return doc.Root.Element("Type").Attribute("Name").Value;
            }
            catch
            {
                return "<corrupted>";
            }
        }
    }
}
