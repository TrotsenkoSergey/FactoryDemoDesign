using System;

namespace FactoryAnimals.Models.DataAccess
{
    public interface IData
    {
        string Save(object toSaves, string pathToFile);

        object Load(string pathToFile);
    }
}
