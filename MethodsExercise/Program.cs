using System;

namespace MethodsExercise
{
    class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, int num2)
        {
            return num1 / num2;
        }

        static void Main(string[] args)
        {
            //exercise 1

            Console.WriteLine("What is your name?"); //output
            var userName = Console.ReadLine(); //input

            Console.WriteLine("Where do you live?"); //output
            var userCity = Console.ReadLine(); //input

            Console.WriteLine("What color is your house?"); //output
            var userHouse = Console.ReadLine(); //input

            Console.WriteLine("What car do you drive?"); //output
            var userCar = Console.ReadLine(); //input

            Console.WriteLine($"Hi! My name is {userName}. I live in a {userHouse} house in {userCity} and drive a {userCar}.");


            //exercise 2

            var numApples = Add(3, 5);
            var numOranges = Subtract(4, 2);
            var numPears = Multiply(2, 4);
            var numPeaches = Divide(9.0, 3);

            Console.WriteLine($"There are {numApples} apples, {numOranges} oranges, {numPears} pears and {numPeaches} peaches in the kitchen.");

        }
        
    }

}