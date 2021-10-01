using System;
using WisdomPetMedicine.Common;

namespace WisdomPetMedicine.Pet.Domain.Events
{
    public record PetTransferredToHospital (Guid Id, string Name, string Breed, int Sex, string Color, DateTime DateOfBirth, string Species) : IDomainEvent { }
}