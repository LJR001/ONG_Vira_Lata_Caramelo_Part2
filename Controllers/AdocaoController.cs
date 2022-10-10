using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Controllers
{
    public class AdocaoController
    {
        static public Adocao InserirAdocao(Adocao adocao)
        {
            new AdocaoService().Add(adocao);
            return adocao;
        }
    }
}
