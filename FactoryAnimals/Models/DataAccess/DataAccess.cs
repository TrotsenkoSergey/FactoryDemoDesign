using System;

namespace FactoryAnimals.Models.DataAccess
{
    public class DataAccess
    {
        public IData Mode { get; set; }

        public object DataObject { get; set; }

        public string PathToFile { get; set; }

        public DataAccess(IData mode, object dataObject = null, string pathToFile = "")
        {
            Mode = mode;
            DataObject = dataObject;
            PathToFile = pathToFile;
        }

        public string Save()
        {
            return Mode.Save(DataObject, PathToFile);
        }

        public object Load()
        {
            return Mode.Load(PathToFile);
        }
    }
}
