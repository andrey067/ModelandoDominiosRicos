using System;
using PaymenteContext.Domain.ValueObjects;

namespace PaymenteContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barcode,
        string boletoNumber,
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
            Barcode = barcode;
            BoletoNumber = boletoNumber;
        }

        public string Barcode { get; private set; }
        public string BoletoNumber { get; private set; }

    }
}