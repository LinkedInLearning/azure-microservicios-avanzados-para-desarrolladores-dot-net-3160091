using System;
using WisdomPetMedicine.Common;

namespace WisdomPetMedicine.Hospital.Domain.Events
{
    public record PatientCreated (Guid Id) : IDomainEvent { }
}