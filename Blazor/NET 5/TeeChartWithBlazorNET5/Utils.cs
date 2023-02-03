using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace TeeChartOnBlazor
{
    public class Utils
    {

        public static string getResource(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();

            //gets all resource list
            //string[] names = assembly.GetManifestResourceNames();

            var fullResourceName = "TeeChartOnBlazor.Resources."+ resourceName;

            using (Stream stream = assembly.GetManifestResourceStream(fullResourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
