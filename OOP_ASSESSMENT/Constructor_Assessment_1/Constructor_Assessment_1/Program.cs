namespace Constructor_Assessment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Constructors
             
                Create 3 constructors for the class Phone:

                default constructor that sets all values to "unknown";

                constructor that takes 2 arguments (company and model) and sets them respectively. The ReleaseDay should be set to "unknown";

                constructor with 3 arguments (company, model, and release day);
             */

            Phone phone = new Phone("iphone 12", "Apple");

            phone.PhoneDescription();
        }
    }
}