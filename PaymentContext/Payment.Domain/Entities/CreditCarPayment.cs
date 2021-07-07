using System;
using Payment.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class CreditCarPayment : Payment
    {
        public CreditCarPayment(string cardHorderName,
        string cardNumber,
        string lastTransactionNumber,
        string number,
        DateTime paidDate,
        DateTime expireDate,
        decimal total,
        decimal totalPaid,
        string payer,
        Document document,
        Address address,
        Email email) : base(paidDate,
         expireDate,
         total,
         totalPaid,
         payer,
         document,
         address,
         email)
        {
            CardHorderName = cardHorderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

    public string CardHorderName { get; private set; }
    public string CardNumber { get; private set; }
    public string LastTransactionNumber { get; private set; }
}
}