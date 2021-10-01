using System;

namespace WisdomPetMedicine.Rescue.Api.Commands
{
    public record ApproveAdoptionCommand (Guid PetId, Guid AdopterId);
}