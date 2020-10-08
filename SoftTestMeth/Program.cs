using System;
using System.Data;

namespace SoftTestMeth
{
    class Program
    {
        static int number;
        static void Main(string[] args)
        {
            Program Obj = new Program();
            Obj.Menu();//Call Menu() Method
        }
        public void Input()
        {
            string result;
            Program Obj = new Program();
            int side1, side2, side3;
            if (number == 1)
            {
                Console.WriteLine("Enter Side1:");
                side1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Side2:");
                side2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Side3:");
                side3 = int.Parse(Console.ReadLine());
                result = TriangleSolver.Analyze(side1, side2, side3);//Call Triangle.Analyze() method 
                Console.WriteLine(result);//Display Result
            }
            else if (number == 2)
            {
                Environment.Exit(0);//Exit the Program
            }
            else
            {
                Obj.Menu();//Call Menu() Method
            }
        }
        public void Menu()
        {
            Console.WriteLine("1 Enter triangle dimensions"); //Display Menu
            Console.WriteLine("2 Exit");
            number = int.Parse(Console.ReadLine());
            Program Obj = new Program();
            Obj.Input();//Call Input() Method

        }
    }
    
}
