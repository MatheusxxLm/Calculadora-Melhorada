using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
            
        }
        static void menu()
        {
            Console.WriteLine("qual tipo de calculo você deseja fazer?");
            Console.WriteLine("1 - soma");
            Console.WriteLine("2 - divisão");
            Console.WriteLine("3 - multiplicação");
            Console.WriteLine("4 - subtração");
            Console.WriteLine("5 - sair");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("selecione a opção");
            short op = short.Parse(Console.ReadLine());

            if (op == 1)
            {
                soma();
            }
            else if (op == 2)
            {
                divisao();
            }
            else if (op == 3)
            {
                multiplicacao();
            }
            else if (op == 4)
            {
                subtracao();
            }
            else if (op == 5)
            {
                System.Environment.Exit(0);
            }
            else if (op >= 6)
            {
                
                Console.WriteLine("opção inválida.");
                Console.WriteLine("////////////////////////////////////");
            }
            menu();
            Console.ReadLine();
            
        }
        static void soma()
        {

            Console.WriteLine("primeiro valor: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("segundo valor: ");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = num1 + num2;
            Console.WriteLine("o resultado é ");
            Console.WriteLine($"{num1 + num2}");
            Console.ReadLine();

        }
        static void divisao()
        {
            Console.WriteLine("primeiro valor: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("segundo valor: ");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = num1 / num2;
            Console.WriteLine("o resultado é ");
            Console.WriteLine($"{num1 / num2}");
            Console.ReadLine();
        }
        static void subtracao()
        {
            Console.WriteLine("primeiro valor: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("segundo valor: ");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = num1 - num2;
            Console.WriteLine("o resultado é ");
            Console.WriteLine($"{num1 - num2}");
            Console.ReadLine();
        }
        
        static void multiplicacao()
        {
            Console.WriteLine("primeiro valor: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("segundo valor: ");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = num1 * num2;
            Console.WriteLine("o resultado é ");
            Console.WriteLine($"{num1 * num2}");
            Console.ReadLine();
        }

        

    }
}
