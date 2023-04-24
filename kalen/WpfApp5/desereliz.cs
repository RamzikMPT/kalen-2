using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    internal class desereliz
    {
        
        static string put = $@"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}\sohranenie\sohr.json";

        public static void SerializeToJsonFile<T>(List<T> serializableList, string filePath)
        {
            try
            {
                string json = JsonConvert.SerializeObject(serializableList);
                string directory = Path.GetDirectoryName(filePath);

                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                File.WriteAllText(filePath, json);
                Console.WriteLine("Data has been saved to " + filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while writing to file: " + ex);
            }
        }

        public static List<T> Deserialization<T>()
        {
            List<T> serializedList = new List<T>();
            if (!File.Exists(put))
                return serializedList;
            string json = File.ReadAllText(put);
            serializedList = JsonConvert.DeserializeObject<List<T>>(json);
            return serializedList;
        }
    }
}
