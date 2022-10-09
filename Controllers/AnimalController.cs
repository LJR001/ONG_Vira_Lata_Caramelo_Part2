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
        static public void ImprimirAnimal()
        {
            new AnimalService().GetAll().ForEach(x => Console.WriteLine(x));
        }
        static public Animal DeletarAnimal(Animal animal)
        {
            new AnimalService().Delete(animal);
            return animal;
        }

       
    }
}
