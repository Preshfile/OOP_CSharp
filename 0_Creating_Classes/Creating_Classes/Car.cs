using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Classes
{
    //Creating classes with methods
    internal class Car//it is internal, meaning it can only be accessed within the same assembly
    {
        //Private field/member variable
        private string _name; //This is how you name a private field
                              //A private field used for storing data
        private int _hp;
        private string _color;

        // Constructor
        //Multipls Constructor
        //default constructor
        public Car()
        {
            _name = "Car";
            _hp = 0;
            _color = "red";
        }
        public Car(string carName, int carHp = 0, string color = "black" ) 
        {  //a default constructor. It is similar to a method that would be called later on
            _name = carName;
            _hp = carHp; //i set the every objetcs default horse power to 0. But can be altered when object is created
            _color = color;
            Console.WriteLine("\n{0} was created successfuly, with a horse power of {1} and a colour of {2}.\n", carName, carHp, color);
        }
        //the constructor is a special method that is automatically called when an object is created
        

        //Member methods of the class Car - only available to objects of the type or class Car
        //All methods created in this class can be used or shared by the instances (objects) of this class
        //Adding a Drive() method

        public void Drive()
        {
            Console.WriteLine("{0} is driving with a horse power of {1} and a colour of {2}.", _name, _hp, _color);
        }

        //Adding a Stop() method
        public void Stop() 
        {
            Console.WriteLine("{0} has stopped.", _name);
        }

        //Adding a Reverse() method
        public void Reverse()
        {
            Console.WriteLine("{0} starts reversing, with a horse power of {1} " +
                "               and a colour of {2}.", _name, _hp, _color);
        }

        //Adding CarDetails method
        public void Cardetails()
        {
            Console.WriteLine("\nCar details = \nCar Name:{0}  \nCar horse power:{1}." +
                "               \nCar Colour:{2}", _name, _hp, _color);
        }
    }
}
