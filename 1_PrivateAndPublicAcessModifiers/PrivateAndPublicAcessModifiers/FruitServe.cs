using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Access_Setters_Getters_Properties
{
    internal class FruitServe
    {
        //by default, use private access modifier for member variable and
        //public access modifiers for member methods

        //Private Member variables or fields - an only be accessed within this class
        //By default, ensure you make your member variables or fields private
        private string _name;
        private string _color;
        private float _weight;

        public FruitServe()
        {
            _name = "Orange";
            _color = "red";
            _weight = 2;
        }
        public FruitServe(string name, string color, float weight)
        {
            _name = name;
            _color = color;
            _weight = weight;

            //to access the chooped private method, we call cit here
            //whenever an object is created, call the choped method
            Chopped(); //once an object (fruit) is created, it's automatically being chopped.
                       //whether private or public, the method can also be called withing its class 
        }
        //Read Only or Write Only Properties
        //Sometimes we may want to restrict a property to either read or write only.
        //Read Only - has only a get accessor - meaning you an read but cannot change
        //Write Only - has only a set accessor - meaning you can change but cannot read.

        public string ReadName
        {
            get { return _name; }
        }
        public string WriteColor
        {
            set { _color = value; }
        }

        //Using an auto implemented property
        //this can be called with the prop vs code snippet
        //i.e - public int MyProperty { get; set; }

        //Properties - A faster way to create the get and set variables
        //a Public property
        //the get and set are special methods called accessors
        //They help provide controlled access to data in a private field
        //They prevent change of data in unacceptable ways
        public string Name{
            get { return _name; } //the get accessor
            //set { _name = value; }//the set accessor

            set
            {
                if(value == "")
                {
                    _name = "NoName";

                }
                else
                {
                    _name = value;
                }
            }
        }

        //creating a setters method - a setter is a code block that allows one assign a value to a private field
        //It controls how values are assigned to the property
        //the convention of naming is to write set followed by the varriable name

        //this method can be called in other classes to change the name of the fruit
        //public void SetName(string itsName)
        //{
        //    //we can do more with setters like adding conditions i.e
        //    if (itsName == "")
        //    {
        //        _name = "NoName";
        //    }
        //    else
        //    {
        //        _name = itsName;
        //    }
        //}

        ////The get method (property getter)
        ////Getters - get a varriable. same principle as setters. The order is first set and then get
        //public string GetName()
        //{
        //    //we can do more with setters like adding conditions i.e

        //    //You cannot use void for getter because a getter always returns something.

        //    // return _name; //return just name

        //    //adding my own rules to the getters
        //    return _name.ToUpper(); //return name in uppercase

        //}


        public void Sliced()
        {
            Console.WriteLine("The fruit {0}  with the colour {1} and a weight of {2}kg was served sliced", _name, _color, _weight);
        }

        //this is a private method which cant be accessed elsewhree except in this class
        //Common approach is to make methods public.
        //Except in situations you dont want other classes to use a ertain method.
        //E.G if the method is there to onlymake changes internally and has no business being accessed by a user.
        private void Chopped()
        {
            Console.WriteLine("The fruit {0}  with the colour {1} and a weight of {2}kg was served chopped", _name, _color, _weight);
        }

        public void Juiced()
        {
            Console.WriteLine("The fruit {0}  with the colour {1} and a weight of {2}kg was served juiced", _name, _color, _weight);
        }
    }
}
