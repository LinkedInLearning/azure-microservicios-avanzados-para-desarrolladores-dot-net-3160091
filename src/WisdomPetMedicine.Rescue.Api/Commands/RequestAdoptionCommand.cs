using System;

namespace WisdomPetMedicine.Rescue.Api.Commands
{
    public record RequestAdoptionCommand (Guid PetId, Guid AdopterId);
}