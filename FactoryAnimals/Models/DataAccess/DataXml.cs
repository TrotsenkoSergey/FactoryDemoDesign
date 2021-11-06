using System;
using System.IO;
using System.Xml.Serialization;

namespace FactoryAnimals.Models.DataAccess
{
    public class DataXml : IData
    {
        private const string _extension = ".xml";

        public string Save(object objectToSaves, string pathToFile = "")
        {
            if (String.IsNullOrEmpty(pathToFile))
            {
                string directory = Directory.GetCurrentDirectory();
                string fileName = nameof(FactoryAnimals) + _extension;
                pathToFile = Path.Combine(directory, fileName);
            }

            var type = objectToSaves.GetType();

            XmlSerializer xmlSerializer = new XmlSerializer(type);

            using (Stream fStream = new FileStream(pathToFile, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(fStream, objectToSaves);
            }

            return pathToFile;
        }

        public object Load(string pathToFile)
        {
            //to do
            return new object();
        }
    }
}
