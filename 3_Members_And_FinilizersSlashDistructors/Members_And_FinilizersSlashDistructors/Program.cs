namespace Members_Finalizers_Destructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member1 = new Member();
            member1.IntroductionToAFriend(true);

            Member member2 = new Member("Josh", "Engineer", "LockTech");
            member2.IntroductionToAFriend(false);
            member2.IntroductionToAFriend(true);

           // member1.ShareSensitiveInfo(); // - it's inaccessible

        }

        //the destructor message comes right here after the program closes
    }
}