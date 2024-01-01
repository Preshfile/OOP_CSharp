using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members_Finalizers_Destructors
{
    internal class Member
    {
        //member - Private fields
        private string _memberName;
        private int _memberId;
        private int _memberSalary;
        private int _age;

        //member - public fields
        public string companyName;
        public string careerPosition;
        

        //member - property - exposes _memberName and _memberId safely
        //Properties start with a capital letter

        public string MemberName
        {
            get { return _memberName; }
            set { _memberName = value; }
        }
        public int MemberId {

            get { return _memberId; } //Read only
        }
        public int MemberSalary
        {
            set { _memberSalary = value; } //write only
        }

        public int MemberAge
        {
            set { _age = value; } //write only
        }


        //member - constructor
        public Member()
        {
            _memberName = "Ekene";
            _memberId = 2345;
            _memberSalary = 20000;
            _age = 30;
            companyName = "Ibinabo Tech Solutions";
            careerPosition = "Senior Software ENgineer";

        }
        public Member( string memberName, string memberPosition, string ourCompany)
        {
            _memberName = memberName;
            careerPosition = memberPosition;
            companyName = ourCompany;
        }

        //Public memeber method - which could be called from other classes
        //Methods within a class are called members
        public void IntroductionToAFriend(bool isAFriend)
        {
            if (isAFriend)
            {
                ShareSensitiveInfo(); //one way to access a private method is by calling it inside a public method
            }
            else
            {
                Console.WriteLine("Hi! My name is {0}.\nI am a {1} at {2}. ", _memberName, careerPosition, companyName);
            }
        }

        private void ShareSensitiveInfo()
        {
            Console.WriteLine("Hi! My name is {0}.\nI am a {1} year old {2}.\nI work at {3} " +
                                "with an ID of {4}.\nMy average take home salary is {5}",
                                    _memberName, _age, careerPosition, companyName, _memberId, _memberSalary);
        }
        
        //member - finalizer or Destructor
        //a class can only have one finalizer
        //Finalizer or destructor is created with a tilde (~)
        //it cannot be inherited or overloaded
        //it cannot be called
        //it is called or executed only within its class whenever an object is closed, deleted or runs out of scope
        // Don't create or use empty finilizers - it will unnecessarily add to the queue
        ~Member()
        {
            //cleanup statements
            Console.WriteLine("Deconstructing member objects");
        }
    }
}
