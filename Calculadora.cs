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
        inicio:
        Console.WriteLine();
        Console.WriteLine("qual tipo de calculo você deseja fazer?");
        Console.WriteLine("1 - soma");
        Console.WriteLine("2 - divisão");
        Console.WriteLine("3 - multiplicação");
        Console.WriteLine("4 - subtração");
        
        short op = short.Parse(Console.ReadLine());

        if (op != 1 && op != 2 && op != 3 && op != 4) { Console.WriteLine("Opção inválida."); goto inicio; } 
                 
        Console.WriteLine("primeiro valor: "); 
        double num1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("segundo valor: ");  
        double num2 = double.Parse(Console.ReadLine());
            
        switch (op)
        {
            case 1:
                soma(num1, num2);
                break;
            case 2: 
                divisao(num1, num2);
                break;
            case 3:
                subtracao(num1, num2);
                break;
            case 4:
                multiplicacao(num1, num2);
                break;           
        }
        
        Console.ReadLine();   
            
        }

        
        static void soma(double n1, double n2) => Console.WriteLine(n1 + n2);
    
        static void divisao(double n1, double n2) => Console.WriteLine(n1 / n2);
    
        static void subtracao(double n1, double n2) => Console.WriteLine(n1 - n2);
    
        static void multiplicacao(double n1, double n2) => Console.WriteLine(n1 * n2);
        
        
    }
}
