using System;
using Controllers;
using Models;

namespace ONG_Vira_Lata_Caramelo_Part2
{
    internal class Program
    {
        #region CRUD_Animal
        public static void CadastrarAnimal()
        {
            Animal animal = new Animal();


            Console.WriteLine(" Cadastro dados do animal\n");
            Console.Write(" Numero do Chip: ");
            animal.Numero_Chip = int.Parse(Console.ReadLine());
            Console.Write(" Nome: ");
            animal.Nome = Console.ReadLine();
            Console.Write(" Familia: ");
            animal.Familia = Console.ReadLine();
            Console.Write(" Raça: ");
            animal.Raca = Console.ReadLine();
            Console.Write(" Sexo: ");
            animal.Sexo = char.Parse(Console.ReadLine());

            //animal.Numero_Chip = 123456;
            //animal.Nome = "Azulão";
            //animal.Familia = "Canina";
            //animal.Raca = "ViraLata";
            //animal.Sexo = 'M';


            Console.WriteLine("\nCadastro finalizado!\n\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();

            
            AnimalController.InserirAnimal(animal);

            Console.WriteLine(" Os dados que foram informados são: \n");
            Console.WriteLine(animal.ToString());


            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
                                    
        }

        public static void ImprimirAnimais()
        {
            Console.WriteLine(" Lista de animais: ");
            AnimalController.ImprimirAnimal();
            
        }

        public static void DeletarAnimal()
        {
            Animal animal = new Animal();


            Console.WriteLine(" Deletar cadastro de um animal\n");
            Console.Write(" Informe o Numero do Chip: ");
            animal.Numero_Chip = int.Parse(Console.ReadLine());

            AnimalController.DeletarAnimal(animal);

            Console.WriteLine(" Os dados que foram deletador são: \n");
           


            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();


        }
        public static void EditarAnimal()
        {

        }

        #endregion

        #region CRUD_Pessoa
        public static void CadastrarPessoa()
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine(" Cadastro dados pessoais do adotante\n");
            Console.Write(" Nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write(" CPF: ");
            pessoa.CPF = Console.ReadLine();
            Console.Write(" Sexo: ");
            pessoa.Sexo = char.Parse(Console.ReadLine());
            Console.Write(" Data Nascimento: ");
            pessoa.Data_Nasc = DateTime.Parse(Console.ReadLine());
            Console.Write(" Telefone: ");
            pessoa.Telefone = Console.ReadLine();

            Console.Write("\nCadastro dados de endereço do adotante\n");
            Console.Write(" Logradouro: ");
            pessoa.Logradouro = Console.ReadLine();
            Console.Write(" Numero: ");
            pessoa.Numero = Console.ReadLine();
            Console.Write(" Bairro: ");
            pessoa.Bairro = Console.ReadLine();
            Console.Write(" Cidade: ");
            pessoa.Cidade = Console.ReadLine();
            Console.Write(" Estado: ");
            pessoa.Estado = Console.ReadLine();
            Console.Write(" CEP: ");
            pessoa.CEP = Console.ReadLine();


            Console.WriteLine("\nCadastro finalizado!\n\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();


            PessoaController.InserirPessoa(pessoa);

            Console.WriteLine(" Os dados que foram informados são: \n");
            Console.WriteLine(pessoa.ToString());


            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        public static void ImprimirPessoas()
        {
            Console.WriteLine(" Lista de pessoa: ");
            PessoaController.ImprimirPessoa();
        }
        public static void DeletarPessoa()
        {
            Pessoa pessoa = new Pessoa();


            Console.WriteLine(" Deletar cadastro de um animal\n");
            Console.Write(" Informe o Numero do Chip: ");
            pessoa.CPF = Console.ReadLine();

            PessoaController.DeletarPessoa(pessoa);

            Console.WriteLine(" Os dados que foram deletador são: \n");



            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();


        }
        public static void EditarPessoa()
        {

        }

        #endregion


        #region MenuInicial
        static void Main(string[] args)
        {
            do
            {
                int opc = 6;
                Console.Clear();
                Console.WriteLine(" Sistema de adoção da ONG Vira - Lata caramelo ");
                Console.WriteLine("\n    Opção 1: Cadastrar  pessoa ");
                Console.WriteLine("    Opcão 2: Cadastrar animal");
                Console.WriteLine("    Opção 3: Ver lista de pessoas cadastradas");
                Console.WriteLine("    Opção 4: Ver lista de animais cadastrados");
                Console.WriteLine("    opção 5: Editar cadastro de uma pesssoa");
                Console.WriteLine("    opção 6: Editar cadastro de um animal");
                Console.WriteLine("    Opção 7: Apagar cadastro de uma pessoa");
                Console.WriteLine("    Opção 8: Apagar cadastro de um animal");
                Console.WriteLine("    Opção 9: Adotar um animal");
                Console.WriteLine("    Opção 0: Finalizar programa");

                Console.Write("\n Informe a opção: ");

                try
                {
                    opc = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                }

                switch (opc)
                {
                    case 0:
                        Console.Clear();
                        Environment.Exit(0);
                        break;

                    case 1:
                        Console.Clear();
                        CadastrarPessoa();
                        break;
                    case 2:
                        Console.Clear();
                        CadastrarAnimal();
                        break;

                    case 3:
                        Console.Clear();
                        ImprimirPessoas();
                        break;

                    case 4:
                        Console.Clear();
                        ImprimirAnimais();
                        break;
                    case 5:
                        Console.Clear();
                     
                        break;
                    case 6:
                       
                        break;
                    case 7:
                        Console.Clear();
                        DeletarAnimal();
                        break;
                    case 8:
                        Console.Clear();
                        DeletarAnimal();
                        break;

                    default:
                        Console.Write("\n Opcao Inválida!\n Digite novamente: ");
                        break;
                }
            } while (true);
        }
        #endregion
    }
}
