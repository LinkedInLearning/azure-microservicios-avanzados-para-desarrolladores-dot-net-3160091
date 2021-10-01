using System;

namespace WisdomPetMedicine.Pet.Api.Commands
{
    public record SetColorCommand (Guid Id, string Color);
}