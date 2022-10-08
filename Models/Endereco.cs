using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Endereco
    {
        public string Id_Endereco { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }

        public override string ToString()
        {
            return "\n Dados de endereço\n Logradouro: " + Logradouro + "\n" +
                " Numero:" + Numero + "\n Bairro: " + Bairro + " Cidade: " + Cidade + "\n" +
                " Estado: " + Estado + "\n CEP: " + CEP;
        }
    }
}
