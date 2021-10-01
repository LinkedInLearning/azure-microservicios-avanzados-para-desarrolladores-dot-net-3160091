using System;
using WisdomPetMedicine.Common;

namespace WisdomPetMedicine.Hospital.Domain.Events
{
    public record PatientDischarged (Guid Id) : IDomainEvent { }
}