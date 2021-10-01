using System;

namespace WisdomPetMedicine.Pet.Api.Commands
{
    public record SetBreedCommand (Guid Id, string Breed);
}