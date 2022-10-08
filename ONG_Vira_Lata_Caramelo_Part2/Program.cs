using System;
using Models;

namespace ONG_Vira_Lata_Caramelo_Part2
{
    internal class Program
    {

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

            Console.WriteLine("\nCadastro finalizado!\n\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();

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
