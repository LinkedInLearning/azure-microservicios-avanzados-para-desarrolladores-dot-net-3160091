using System;
using WisdomPetMedicine.Common;

namespace WisdomPetMedicine.Hospital.Domain.Events
{
    public record PatientAdmitted (Guid Id) : IDomainEvent { }
}