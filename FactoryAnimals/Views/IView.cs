using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAnimals.Views
{
    public interface IView
    {
        void ChoiceOfAnimalSpecies();

        int MenuSelection(int numberOfSelectedElements);

        int CountOfAnimals { get; }

        string Result { set; }
    }
}
