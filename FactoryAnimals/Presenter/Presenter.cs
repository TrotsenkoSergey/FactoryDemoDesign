using FactoryAnimals.Models;
using FactoryAnimals.Views;
using System;

namespace FactoryAnimals.Presenter
{
    public class Presenter
    {
        private AnimalsRepository _animalsRepository;
        private IView _view;

        static int counter;

        public Presenter(IView view)
        {
            _view = view;
            _animalsRepository = new AnimalsRepository();
        }

        public Presenter GetAnimals()
        {
            _view.ChoiceOfAnimalSpecies();
            var selection = _view.MenuSelection(3);
            var countOfAnimals = _view.CountOfAnimals;

            switch (selection)
            {
                case 1:
                    _animalsRepository.AddRange(MammalsFactory.GetRandomMammals(countOfAnimals));
                    break;
                case 2:
                    _animalsRepository.AddRange(AmphibiansFactory.GetRandomAmphibians(countOfAnimals));
                    break;
                case 3:
                    _animalsRepository.AddRange(BirdsFactory.GetRandomBirds(countOfAnimals));
                    break;
            }

            return this;
        }

        public void PrintResult()
        {
            foreach (var animal in _animalsRepository.Animals)
            {
                _view.Result = $"{++counter,3}. {animal}";
            }
        }
    }
}
