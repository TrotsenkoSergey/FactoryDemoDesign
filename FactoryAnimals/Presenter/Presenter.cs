using System;
using FactoryAnimals.Models;
using FactoryAnimals.Models.Animals.Amphibians;
using FactoryAnimals.Models.Animals.Birds;
using FactoryAnimals.Models.Animals.Mammals;
using FactoryAnimals.Models.DataAccess;
using FactoryAnimals.Views;

namespace FactoryAnimals.Presenter
{
    public class Presenter
    {
        private AnimalsRepository _animalsRepository;
        private IView _view;

        private Type _type;

        public Presenter(IView view)
        {
            _view = view;
            _animalsRepository = new AnimalsRepository();
        }

        public void Run()
        {
            bool isRepeat = true;
            while (isRepeat)
            {
                var menu = _view.MainMenu();
                switch (menu)
                {
                    case 1:
                        ChoiceOfAnimalClass().
                        Create().
                        PrintResult();
                        break;
                    case 2:
                        var data = _view.GetData();
                        if (data == typeof(DataJson))
                            Save(DataAccessFactories.GetDataJson());
                        else if (data == typeof(DataTxt))
                            Save(DataAccessFactories.GetDataTxt());
                        else if (data == typeof(DataXml))
                            Save(DataAccessFactories.GetDataXml());
                        break;
                    case 3:
                        _view.ExitMenu();
                        isRepeat = false;
                        break;
                }
            }
        }

        public void Save(IData mode, string pathToFile = "")
        {
            var dataAccess = new DataAccess(mode, _animalsRepository.Animals, pathToFile);
            var info = dataAccess.Save();
            _view.SaveInfo(info);
        }

        public Presenter ChoiceOfAnimalClass()
        {
            _type = _view.ChoiceOfAnimalClass();
            return this;
        }

        public Presenter Create()
        {
            switch (_view.MethodOfCreation())
            {
                case MethodOfCreation.Manually: GetAnimal(); break;
                case MethodOfCreation.Randomly: GetRandomAnimals(); break;
                default: return this;
            }

            return this;
        }

        private Presenter GetAnimal()
        {
            var selection = _view.TypeOfSelection(_type);
            var name = _view.Name;
            var age = _view.Age;
            var weight = _view.Weight;

            if (_type == typeof(Mammal))
            {
                var cubs = _view.NumberOfCubsInLitter;
                _animalsRepository.Add(MammalsFactory.GetMammal(selection, name, age, weight, cubs));
            }
            else if (_type == typeof(Amphibian))
            {
                var isMuscus = _view.PoisonousMucus;
                _animalsRepository.Add(AmphibiansFactory.GetAmphibian(selection, name, age, weight, isMuscus));

            }
            else if (_type == typeof(Bird))
            {
                var feathers = _view.NumberOfFeathers;
                _animalsRepository.Add(BirdsFactory.GetBird(selection, name, age, weight, feathers));
            }
            else return this;

            return this;
        }

        private Presenter GetRandomAnimals()
        {
            var countOfAnimals = _view.CountOfAnimals;

            if (_type == typeof(Mammal))
                _animalsRepository.AddRange(MammalsFactory.GetRandomMammals(countOfAnimals));
            else if (_type == typeof(Amphibian))
                _animalsRepository.AddRange(AmphibiansFactory.GetRandomAmphibians(countOfAnimals));
            else if (_type == typeof(Bird))
                _animalsRepository.AddRange(BirdsFactory.GetRandomBirds(countOfAnimals));

            return this;
        }

        public void PrintResult()
        {
            int counter = default;
            string result = "";

            foreach (var animal in _animalsRepository.Animals)
            {
                result += $"\n{++counter,3}. {animal}";
            }

            _view.PrintResult = result;
        }
    }
}
