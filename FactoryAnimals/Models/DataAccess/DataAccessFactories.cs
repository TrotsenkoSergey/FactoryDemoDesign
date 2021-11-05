using System;

namespace FactoryAnimals.Models.DataAccess
{
    public static class DataAccessFactories
    {
        public static DataXml GetDataXml() => new DataXml();
        public static DataJson GetDataJson() => new DataJson();
        public static DataTxt GetDataTxt() => new DataTxt();
    }
}
