using System.Xml.Linq;

namespace Access_Setters_Getters_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FruitServe dish1 = new FruitServe("Pawpaw", "yellow", 4);
            dish1.Sliced();
           // Console.WriteLine("My fruits name is: {0}",dish1.GetName());

            // FruitServe._name = "Orange";// Cant't access a private field outside ofits class
            // To access by - chnaging its protection from private to public
            //or by using a property

            /*So, why dont we make all member variables public?

              - Making member variables (fields) private 
                is a fundamental principle in OOP known as ENCAPSULATION
              - ENCAPSULATION is the practice of hiding the intal state of an object
                and allowing access and modifications through methods (like getters and setters)
             */

            /* Reasons we make member variable private
             * 
              - Data Integrity: By making member variables private, 
                we control how they are accessed and modified
                This allows us to enforce rules on how the data is set
                E.g we can perform validation in the setter method of a property
                to ensure the data is always in a valid state.

              - Abstraction - Encapsulation allows you to expose a simplified and well-defined interface to the outside world. 
                Users of a class don't need to know the implementation details; 
                they interact with the public methods and properties, abstracting away unnecessary complexities.

              - Reduce Complexities : to expose only the necessary details for user's interaction and 
                              hide the implementation details and other complexities.
                              All users should care about is what methods to call and how to use them.
             */

            //dish1.Chopped();//method is inaccessible since its private

            //Change the name of fruit
            //dish1.SetName("Pineaple");//now able to change the variable but not directly.
            dish1.Sliced();
            //Console.WriteLine("My fruits name is: {0}", dish1.GetName());

            //dish1.SetName("");
            dish1.Juiced();

            //Using the getters method to get name
            //Console.WriteLine("My fruits name is: {0} ", dish1.GetName());

            //usine properties
            dish1.Name = "";//using the setter property
            dish1.Juiced();
            Console.WriteLine("Fruits name is: {0}", dish1.Name);//Calling the getter property

            //dish1.ReadName = "melon"; Error because its read only
            Console.WriteLine(dish1.ReadName);
            dish1.Juiced();
            //Console.WriteLine(dish1.WriteColor);errror. it can't get but can only write
            dish1.WriteColor = "Orange";
            dish1.Sliced();


            /*Where to use readonly properties
             - immutable data i.e birth dates
             - Computed data - when the property value is computed from other data
               i.e when computing the area of a rectangle, you an make the result a read only property
             */

            //- Write only properties are less common than readonly properties

            /*Where to use Writeonly properties
             - Sensitive data
             - Event handling
             
             */
        }
    }
}