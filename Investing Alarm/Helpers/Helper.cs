using Investing_Alarm.Items;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Investing_Alarm.Helpers
{
    public static class Helper
    {
        public static SoundPlayer sound;

        public static void GetSound()
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resourcePath = "alarmsound1.wav";
            resourcePath = assembly.GetManifestResourceNames()
                    .Single(str => str.EndsWith("alarmsound1.wav"));
            // Format: "{Namespace}.{Folder}.{filename}.{Extension}"

            Stream stream = assembly.GetManifestResourceStream(resourcePath);
            sound = new SoundPlayer(stream);
        }

        public static void WriteToJsonFile(string value)
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string folderName = Application.ProductName;
            string path = System.IO.Path.Combine(appDataPath, folderName);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filePath = path + "/SavedInstruments.json";
            System.IO.File.WriteAllText(filePath, value);
        }

        public static void AddNewInstrumentIntoJson(Instrument item)
        {
            try
            {
                var jsonString = ReadSavedInstruments();
                var items = JsonConvert.DeserializeObject<List<Instrument>>(jsonString);

                items.Add(item);
                var newJson = JsonConvert.SerializeObject(items);
                WriteToJsonFile(newJson);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }


        public static List<Instrument> GetInstruments()
        {
            try
            {
                var jsonString = ReadSavedInstruments();
                return JsonConvert.DeserializeObject<List<Instrument>>(jsonString);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Console.WriteLine(e.Message);
                return new List<Instrument>();
            }
        }


        public static string ReadSavedInstruments()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string folderName = Application.ProductName;
            string path = System.IO.Path.Combine(appDataPath, folderName);
            
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                var filePath_ = path + "/SavedInstruments.json";
                var val = JsonConvert.SerializeObject(new List<Instrument>());
                System.IO.File.WriteAllText(filePath_,val );
            }

            string filePath = path + "/SavedInstruments.json";
            string json = System.IO.File.ReadAllText(filePath);
            return json;
        }

        public static void WriteIntoResource(string filename, string value)
        {
            // Determine path
            var assembly = Assembly.GetExecutingAssembly();
            string resourcePath = filename;
            resourcePath = assembly.GetManifestResourceNames()
                    .Single(str => str.EndsWith(filename));
            // Format: "{Namespace}.{Folder}.{filename}.{Extension}"

            using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine("{ \"key\": \"value\" }");
            }
        }


        public static void WriteToResource(string name, string value)
        {

            string resourcePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // Build the full path to the file in the resource folder
            string filePath = Path.Combine(resourcePath, "Resource", name);
            Console.WriteLine(filePath);
            // Write the data to the file
            File.WriteAllText(filePath, "Hello, world!");
        }


        public static string GetResourcePath(string name)
        {

            // Determine path
            var assembly = Assembly.GetExecutingAssembly();
            string resourcePath = name;
            resourcePath = assembly.GetManifestResourceNames()
                    .Single(str => str.EndsWith(name));
            // Format: "{Namespace}.{Folder}.{filename}.{Extension}"
            return resourcePath;
        }
    }
}
