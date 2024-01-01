namespace Creating_Classes
{
    internal class Program
    {
        static void Main(string[] args) // Main Method - Entry point of the program
        {
            //creating objects (instances) of classes and calling methods on them

            /*  A class serves as a blueprint for creating objects.
                It defines a set of properties (data attributes) and methods (functions) specific to the objects of the class. */

            // Creating an instance of the 'Car' class and invoking the 'Car()' constructor
            //The naming convention for an object is camelCase
            Car audi = new Car("audi 992", 450, "Red"); /* Created an object named 'audi' of type 'Car',
                                   * and initialized it with a new car instance.
                                   * The 'new' keyword allocates memory on the heap for the new object,
                                   * invokes the constructor to initialize the object, and returns a reference to it.
                                   * This reference, stored in 'audi', points to the newly created object.
                                   */
            //we create another object, but when we pree r, we wouldn't know which car is reversing
            //so we need to create a private field that would hold a name of the car
            //so that when we press r, we would know which car we are reversing
            Car toyota = new Car("Toyota 1150", 900);
            //accessing the Drive() method
            audi.Drive();
            toyota.Drive();
            audi.Stop();

            //get car details
            audi.Cardetails();
            toyota.Cardetails();

            Console.WriteLine("\nPress \"R\" to reverse the car");
            string getKey = Console.ReadLine();
            if (getKey.ToLower() == "r")
            {
                toyota.Reverse();
            }
            else
            {
                Console.WriteLine("Car not reversing yet");
            }
        }
    }
}
