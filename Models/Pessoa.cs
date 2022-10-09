using System;

namespace Models
{
    public class Pessoa
    {
        #region Constant

        public readonly static string INSERT = "INSERT INTO Pessoa(CPF,Nome,Sexo,Data_Nascimento,Telefone, Logradouro, Numero, Bairro, Cidade, Estado, CEP)VALUES(@CPF,@Nome,@Sexo,@Data_Nasc,@Telefone,@Logradouro,@Numero,@Bairro,@Cidade,@Estado,@CEP)";

        public readonly static string SELECT = "SELECT CPF,Nome,Sexo,Data_Nascimento,Telefone, Logradouro, Numero, Bairro, Cidade, Estado, CEP FROM Pessoa";

        public readonly static string DELETE = "DELETE FROM Pessoa WHERE CPF = @CPF";
        #endregion

        #region Properties
        public string CPF { get; set; }
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public DateTime Data_Nasc { get; set; }
        public string Telefone { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }

        #endregion


        public Pessoa()
        {

        }



        public override string ToString()
        {
            return " DADOS PESSOAIS\n Nome:" + Nome + "\n" +
               " CPF: " + CPF + "\n Sexo: " + Sexo + "\n" +
               " Data de nascimento: " + Data_Nasc + "\n" +
               " Telefone: " + Telefone + "\n " +
               " Logradouro: " + Logradouro + "\n" +
               " Numero:" + Numero + "\n" +
               " Bairro: " + Bairro + "\n" +
               " Cidade: " + Cidade + "\n" +
               " Estado: " + Estado + "\n" +
               " CEP: " + CEP;
        }
    }
    
}
