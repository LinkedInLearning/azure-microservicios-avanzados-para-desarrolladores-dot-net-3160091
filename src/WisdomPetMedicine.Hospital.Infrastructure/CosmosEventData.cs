using System;

namespace WisdomPetMedicine.Hospital.Infrastructure
{
    public record CosmosEventData (Guid Id, string AggregateId, string EventName, string Data, string AssemblyQualifiedName);
}