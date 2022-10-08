﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Animal
    {
        #region Constant
        public readonly static string INSERT = "INSERT INTO Animal(Numero_Chip,Familia,Raca,Sexo,Nome) VALUES(@Numero,@Familia,@Raca,@Sexo,@Nome)";

        public readonly static string SELECT = "SELECT Numero_Chip, Familia, Raca, Sexo, Nome FROM Animal";
        #endregion

        #region Properties
        public int Numero_Chip { get; set; }
        public string Familia { get; set; }
        public string Raca { get; set; }
        public char Sexo { get; set; }
        public string Nome { get; set; }
        #endregion

        public Animal()
        {

        }

        public override string ToString()
        {
            return " Dados de animal\n Nome: " + Nome + "\n Familia: " + Familia + "\n" +
                " Raça: " + Raca + "\n Sexo: " + Sexo;
        }

    }
}