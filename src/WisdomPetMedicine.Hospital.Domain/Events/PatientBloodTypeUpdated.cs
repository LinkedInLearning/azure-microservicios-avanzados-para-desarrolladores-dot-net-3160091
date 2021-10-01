using System;
using WisdomPetMedicine.Common;

namespace WisdomPetMedicine.Hospital.Domain.Events
{
    public record PatientBloodTypeUpdated (Guid Id, string BloodType) : IDomainEvent { }
}