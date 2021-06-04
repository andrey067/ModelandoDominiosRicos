using Flunt.Validations;
using PaymenteContext.Shared.ValueObject;
using System.Diagnostics.Contracts;

namespace PaymenteContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string adress)
        {
            Adress = adress;

            AddNotifications(new Contract()
                .Requires()
                .IsEmail(Address, "Email.Address", "E-mail inv�lido")
            );
        }

        public string Adress { get; private set; }


    }


}