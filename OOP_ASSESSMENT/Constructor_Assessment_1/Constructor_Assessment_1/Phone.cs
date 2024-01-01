using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assessment_1
{
    internal class Phone
    {
        
        public string company;
        public string model;
        public string releaseDay;

        //default constructor that sets all values to "unknown";
        public Phone()
        {
            company = "Unknown";
            model = "Unknown";
            releaseDay = "Unknown";
        }

        //constructor that takes 2 arguments (company and model) and sets them respectively.
        //The ReleaseDay should be set to "unknown";
        public Phone(string companyName, string modelName)
        {
            company = companyName;
            model = modelName;
            releaseDay= "Unknown";
        }

        //constructor with 3 arguments (company, model, and release day);
        public Phone(string companyName, string modelName, string releaseDate)
        {
            company = companyName;
            model = modelName;
            releaseDay = releaseDate;
        }
        public void PhoneDescription()
        {
            Console.WriteLine("Phone Model: {0}. Created by: {1}. Released date: {2}.", company, model, releaseDay);
        }
    

    }
}
