using System;

namespace WisdomPetMedicine.Rescue.Domain.Events
{
    public record AdoptionRequestCreated(Guid RescuedAnimalId, Guid AdopterId);
}