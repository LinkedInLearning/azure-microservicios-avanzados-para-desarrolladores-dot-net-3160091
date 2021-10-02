using System;

namespace WisdomPetMedicine.Pet.Api.Commands
{
    public record SetDateOfBirthCommand (Guid Id, DateTime DateOfBirth);
}