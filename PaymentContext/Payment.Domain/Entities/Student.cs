namespace PaymentContext.Domain.Entities
{

    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public List<Subscription> Subscriptions { get; set; }
        public bool Active { get; set; }
    }
}