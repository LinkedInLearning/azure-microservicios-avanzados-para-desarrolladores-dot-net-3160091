using System;
using WisdomPetMedicine.Common;

namespace WisdomPetMedicine.Rescue.Api.IntegrationEvents
{
    public record PetFlaggedForAdoptionIntegrationEvent(Guid Id, string Name, string Breed, int Sex, string Color, DateTime DateOfBirth, string Species);
}



