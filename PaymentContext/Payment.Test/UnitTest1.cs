using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace Payment.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var subscription = new Subscription(null);
            var student = new Student("Audrey", "Ernesto", "123124234231231", "hello@gmail.com");
            student.AddSubscription(subscription);

        }
    }
}
