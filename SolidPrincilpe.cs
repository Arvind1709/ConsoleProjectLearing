namespace ConsoleProjectLearing
{
    internal class SolidPrincilpe
    {
        //A class should have only one reason to change.
    }
    /// <summary>
    /// S – Single Responsibility Principle (SRP)
    /// </summary>
    public class Invoice
    {
        //S – Single Responsibility Principle (SRP)
        //A class should have only one reason to change.
        //Invoice handles invoice logic, while InvoicePrinter takes care of printing.
        public void CalculateTotal() { /* Logic */ }
    }

    public class InvoicePrinter
    {
        //S – Single Responsibility Principle (SRP)
        //A class should have only one reason to change.
        //Invoice handles invoice logic, while InvoicePrinter takes care of printing.
        public void PrintInvoice(Invoice invoice) { /* Logic */ }
    }
    /// <summary>
    /// O – Open/Closed Principle(OCP)
    /// </summary>
    public abstract class Payment
    {
        //O – Open/Closed Principle(OCP)
        //A class should be open for extension but closed for modification
        //If a new payment method is needed, we just add another class without modifying existing ones.
        public abstract void ProcessPayment();
    }

    public class CreditCardPayment : Payment
    {

        //O – Open/Closed Principle(OCP)
        //A class should be open for extension but closed for modification
        //If a new payment method is needed, we just add another class without modifying existing ones.
        public override void ProcessPayment() { /* Credit Card Logic */ }
    }

    public class PayPalPayment : Payment
    {
        //O – Open/Closed Principle(OCP)
        //A class should be open for extension but closed for modification
        //If a new payment method is needed, we just add another class without modifying existing ones.
        public override void ProcessPayment() { /* PayPal Logic */ }
    }

    /// <summary>
    /// L – Liskov Substitution Principle(LSP)
    /// </summary>

    public abstract class Bird
    {
        //L – Liskov Substitution Principle(LSP)
        //Derived classes should be replaceable with their base classes without altering program behavior.
        public abstract void Move(); // Generic movement method
    }

    public class FlyingBird : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Flying");
        }
    }

    public class NonFlyingBird : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Walking or Swimming");
        }
    }

    public class Sparrow : FlyingBird { }   // ✅ A sparrow can fly.
    public class Penguin : NonFlyingBird { } // ✅ A penguin cannot fly but can move.

    /// <summary>
    /// I – Interface Segregation Principle (ISP)
    /// </summary>
    public interface IPrinter
    {
        //Interface Segregation Principle(ISP)
        //Clients should not be forced to depend on interfaces they do not use.
        //Printer doesn’t need to implement IScanner because it doesn’t scan.
        void Print();
    }

    public interface IScanner
    {
        //Interface Segregation Principle(ISP)
        //Clients should not be forced to depend on interfaces they do not use.
        //Printer doesn’t need to implement IScanner because it doesn’t scan.
        void Scan();
    }

    public class Printer : IPrinter
    {
        //Interface Segregation Principle(ISP)
        //Clients should not be forced to depend on interfaces they do not use.
        //Printer doesn’t need to implement IScanner because it doesn’t scan.
        public void Print() { /* Print Logic */ }
    }

    public class MultiFunctionPrinter : IPrinter, IScanner
    {
        //Interface Segregation Principle(ISP)
        //Clients should not be forced to depend on interfaces they do not use.
        //Printer doesn’t need to implement IScanner because it doesn’t scan.
        public void Print() { /* Print Logic */ }
        public void Scan() { /* Scan Logic */ }
    }

    /// <summary>
    /// D – Dependency Inversion Principle (DIP)
    /// </summary>
    public interface IMessageSender
    {
        //High-level modules should not depend on low-level modules.Both should depend on abstractions
        //Notification depends on IMessageSender, not a concrete implementation like EmailSender, making it flexible.
        void SendMessage(string message);
    }

    public class EmailSender : IMessageSender
    {
        //High-level modules should not depend on low-level modules.Both should depend on abstractions
        //Notification depends on IMessageSender, not a concrete implementation like EmailSender, making it flexible.
        public void SendMessage(string message) { /* Email Logic */ }
    }


    public class Notification
    {
        //High-level modules should not depend on low-level modules.Both should depend on abstractions
        //Notification depends on IMessageSender, not a concrete implementation like EmailSender, making it flexible.
        private readonly IMessageSender _messageSender;

        public Notification(IMessageSender messageSender)
        {
            //High-level modules should not depend on low-level modules.Both should depend on abstractions
            //Notification depends on IMessageSender, not a concrete implementation like EmailSender, making it flexible.
            _messageSender = messageSender;
        }

        public void Notify(string message)
        {
            //High-level modules should not depend on low-level modules.Both should depend on abstractions
            //Notification depends on IMessageSender, not a concrete implementation like EmailSender, making it flexible.
            _messageSender.SendMessage(message);
        }
    }



}
