using System;

namespace WisdomPetMedicine.Hospital.Api.IntegrationEvents
{
    public record PetTransferredToHospitalIntegrationEvent(Guid Id, string Name, string Breed, int Sex, string Color, DateTime DateOfBirth, string Species);
}