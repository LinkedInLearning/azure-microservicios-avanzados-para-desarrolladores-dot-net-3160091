using System;
using WisdomPetMedicine.Common;

namespace WisdomPetMedicine.Hospital.Domain.Events
{
    public record PatientWeightUpdated (Guid Id, decimal Value) : IDomainEvent { }
}