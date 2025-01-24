namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1 Mcq

            #region Q1 What is the primary purpose of an interface in C#?
            //a) To provide a way to implement multiple inheritance
            #endregion

            #region Q2 Which of the following is NOT a valid access modifier for interface members in C#?
            //b) protected
            #endregion

            #region Q3 Can an interface contain fields in C#?
            //c) Only if they are static
            #endregion

            #region Q4 In C#, can an interface inherit from another interface?
            //b) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region Q5 Which keyword is used to implement an interface in a class in C#? 
            //d) implements
            #endregion

            #region Q6 Can an interface contain static methods in C#?  
            //a) Yes 
            #endregion

            #region Q7 In C#, can an interface have explicit access modifiers for its members
            //a) Yes, for all members
            /*لقيت علي stackoverflow: No access modifiers can be applied to interface members*/
            #endregion

            #region Q8 What is the purpose of an explicit interface implementation in C#?
            //b) To provide a clear separation between interface and class members 
            #endregion

            #region Q9 In C#, can an interface have a constructor?
            //b) No, interfaces cannot have constructor
            #endregion

            #region Q10 How can a C# class implement multiple interfaces?
            //c) By separating interface names with commas.
            #endregion

            #endregion

            #region P2 Q1
            //Rectangle rectangle = new Rectangle();
            //rectangle.Area = 50;
            //rectangle.DisplayShapeInfo();

            //Circle circle = new Circle();
            //circle.Area = 40;
            //circle.DisplayShapeInfo();
            #endregion

            #region P2_Q2--
            //BasicAuthenticationService Person1 = new BasicAuthenticationService() { UserName = "Ahmed", Password = "S13414", Role = "Manager" };
            //Console.WriteLine(authService.AuthenticateUser("Mahmoud", "13")); 
            //Console.WriteLine(authService.AuthorizeUser("Dev"));
            #endregion

            #region P2 Q3
            //EmailNotificationService service = new EmailNotificationService();
            //PushNotificationService pushNotificationService = new PushNotificationService();
            //SmsNotificationService smsNotificationService = new SmsNotificationService();
            //Notification.NotificationDisplay(service, "Ahmed", "Good");
            //Notification.NotificationDisplay(pushNotificationService, "lol", "fog");
            //Notification.NotificationDisplay(smsNotificationService,"Zamalek", "fog");
            #endregion
        }
    }

    #region P2_Q1 
    public interface IShape
    {
        public int Area { get; set; }
        void DisplayShapeInfo();
    }

    public interface ICircle : IShape
    {

    }

    public interface IRectangle : IShape
    {

    }

    public class Circle : ICircle
    {
        public int Area { get; set; }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Object is a Circle and Area = {Area}");
        }
    }

    public class Rectangle : IRectangle
    {
        public int Area { get; set; }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Object is a Rectangle and Area = {Area}");
        }
    }
    #endregion

    #region P2_Q2--
    public interface IAuthenticationService
    {
        bool AuthenticateUser(string userName, string password);
        bool AuthorizeUser(string role);
    }

    public class BasicAuthenticationService : IAuthenticationService
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public required string Role { get; set; }

        public bool AuthenticateUser(string userName, string password)
        {
            if (userName == this.UserName && password == this.Password)
                return true;
            else
                return false;

        }
        public bool AuthorizeUser(string role)
        {
            if (role == this.Role)
                return true;
            else
                return false;
        }
    }
    #endregion

    #region P2 Q3
    public interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }

    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"{message}, recipient is {recipient} as email");
        }
    }

    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"{message}, recipient is {recipient} as sms");
        }
    }

    public class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"{message}, recipient is {recipient} as push");
        }
    }

    public class Notification
    {
        public static void NotificationDisplay(INotificationService service, string message, string recip)
        {
            service.SendNotification(recip, message);
        }
    }
    #endregion
}
