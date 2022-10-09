using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repository
{
    public interface IPessoaRepository
    {
        bool Add(Pessoa animal);
        List<Pessoa> GetAll();

        bool Delete(Pessoa animal);
    }
}
