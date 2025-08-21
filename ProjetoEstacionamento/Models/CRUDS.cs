using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.Models
{
    public class CRUDS
    {
        public static int FirstCrud() //FUNCIONANDO PERFEITAMENTE!!! NÃO MEXER!!!
        {

            do
            {
                Console.WriteLine("\nHey, user! Select one of these options:");
                Console.WriteLine("\n1 - See cars in parking\n"); //Already has a feature
                Console.WriteLine("2 - See free spots on parking\n"); //Already has a feature
                Console.WriteLine("3 - Register a new car\n"); //Already has a feature
                Console.WriteLine("4 - See how much time a car has been parked\n"); //Do this feature
                Console.WriteLine("5 - Remove a car from the parking\n"); //Already has a function
                Console.WriteLine("6 - Pay for a parking fee used.\n"); //Already has a function
                Console.WriteLine("7 - Exit the program\n");
                Console.Write("Option: ");


                int conclusion = int.TryParse(Console.ReadLine(), out int option) ? option : 0;
                //Preciso explicar: Basicamente recebe o valor inserido em Console.ReadLine e tenta converter para inteiro.
                // Se não conseguir retorna como 0. Dessa forma mesmo que seja digitado algo que não é um número, ele vai interpretar como um número
                // menor do que o mínimo aceitável, que é 1, o que faz com que o loop se repita.

                if (conclusion == 7)
                {
                    Console.WriteLine("\nSee you later!");
                    Environment.Exit(0);
                }

                if (conclusion < 1 || conclusion > 7)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid option, please, choose a valid one.");
                }
                else
                {
                    return (int)conclusion;
                }
            } while (true);
        }

        // public static int SecondCrud()
        // {
            
        // }
    }
}