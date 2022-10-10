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
        static public Animal SelectAnimal(int id)
        {
            
            var animal = new AnimalService().GetAll().Where(item =>item.Numero_Chip == id).First();
                      
            return animal;
        }
        static public void EditarAnimal(Animal animal)
        {
            new AnimalService().Update(animal);
        }

       
    }
}
