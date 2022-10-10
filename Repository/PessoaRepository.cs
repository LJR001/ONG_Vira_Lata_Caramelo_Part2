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
    public class PessoaRepository : IPessoaRepository
    {
        public string _conn;

        public PessoaRepository()
        {
            _conn = DataBaseConfiguration.Get();
        }
        public bool Add(Pessoa pessoa)
        {
            bool result = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Pessoa.INSERT, pessoa);
                result = true;
            }
            return true;
        }
        public List<Pessoa> GetAll()
        {   
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var pessoa = db.Query<Pessoa>(Pessoa.SELECT);
                return (List<Pessoa>)pessoa;
            }

        }
        public bool Delete(Pessoa pessoa)
        {
            bool result = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Pessoa.DELETE, pessoa);
                result = true;
            }
            return true;
        }
        public bool Update(Pessoa pessoa)
        {
            bool result = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Pessoa.UPDATE, pessoa);
                result = true;
            }
            return result;
        }
    }
}
