using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Adocao
    {
        #region Constant
        public readonly static string INSERT = "INSERT INTO Animal(Numero_Chip,Familia,Raca,Sexo,Nome) VALUES(@Numero,@Familia,@Raca,@Sexo,@Nome)";

        public readonly static string SELECT = "SELECT Numero_Chip, Familia, Raca, Sexo, Nome FROM Animal";
        #endregion

        #region Properties
        public DateTime Data_Adocao { get; set; }
        public Pessoa pessoa { get; set; }
        public Animal animal { get; set; }
        #endregion

        public Adocao()
        {


        }

    }
}
