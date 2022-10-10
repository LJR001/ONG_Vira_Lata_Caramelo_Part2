using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Controllers
{
    public class PessoaController
    {
        static public Pessoa InserirPessoa(Pessoa pessoa)
        {
            new PessoaService().Add(pessoa);
            return pessoa;
        }
        static public void ImprimirPessoa()
        {
            new PessoaService().GetAll().ForEach(x => Console.WriteLine(x));
        }
        public static Pessoa DeletarPessoa(Pessoa pessoa)
        {
            new PessoaService().Delete(pessoa);
            return pessoa;
        }
        static public Pessoa SelectPessoa(string id)
        {
            var pessoa = new PessoaService().GetAll().Where(item=>item.CPF==id).First();

            return pessoa;
        }
        static public void EditarPessoa(Pessoa pessoa)
        {
            new PessoaService().Update(pessoa);
        }
    }
}
