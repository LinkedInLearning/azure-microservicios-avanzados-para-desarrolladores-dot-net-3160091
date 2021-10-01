using System;
using WisdomPetMedicine.Common;

namespace WisdomPetMedicine.Hospital.Domain.Events
{
    public record PatientProcedureAdded (Guid PatientId, Guid Id, string ProcedureName) : IDomainEvent { }
}