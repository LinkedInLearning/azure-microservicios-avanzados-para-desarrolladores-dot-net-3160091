using System;

namespace WisdomPetMedicine.Pet.Api.Commands
{
    public record CreatePetCommand (Guid Id, string Name, string Breed, int Sex, string Color, DateTime DateOfBirth, string Species);
}