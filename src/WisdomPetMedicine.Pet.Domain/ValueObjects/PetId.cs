using System;

namespace WisdomPetMedicine.Pet.Domain.ValueObjects
{
    public record PetId
    {
        public Guid Value { get; init; }
        internal PetId(Guid value)
        {
            Value = value;
        }

        public static PetId Create(Guid value)
        {
            //var newval = new Guid();
            //newval.
            Validate(value);
            return new PetId(value);
        }

        public static implicit operator Guid(PetId petId)
        {
            return petId.Value;
        }

        private static void Validate(Guid value)
        {
            if (value == Guid.Empty)
            {
                throw new ArgumentException("Id should not be empty", nameof(value));
            }
        }
    }
}