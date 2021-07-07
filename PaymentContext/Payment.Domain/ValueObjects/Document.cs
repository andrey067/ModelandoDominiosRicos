using Payment.Domain.Entities.Enum;

namespace Payment.Domain.ValueObjects
{
    public class Document
    {
        public int Number { get; set; }
        public EDocumenttype Type { get; private set; }
        public Document(int number,EDocumenttype type)
        {
            Number = number;
            Type = type;
        }


    }
}