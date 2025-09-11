using System;
using C_sharp_practice.math;

namespace C_sharp_practice
{
    //Class declaration system 
    public class person
    {
        public string firstname; //parameter
        public string lastname; //parameter
        public int age; //parameter

        public void introduct() //method or function 
        {
            Console.WriteLine("My name is " + firstname + " " + lastname + " " + " and My age is " + age); 
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! "); //print value
            Console.Write("Hello World!"); //print value without new line

            //var name = Console.ReadLine(); //input value
            //var age = Console.ReadLine(); //input value
            //Console.WriteLine (name + " " + age ); //print value

            person man = new person(); //object creation " access modifier object name = new class name()"
            man.firstname = "samiul"; //parameter value assign
            man.lastname = "islam"; //parameter value assign
            man.age = 22; //parameter value assign
            man.introduct(); //method call


            //calculator folder call or import any folder 
            var value = calculator.add(5, 10); //class name . method name (parameter value)
            Console.WriteLine(value); //print value


            // array system or array declaration or array initialization
            string[] cars = { "volvo", "bmw", "ford" }; //data type [] array name = { "value1", "value2", "value3"}
            Console.WriteLine(cars[0]); //print array value

            int[] numbers = { 10, 20, 30 }; //data type [] array name = { value1, value2, value3}
            Console.WriteLine(numbers[2]); //print array value


            //String in C# or string declaration
            string firstname = "samiul"; //data type variable name = "value"
            string lastname = "islam"; //data type variable name = "value"
            string fullname = string.Concat(firstname, lastname); //string fullname = string.Concat(variable1, variable2)
            Console.WriteLine(fullname); //print value
            Console.WriteLine(firstname.IndexOf("a")); //print value


            ////Enum system or enum declaration
            //const int small = 1; //constant data type variable name = value
            //const int medium = 2; //constant data type variable name = value
            ////instead of constant we can use enum system. where we can declare multiple value in one variable
            //public enum size
            //{
            //    small = 1, //enum variable name = value
            //    medium = 2, //enum variable name = value
            //    large = 3 //enum variable name = value
            //}

            //conditional statement 


            //if else system or if else declaration

            int age = 18; //data type variable name = value
            if (age < 18) //if (condition)
            {
                Console.WriteLine("You are not eligible for vote"); //print value
            }
            else //else
            {
                Console.WriteLine("You are eligible for vote"); //print value
            }

            //conditional statement 
            var output = (age < 18) ? "You are not eligilble for vaote" : "YOu are eligible for vote"; //var variable name = (condition)?"value1":"value2"`
            Console.WriteLine(output); //print value

            //switch case system or switch case declaration
            var season = Season.winter; //enum variable name = enum class name.enum value
            switch (season) //switch (variable name)
            {
                case Season.spring: //case enum class name.enum value
                    Console.WriteLine("It is spring season"); //print value
                    break; //break
                case Season.summer: //case enum class name.enum value
                    Console.WriteLine("It is summer season"); //print value
                    break; //break
                case Season.autumn: //case enum class name.enum value
                    Console.WriteLine("It is autumn season"); //print value
                    break; //break
                case Season.winter: //case enum class name.enum value
                    Console.WriteLine("It is winter season"); //print value
                    break; //break
                default: //default
                    Console.WriteLine("Invalid season"); //print value
                    break; //break
            }


            //loop system or loop declaration
            //for loop
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + "\t");
            }
            //while loop
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }
            //do while loop
            int k = 0;
            do
            {
                Console.Write(k+"\t");
                k++;
            } while (k < 10);
            //foreach loop
            string[] car = { "volvo", "bmw", "ford" };
            foreach (var c in car)
            {
                Console.WriteLine(c);
            }


        }
    }
}
