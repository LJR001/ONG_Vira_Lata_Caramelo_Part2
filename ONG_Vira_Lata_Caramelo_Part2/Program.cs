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

            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();

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
            Console.WriteLine(" Digite o Numero do chip do animal");
            int id = int.Parse(Console.ReadLine());
            var animal = AnimalController.SelectAnimal(id);
            Console.WriteLine("\n"+animal);
            do
            {
                int opc = 6;
                Console.WriteLine(" Digite a opção que deseja atualizar do aniamal");
                Console.WriteLine("    Opção 1: Atualizar nome ");
                Console.WriteLine("    Opção 2: Atualizar familia");
                Console.WriteLine("    Opção 3: Atualizar raça ");
                Console.WriteLine("   Opção 4: Atualizar sexo ");



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
                        Console.WriteLine(" Digite o novo nome");
                        animal.Nome = Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine(" Digite a familia ");
                        animal.Familia= Console.ReadLine(); 
                        break;

                    case 3:
                        Console.WriteLine(" Digite a raça ");
                        animal.Raca= Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine(" Digite o sexo");
                        animal.Sexo=char.Parse(Console.ReadLine());
                        break;
                   
                    default:
                        Console.Write("\n Opcao Inválida!\n Digite novamente: ");
                        break;
                }
                AnimalController.EditarAnimal(animal);

                Console.WriteLine("\n" + animal);

            } while (true);
            

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
            pessoa.CPF = Console.ReadLine().Replace(".", "").Replace("-", "");
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

            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
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
            Console.WriteLine(" Digite o CPF da pessoa");
            string id = Console.ReadLine().Replace(".", "").Replace("-", "");
            var pessoa = PessoaController.SelectPessoa(id);
            Console.WriteLine("\n" + pessoa);
            do
            {
                int opc = 11;
                Console.WriteLine(" Digite a opção que deseja atualizar do aniamal");
                Console.WriteLine("   Opção 1: Atualizar nome ");
                Console.WriteLine("   Opção 2: Atualizar sexo");
                Console.WriteLine("   Opção 3: Atualizar Data de nascimento (Não Funcional) ");
                Console.WriteLine("   Opção 4: Atualizar Telefone ");

                Console.WriteLine("   Opção 5: Atualizar Logradouro ");
                Console.WriteLine("   Opção 6: Atualizar Numero ");
                Console.WriteLine("   Opção 7: Atualizar Bairro ");
                Console.WriteLine("   Opção 8: Atualizar Cidade ");
                Console.WriteLine("   Opção 9: Atualizar Estado ");
                Console.WriteLine("   Opção 10: Atualizar CEP ");




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
                        Console.WriteLine(" Digite o novo nome");
                        pessoa.Nome = Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine(" Digite o sexo ");
                        pessoa.Sexo =char.Parse(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine(" Infelizmente essa opção não está disponivel");
                       // pessoa.Data_Nasc =DateTime.Parse(Console.ReadLine());
                        break;

                    case 4:
                        Console.WriteLine(" Digite o Telefone");
                        pessoa.Telefone = Console.ReadLine();
                        break;


                    case 5:
                        Console.WriteLine(" Digite o logradouro");
                        pessoa.Logradouro = Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine(" Digite o numero");
                        pessoa.Numero= Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine(" Digite o bairro");
                        pessoa.Bairro = Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine(" Digite o cidade");
                        pessoa.Cidade = Console.ReadLine();
                        break;
                    case 9:
                        Console.WriteLine(" Digite o estado");
                        pessoa.Estado = Console.ReadLine();
                        break;
                    case 10:
                        Console.WriteLine(" Digite o CEP");
                        pessoa.CEP = Console.ReadLine();
                        break;

                    default:
                        Console.Write("\n Opcao Inválida!\n Digite novamente: ");
                        break;
                }
                PessoaController.EditarPessoa(pessoa);

                Console.WriteLine("\n" + pessoa);

            } while (true);
        }

        #endregion

        public static void AdotarAnimal()
        {
            Adocao adotar = new Adocao();

            Console.WriteLine(" Adoção de um animal\n");
            Console.Write(" Numero do Chip do animal: ");
            adotar.Numero_Chip = int.Parse(Console.ReadLine());
            Console.Write(" CPF do adotante: ");
            adotar.CPF = Console.ReadLine().Replace(".", "").Replace("-", "");

            adotar.Data_Adocao = DateTime.Now;


            Console.WriteLine("\nCadastro finalizado!\n\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();


            AdocaoController.InserirAdocao(adotar);

            Console.WriteLine(" Os dados que foram informados são: \n");
            Console.WriteLine(adotar.ToString());


            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        #region MenuInicial
        static void Main(string[] args)
        {
            do
            {
                int opc = 10;
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
                        EditarPessoa();
                        break;
                    case 6:
                        Console.Clear();
                        EditarAnimal();
                        break;
                    case 7:
                        Console.Clear();
                        DeletarPessoa();
                        break;
                    case 8:
                        Console.Clear();
                        DeletarAnimal();
                        break;
                    case 9:
                        Console.Clear();
                        AdotarAnimal();
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
