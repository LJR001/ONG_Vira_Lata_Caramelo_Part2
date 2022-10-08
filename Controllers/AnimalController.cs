using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Controllers
{
    public class AnimalController
    {
        static public Animal InserirAnimal(Animal animal)
        {
            new AnimalService().Add(animal);
            return animal;
        }
        
    }
}
