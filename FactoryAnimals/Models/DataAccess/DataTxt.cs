using System;
using System.IO;

namespace FactoryAnimals.Models.DataAccess
{
    public class DataTxt : IData
    {
        private const string _extension = ".txt";

        public string Save(object objectToSaves, string pathToFile = "")
        {
            if (String.IsNullOrEmpty(pathToFile))
            {
                string directory = Directory.GetCurrentDirectory();
                string fileName = nameof(FactoryAnimals) + _extension;
                pathToFile = Path.Combine(directory, fileName);
            }

            if (File.Exists(pathToFile)) File.Delete(pathToFile);

            foreach (var animal in (objectToSaves as AnimalsRepository).Animals)
            {
                File.AppendAllText(pathToFile, $"{animal.ToString()}\n");
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
