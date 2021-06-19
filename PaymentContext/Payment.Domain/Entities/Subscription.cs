namespace PaymentContext.Domain.Entities
{

    public class Subscription
    {
        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime? ExpireDate { get; set; }

        public List<Payment> Payment { get; set; }
    }

}