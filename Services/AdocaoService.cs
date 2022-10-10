using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository;

namespace Services
{
    public class AdocaoService
    {
        private IAdocaoRepository _adocaoRepository;
        public AdocaoService()
        {
            _adocaoRepository = new AdocaoRepository();
        }
        public bool Add(Adocao adocao)
        {
            return _adocaoRepository.Add(adocao);
        }
    }
}
