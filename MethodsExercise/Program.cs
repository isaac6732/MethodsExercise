namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //                                                               EXS 1

            //Name: Isaac

            //Favorite Color: Red

            //Favorite Animal: Cat's

            //Favorite Band: Bring Me The Horizon

            Console.WriteLine("Hello - What is your firs name?");
            var userName = Console.ReadLine();
            
            Console.WriteLine($"Hi, {userName} - What is your favorite color?");
            var color = Console.ReadLine();
            
            Console.WriteLine($"{color} that is a nices color - What is your favorite animal?");
            var animal = Console.ReadLine();
           
            Console.WriteLine("Nices! - What is your favorite band?");
            var band = Console.ReadLine();
        }
    }
}
