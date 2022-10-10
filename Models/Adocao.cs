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
        public readonly static string INSERT = "INSERT INTO Adocao(Numero_Chip,CPF,Data_adocao) VALUES(@Numero_Chip,@CPF,@Data_Adocao)";

        public readonly static string SELECT = "SELECT Numero_Chip, Familia, Raca, Sexo, Nome FROM Animal";
        #endregion

        #region Properties
        public DateTime Data_Adocao { get; set; }
        public string CPF { get; set; }
        public int Numero_Chip { get; set; }
        #endregion

        public Adocao()
        {


        }
        public override string ToString()
        {
            return "Dados de adoção\n CPF adotante: "+CPF+"\n" +
                "Numero do animal: "+Numero_Chip+"\n" +
                "Data da adoção: "+Data_Adocao;
        }

    }
}
