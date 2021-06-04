using System;
using PaymenteContext.Domain.ValueObjects;

namespace PaymenteContext.Domain.Entities
{
    public class PaypalPayment : Payment
    {
        public PaypalPayment(string transactionCode,
        string number, 
        DateTime paidDate, 
        DateTime expireDate, 
        decimal total, 
        decimal totalPaid, 
        string payer, 
        Document document, 
        Address address, 
        Email email) : base(number, 
        paidDate, 
        expireDate, 
        total, 
        totalPaid, 
        payer, 
        document, 
        address, 
        email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
    }
}