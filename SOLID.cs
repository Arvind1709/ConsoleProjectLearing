namespace ConsoleProjectLearing
{
    public class SOLID
    {
        /// <summary>
        /// A class should have only one reason to change.
        /// Analogy:
        ///Imagine a chef who also waits tables, cleans dishes, and manages the cash counter.If the chef gets busy cooking, who will take care of the customers or cleaning?
        ///Each role should be handled by a different person.
        ///</summary>   
        ///<summary>
        ///❌ Bad Example:
        ///</summary>
        public class Invoice
        {
            public void CalculateTotal() { /* Logic */ }
            public void PrintInvoice() { /* Print logic */ }
            public void SaveToDatabase() { /* DB logic */ }
        }
        ///<summary>
        ///✅ What's wrong? This class has multiple responsibilities: business logic, printing, and data access.
        ///</summary>

        ///<summary>
        ///✅ Good Example:
        ///</summary>
        public class InvoiceGoodExample
        {
            public void CalculateTotal() { /* Logic */ }
        }

        public class InvoicePrinter
        {
            public void PrintInvoice(Invoice invoice) { /* Print logic */ }
        }

        public class InvoiceRepository
        {
            public void SaveToDatabase(Invoice invoice) { /* DB logic */ }
        }

        ///<summary>
        ///👍 Why better? Each class handles one responsibility only.
        ///</summary>

        /// <summary>
        /// O – Open/Closed Principle (OCP)
        /// A class should be open for extension but closed for modification.
        /// 
        /// Analogy:
        /// Think of a smartphone that allows you to install new apps without changing the phone’s hardware.
        /// You extend its functionality without modifying it.
        /// </summary>

        /// <summary>
        /// ❌ Bad Example:
        /// </summary>
        public class PaymentProcessor
        {
            public void ProcessPayment(string type)
            {
                if (type == "CreditCard") { /* Credit card logic */ }
                else if (type == "PayPal") { /* PayPal logic */ }
            }
        }

        /// <summary>
        /// ✅ What's wrong? Every time a new payment type is added, you have to modify the class.
        /// </summary>

        /// <summary>
        /// ✅ Good Example:
        /// </summary>
        public abstract class Payment
        {
            public abstract void ProcessPayment();
        }

        public class CreditCardPayment : Payment
        {
            public override void ProcessPayment() { /* Credit Card Logic */ }
        }

        public class PayPalPayment : Payment
        {
            public override void ProcessPayment() { /* PayPal Logic */ }
        }

        public class PaymentHandler
        {
            public void HandlePayment(Payment payment)
            {
                payment.ProcessPayment();
            }
        }

        /// <summary>
        /// 👍 Why better? You can add new payment types without modifying existing code.
        /// </summary>

        /// <summary>
        /// L – Liskov Substitution Principle (LSP)
        /// Derived classes should be replaceable with their base classes without breaking behavior.
        /// 
        /// Analogy:
        /// If a square is a rectangle, you should be able to use a square wherever a rectangle is expected without surprises.
        /// </summary>

        /// <summary>
        /// ❌ Bad Example:
        /// </summary>
        public class Bird
        {
            public virtual void Fly() { /* Fly logic */ }
        }

        public class Sparrow : Bird { }

        public class Ostrich : Bird
        {
            public override void Fly()
            {
                throw new NotImplementedException("Ostrich can't fly");
            }
        }

        /// <summary>
        /// ✅ What's wrong? Ostrich violates LSP because it can't fly.
        /// </summary>

        /// <summary>
        /// ✅ Good Example:
        /// </summary>
        public abstract class BirdLSP
        {
            public abstract void Move();
        }

        public class FlyingBird : BirdLSP
        {
            public override void Move() => Console.WriteLine("Flying");
        }

        public class NonFlyingBird : BirdLSP
        {
            public override void Move() => Console.WriteLine("Walking");
        }

        public class SparrowLSP : FlyingBird { }
        public class OstrichLSP : NonFlyingBird { }

        /// <summary>
        /// 👍 Why better? Subclasses follow the behavior contract of their base classes.
        /// </summary>

        /// <summary>
        /// I – Interface Segregation Principle (ISP)
        /// Clients should not be forced to depend on interfaces they do not use.
        /// 
        /// Analogy:
        /// A coffee machine shouldn’t require you to connect a water pipe *and* an Ethernet cable just to make coffee.
        /// </summary>

        /// <summary>
        /// ❌ Bad Example:
        /// </summary>
        public interface IMachine
        {
            void Print();
            void Scan();
            void Fax();
        }

        public class SimplePrinter : IMachine
        {
            public void Print() { /* Print logic */ }
            public void Scan() { throw new NotImplementedException(); }
            public void Fax() { throw new NotImplementedException(); }
        }

        /// <summary>
        /// ✅ What's wrong? The class is forced to implement methods it doesn't support.
        /// </summary>

        /// <summary>
        /// ✅ Good Example:
        /// </summary>
        public interface IPrinter
        {
            void Print();
        }

        public interface IScanner
        {
            void Scan();
        }

        public class ModernPrinter : IPrinter, IScanner
        {
            public void Print() { /* Print logic */ }
            public void Scan() { /* Scan logic */ }
        }

        public class BasicPrinter : IPrinter
        {
            public void Print() { /* Print logic */ }
        }

        /// <summary>
        /// 👍 Why better? Classes implement only the interfaces they need.
        /// </summary>


        /// <summary>
        /// D – Dependency Inversion Principle (DIP)
        /// High-level modules should not depend on low-level modules. Both should depend on abstractions.
        /// 
        /// Analogy:
        /// When you charge your phone, you don’t care whether it’s plugged into a wall, a laptop, or a power bank.
        /// You only care that it has a USB port.
        /// </summary>

        /// <summary>
        /// ❌ Bad Example:
        /// </summary>
        public class EmailSender
        {
            public void Send(string message) { /* Email logic */ }
        }

        public class NotificationBad
        {
            private EmailSender _emailSender = new EmailSender();

            public void Notify(string message)
            {
                _emailSender.Send(message);
            }
        }

        /// <summary>
        /// ✅ What's wrong? High-level Notification class depends on the low-level EmailSender class.
        /// </summary>

        /// <summary>
        /// ✅ Good Example:
        /// </summary>
        public interface IMessageSender
        {
            void Send(string message);
        }

        public class EmailSenderDIP : IMessageSender
        {
            public void Send(string message) { /* Email logic */ }
        }

        public class Notification
        {
            private readonly IMessageSender _sender;

            public Notification(IMessageSender sender)
            {
                _sender = sender;
            }

            public void Notify(string message)
            {
                _sender.Send(message);
            }
        }

        /// <summary>
        /// 👍 Why better? High-level module depends on abstraction, allowing flexibility and easier testing.
        /// </summary>

    }
}
