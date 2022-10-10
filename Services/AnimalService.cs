using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository;

namespace Services
{
    public class AnimalService
    {
        private IAnimalRepository _animalRepository;
        public AnimalService()
        {
            _animalRepository = new AnimalRepository();
        }
        public bool Add(Animal animal)
        {
            return _animalRepository.Add(animal);
        }
        public List<Animal> GetAll()
        {
            return _animalRepository.GetAll();
        }
        public bool Delete(Animal animal)
        {
            return (_animalRepository.Delete(animal));
        }
        public bool Update(Animal animal)
        {
            return !_animalRepository.Update(animal);
        }
    }
}
