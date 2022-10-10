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
    public class AdocaoRepository : IAdocaoRepository
    {
        public string _conn;
        
        public AdocaoRepository()
        {
            _conn = DataBaseConfiguration.Get();
        }

        public bool Add(Adocao adocao)
        {
            bool result = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Adocao.INSERT, adocao);
                result = true;
            }
            return true;
        }
    }
}
