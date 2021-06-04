using PaymenteContext.Domain.Enums;
using PaymenteContext.Shared.ValueObject;

namespace PaymenteContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentsType type)
        {
            Number = number;
            Type = type;

            AddNotifications(new Contract()
               .Requires()
               .IsTrue(Validate(), "Document.Number", "Documento inválido")
           );
        }

        public string Number { get; private set; }

        public EDocumentsType Type { get; private set; }


        private bool Validate()
        {
            if (Type == EDocumentType.CNPJ && Number.Length == 14)
                return true;

            if (Type == EDocumentType.CPF && Number.Length == 11)
                return true;

            return false;
        }

    }
}