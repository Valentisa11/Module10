using Module10;
using System;
using System.IO;


namespace Module10Task1_2
{
    class Program
    {
        static ILogger? Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            Calculate calculate = new(Logger);
            int a, b;

            Exception exceptionnum = new("Вы не ввели число");// ошибки, когда не введено число

            
            while (true)

            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                
                Console.WriteLine("\tКалькулятор\r");
                Console.WriteLine("------------------------\n");

                try
                {

                    Console.WriteLine("Введите число, а затем нажмите Enter");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите второе число, а затем нажмите Enter");
                    b = Convert.ToInt32(Console.ReadLine());

                    var result = ((ISum)calculate).Sum(a, b);//выделение синим цветом
                    Console.WriteLine(result);
                    Console.ReadKey();
                    
                }




                catch (Exception ex)
                {

                    Logger.Error("Вы не ввели число");
                    Console.WriteLine(ex.Message);
                    

                }
                
                Console.ReadKey();
                

            } return;



        }
    }
}
