using System;
using Newtonsoft.Json;
using System.IO;

namespace FactoryAnimals.Models.DataAccess
{
    public class DataJson : IData
    {
        private const string _extension = ".json";

        public string Save(object objectToSaves, string pathToFile = "")
        {
            if (String.IsNullOrEmpty(pathToFile))
            {
                string directory = Directory.GetCurrentDirectory();
                string fileName = nameof(FactoryAnimals) + _extension;
                pathToFile = Path.Combine(directory, fileName);
            }

            var type = objectToSaves.GetType();
            string json = JsonConvert.SerializeObject(objectToSaves, type, null);
            File.WriteAllText(pathToFile, json);

            return pathToFile;
        }

        public object Load(string pathToFile)
        {
            //to do
            return new object();
        }
    }
}
