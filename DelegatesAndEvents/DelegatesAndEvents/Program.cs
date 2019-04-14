using System;

namespace DelegatesAndEvents
{
    #region Using delegates#
    //class Program
    //{
    //    static void Main()
    //    {
    //        var registerUser = new RegisterUser();
    //        var emailVerification = new EmailVerification();
    //        var smsVerification = new SMSVerification();

    //        registerUser.registerUserDelegateInstance += emailVerification.OnUserRegistered;
    //        registerUser.registerUserDelegateInstance += smsVerification.OnUserRegistered;
    //        registerUser.RegisterAUser();// Call delegate

    //        Console.ReadLine();
    //    }

    //}
    //public class RegisterUser
    //{
    //    public delegate void registerUserDelegate(); // declare a delegate
    //    public registerUserDelegate registerUserDelegateInstance; // create a delegate instance

    //    public void RegisterAUser()
    //    {
    //        Console.WriteLine("User registered");
    //        if (registerUserDelegateInstance != null)
    //        {
    //            registerUserDelegateInstance();// Call the delegate
    //        }
    //    }

    //}
    //public class EmailVerification
    //{

    //    public void OnUserRegistered()
    //    {
    //        Console.WriteLine("Sent Email for Verification");
    //    }
    //}

    //public class SMSVerification
    //{

    //    public void OnUserRegistered()
    //    {
    //        Console.WriteLine("Sent SMS for Verification");
    //    }
    //}

    #endregion

    #region Using events#

    // class Program
    // {

    //     static void Main()
    //     {
    //         var registerUser = new RegisterUser();
    //         var emailVerification = new EmailVerification();
    //         var smsVerification = new SMSVerification();

    //         registerUser.registerUserEvent += emailVerification.OnUserRegistered; //subscribe to an event
    //         registerUser.registerUserEvent += smsVerification.OnUserRegistered; //subscribe to an event
    //         registerUser.RegisterAUser(); // publisher


    //         Console.ReadLine();
    //     }

    // }


    // public class RegisterUser
    // {
    //     public delegate void registerUserEventHandler(object source, EventArgs Args); //define a delegate
    //     public event registerUserEventHandler registerUserEvent; // define an event

    //     public void RegisterAUser()
    //     {
    //         Console.WriteLine("User registered");
    //         if (registerUserEvent != null)
    //         {
    //             registerUserEvent(this, EventArgs.Empty);// call event
    //         }
    //     }

    //}
    // public class EmailVerification
    // {

    //     public void OnUserRegistered(object source, EventArgs e)
    //     {
    //         Console.WriteLine("Sent Email for Verification");
    //     }
    // }

    // public class SMSVerification
    // {

    //     public void OnUserRegistered(object source, EventArgs e)
    //     {
    //         Console.WriteLine("Sent SMS for Verification");
    //     }
    // }


    #endregion

    #region Using EventHandlers #

    class Program
    {

        static void Main()
        {
            var registerUser = new RegisterUser();
            var emailVerification = new EmailVerification();
            var smsVerification = new SMSVerification();

            registerUser.registerUserEvent += emailVerification.OnUserRegistered; //subscribe to an event
            registerUser.registerUserEvent += smsVerification.OnUserRegistered; //subscribe to an event
            registerUser.RegisterAUser(); // publisher


            Console.ReadLine();
        }

    }


    public class RegisterUser
    {
        public event EventHandler registerUserEvent;
        public void RegisterAUser()
        {
            Console.WriteLine("User registered");
            if (registerUserEvent != null)
            {
                registerUserEvent(this, EventArgs.Empty);// call event
            }
        }

    }
    public class EmailVerification
    {

        public void OnUserRegistered(object source, EventArgs e)
        {
            Console.WriteLine("Sent Email for Verification");
        }
    }

    public class SMSVerification
    {

        public void OnUserRegistered(object source, EventArgs e)
        {
            Console.WriteLine("Sent SMS for Verification");
        }
    }

    #endregion#
}