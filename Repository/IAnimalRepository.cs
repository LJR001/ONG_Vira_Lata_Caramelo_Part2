using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repository
{
    public interface IAnimalRepository
    {
        bool Add(Animal animal);
        List<Animal> GetAll();
        bool Delete(Animal animal);
        bool Update(Animal animal);
    }
}
