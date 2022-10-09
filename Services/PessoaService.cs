using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository;

namespace Services
{
    public class PessoaService
    {
        private IPessoaRepository _pessoaRepository;
        public PessoaService()
        {
            _pessoaRepository = new PessoaRepository();
        }
        public bool Add(Pessoa pessoa)
        {
            return _pessoaRepository.Add(pessoa);
        }
        public List<Pessoa> GetAll()
        {
            return _pessoaRepository.GetAll();
        }
        public bool Delete(Pessoa pessoa)
        {
            return _pessoaRepository.Delete(pessoa);
        }
    }
}
