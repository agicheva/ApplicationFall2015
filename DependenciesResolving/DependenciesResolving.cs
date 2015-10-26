using System;
using System.IO;

namespace DependenciesResolving
{
    class DependenciesResolving
    {
        public static String LoadJson()
        {
            using (StreamReader r = new StreamReader("all_packages.json"))
            { 
                string json = r.ReadToEnd();
                //List<String> items = JsonConvert.DeserializeObject<List<String>>(json);
                return json;
            }
        }

        static void Main(string[] args)
        {
            
        }
       
    }
    
}
