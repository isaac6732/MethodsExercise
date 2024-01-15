using System.IO.Pipes;
using System.Xml.Schema;

namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer; 
        }
       
        public static int Multiply(int num1, int num2, int num3)
        {
            var answer = num1 * num2 * num3;
            return answer;
        }
       
        public static int Multiply(int num1, int num2,int num3,int num4)
        {
            var answer = num1 * num2 * num3 * num4;
            return answer;
        }
       
        public static int Subtract(int num1, int num2)
        {
            var answer = num1 - num2;
            return answer;
        }
       
        public  static int Divide(int num1,int num2)
        {
            var answer = (num1 / num2);
            return answer;
        }
       
        static int Sum(params int[] prices)
        {
            int total = 0;
            
            foreach (int price in prices)
            {
                total += price; 
            }
            return total;
        }
        
        public static void Profile()
        {
            Console.WriteLine("Hello - What is your firs name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName} - What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} That is a nices color - What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Nices! - What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks for your infomation, {userName}! Here is your profile");
            Console.WriteLine("-----------------------------");

            Console.WriteLine($"Name {userName}");
            Console.WriteLine($"Favorite Color {color}");
            Console.WriteLine($"Favorite Animal {animal}");
            Console.WriteLine($"Favorite Band {band}");
        }
          
        static void Main(string[] args)
        {
            var stones = Sum(5, 6);
            //Console.WriteLine(stones); 
            var homes = Multiply(2, 4, 6);
            //Console.WriteLine(homes);
            var trees = Multiply(3, 5, 7, 9);
            //Console.WriteLine(trees);
            var money = Subtract(300, 100);
            //Console.WriteLine(money);
            var problems = Divide(144, 12);
            //Console.WriteLine(problems);
            
            var total = Sum(3, 5, 7, 8, 7);
            //Console.WriteLine(total);
            //Console.ReadKey();

         
            //Profile();



        }
    }
}
