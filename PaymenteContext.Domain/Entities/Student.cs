
using System.Collections.Generic;
using System.Linq;
using PaymenteContext.Domain.ValueObjects;
using PaymenteContext.Shared.Entities;

namespace PaymenteContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscription;
        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;           
            _subscription = new List<Subscription>();

            AddNotifications(name, document, email);
        }

        public Name Name { get; set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions => _subscription.ToArray();


        public void AddSubscription(Subscription subscription)
        {
            var hasSubscriptionActive = false;
            foreach (var sub in _subscriptions)
            {
                if (sub.Active)
                    hasSubscriptionActive = true;
            }

            AddNotifications(new Contract()
                .Requires()
                .IsFalse(hasSubscriptionActive, "Student.Subscriptions", "Você já tem uma assinatura ativa")
                .AreNotEquals(0, subscription.Payments.Count, "Student.Subscription.Payments", "Esta assinatura não possui pagamentos")
            );



        }
}