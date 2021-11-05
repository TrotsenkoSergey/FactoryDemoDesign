using System;

namespace FactoryAnimals.Models.DataAccess
{
    public interface IData
    {
        void Save(object toSaves, string pathToFile);

        object Load(string pathToFile);
    }
}
