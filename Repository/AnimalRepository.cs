using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Config;
using Dapper;
using Models;

namespace Repository
{
    public class AnimalRepository : IAnimalRepository
    {
        public string _conn;
        public AnimalRepository()
        {
            _conn = DataBaseConfiguration.Get();
        }

        public bool Add(Animal animal)
        {
            bool result = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Animal.INSERT, animal);
                result = true;
            }
            return true;
        }

        public List<Animal> GetAll()
        {
            using(var db = new SqlConnection(_conn))
            {
                db.Open();
                var animal = db.Query<Animal>(Animal.SELECT);
                return (List<Animal>)animal;
            }
          
        }
    }
}
