using System;
using Controllers;
using Models;

namespace ONG_Vira_Lata_Caramelo_Part2
{
    internal class Program
    {

        public static void CadastrarAnimal()
        {
            Animal animal = new Animal();


            //Console.WriteLine(" Cadastro dados do animal\n");
            //Console.Write(" Numero do Chip: ");
            //animal.Numero_Chip = int.Parse(Console.ReadLine());
            //Console.Write(" Nome: ");
            //animal.Nome = Console.ReadLine();
            //Console.Write(" Familia: ");
            //animal.Familia = Console.ReadLine();
            //Console.Write(" Raça: ");
            //animal.Raca = Console.ReadLine();
            //Console.Write(" Sexo: ");
            //animal.Sexo = char.Parse(Console.ReadLine());

            animal.Numero_Chip = 123456;
            animal.Nome = "Azulão";
            animal.Familia = "Canina";
            animal.Raca = "ViraLata";
            animal.Sexo = 'M';


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


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CadastrarAnimal();
        }
    }
}
