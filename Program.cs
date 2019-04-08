using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_Classes
{
    class Program
    {
        static void Main(string[] args)
        //after defining another class outside of Program class, go back Program class  to reuse them in a program
        //define method inside of Program Class that will be used inside the Program,but OUTSIDE of a Method named Main
        {
            Console.WriteLine("Some change");
            Car myCar = new Car(); //step 2 
            //using the class called "Car" as blueprint/pattern/recipe to reuse the properties 
            myCar.Make = "Honda"; //accessing those varibles/properties in the Car class with Make Method 
            myCar.Model = "Civic";
            myCar.Year = 2016; //when you define Year as int at a class level , you don't need to conver it from string to int here
            myCar.Color = "Silver";

            Console.WriteLine("{0} {1} {2} {3} ", myCar.Make, myCar.Model, myCar.Year, myCar.Color); //step 3 
            //we access the values by using: the name of the object. the name of the property 
            // Car with "Capital" describe the class . we want to use the instance/copy of the blueprint "myCar" to print 

            decimal value = DetermineMarketValue(myCar);
            //step 5: using method called DetermineMarketValue to print out the value of the car 
            // Console.WriteLine("{0:C}", value); example without" method with if statment"

            Console.WriteLine("{0:C}", myCar.DetermineMarketValue()); //another option to print a method
            //print the method with if statment , so if the car is make 1986, it would only worth 2000 dollars
            //if it's make 2016 , it would be worth 20,000
            Console.ReadLine();
        }

        private static decimal DetermineMarketValue(Car car) //don't put ; near method ?

        // step 4: method called DetermineMarketValue
        // and allow Car as input parameter . Car as a type and car as a variable 

        {
            decimal carValue = 100.0m;
            return carValue;
            //if this was a real app, you might look up the var online webserive to get more accurant value

        }






    } 

        
     // a class is a type . note class in library might not have tangiable real world equilavent that represent real things in company 
    //object orinted analysis and design = create classes and methods
   
      class Car //step 1
    {    //definding another class outside of the program to reuse the class later inside the program
        public string Make { get; set; }      // to define a class, define their properties as following:
        public string Model { get; set; }    //public . type. property ( getting the value, and setting the property) 
        public int Year { get; set; }     //must have a public/private, type, and property(method). 
        public string Color { get; set; }

        public decimal DetermineMarketValue () // defineing method. public to reuse them in another method 
        {
            decimal carValue;

            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;
            return carValue;
        }



    }







}



