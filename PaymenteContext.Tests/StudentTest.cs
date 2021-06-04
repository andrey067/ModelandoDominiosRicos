using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymenteContext.Domain.Entities;
using PaymenteContext.Domain.ValueObjects;

namespace PaymenteContext.Tests
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            var name = new Name("Teste", "Teste");
            foreach (var not in name.Notifications)
            {
                not.Message;
            }
        }


    }
}