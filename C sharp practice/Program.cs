using System;
using System.Collections.Generic;
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

    //oop concept

    class Animal
    {
        public string name;
        public int agees;
        public static int animalcount = 0;

        //method
        public void info()
        {
            Console.WriteLine($"Name: {name}, Age: {agees}");
        }

        //constructor declaration
        public Animal(string _name, int _age)
        {
            name= _name;
            agees= _age;
            animalcount++;
        }
    }

    //Inheritance

    class Dog : Animal
    {
        public string breed;

        public Dog(string _name, int _age, string _breed) : base(_name, _age)
        {
            breed = _breed;
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
                Console.Write(k + "\t");
                k++;
            } while (k < 10);
            //foreach loop
            string[] car = { "volvo", "bmw", "ford" };
            foreach (var c in car)
            {
                Console.WriteLine(c);
            }


            //Method call
            int Myage = Age(2024, 2002); //data type variable name = method name (parameter1 value, parameter2 value)
            Console.WriteLine(Myage); //print value


            //array and list

            //array declaration
            int[] numberes = new int[] { 1, 2, 3, 4, 5 }; //data type [] array name = new data type[] { value1, value2, value3
            foreach ( var number in numberes) //foreach (var variable name in array name)
            {
                Console.WriteLine(number);
            }

            //list declaration
            List<string> strings = new List<string>(); //List<data type> list name = new List<data type>()
            strings.Add("samiul"); //list name.Add("value")
            strings.Add("islam"); //list name.Add("value")
            strings.Add("tuhin"); //list name.Add("value")

            strings.RemoveAt(1); //list name.RemoveAt(index number)

            foreach (var str in strings) //foreach (var variable name in list name)
            {
                Console.WriteLine(str);
            }

            //or using for loop

            for(int i=0;i<strings.Count;i++) //for(int i=0;i<list name.Count;i++)
            {
                Console.WriteLine(strings[i]); //print list value
            }


            //oop system or oop declaration

            Animal dog = new Animal("cow",20); //access modifier object name = new class name()
            dog.info(); //method call

            Animal cat = new Animal("cat", 5);//access modifier object name = new class name()
            cat.info(); //method call

            Console.WriteLine("Total animal: " + Animal.animalcount); //print value
            //static variable call using class name.variable name

            //inheritance system or inheritance declaration

            Dog dog1 = new Dog("dog", 3, "bulldog"); //access modifier object name = new class name()
            dog1.info(); //method call
            Console.WriteLine("Breed: " + dog1.breed); //print value






        }
        //method declaration. Basically method is a function. All function is called method in C# but all method is not function.Because method can return void value and function always return value. method always write outside the main method and inside the program class.
        public static int Age(int CurrenYear, int BirthYear) //access modifier static data type method name (parameter1 data type parameter1 name, parameter2 data type parameter2 name)
        {
            return CurrenYear - BirthYear; //return value

        }
    }
}
