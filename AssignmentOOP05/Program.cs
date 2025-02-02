using System.Data;
using AssignmentOOP05.Q1;
using AssignmentOOP05.Q2;
using AssignmentOOP05.Q3;

namespace AssignmentOOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q1

            //Circle circleRef = new Circle();
            //circleRef.Radius = 5;
            //circleRef.DispalyShapeInfo();

            //Console.WriteLine("***************************\n");

            //Rectangle rectangleRef = new Rectangle();
            //rectangleRef.Length = 6;
            //rectangleRef.Width = 5;
            //rectangleRef.DispalyShapeInfo();

            #endregion


            #region Q2

            //bool Isauthor;
            //bool IsspecifiedRole;
            //BasicAuthenticationService[] users = new BasicAuthenticationService[]
            // {
            //  new BasicAuthenticationService()  {UserName = "Hussien", Password = 12345, Role = "Admin" },
            //  new BasicAuthenticationService()  {   UserName = "Ibrahiem", Password = 24565, Role = "moderator" },
            //  new BasicAuthenticationService() { UserName = "Hazem", Password = 98765, Role = "supervisor" }
            // };


            #region Part01

            //author = users[0].AuthenticateUser("Hussien", 12345);
            //Console.WriteLine(author);

            //author = users[1].AuthenticateUser("Hazem", 24565);
            //Console.WriteLine(author);

            #endregion

            #region Part02

            //specifiedRole = users[0].AuthorizeUse("ahmed", "admin");
            //Console.WriteLine(specifiedRole);

            //specifiedRole = users[2].AuthorizeUse("Hazem", "supervisor");
            //Console.WriteLine(specifiedRole);

            //specifiedRole = users[2].AuthorizeUse( null , "supervisor");
            //Console.WriteLine(specifiedRole);

            #endregion

            #region Part03

            //bool IsauthorInterface;
            //bool IsauthorizeInterface;
            //IAuthenticationService authService = new BasicAuthenticationService("Hussien",12345,"moderator");

            //IsauthorInterface= authService.AuthenticateUser("Hussien",12345);
            //Console.WriteLine(IsauthorInterface);


            //IsauthorizeInterface = authService.AuthorizeUse("Hussien", "admin");
            //Console.WriteLine(IsauthorizeInterface);

            #endregion


            #endregion

            #region Q3

            //EmailNotificationService emailRef = new EmailNotificationService();
            //emailRef.SendNotification("Hussien","Check your last E-mail again");

            //Console.WriteLine("******************\n");

            //SmsNotificationService smsRef = new SmsNotificationService();
            //smsRef.SendNotification("Hussien", "Call me back later");


            //Console.WriteLine("******************\n");

            //PushNotificationService pushNotRef = new PushNotificationService();
            //pushNotRef.SendNotification("Hussien", "Guten Morgen");

        
            #endregion

        }
    }
}
