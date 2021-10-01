using System;

namespace WisdomPetMedicine.Rescue.Api.Commands
{
    public record RejectAdoptionCommand (Guid PetId, Guid AdopterId);
}