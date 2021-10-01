using System;

namespace WisdomPetMedicine.Pet.Api.Commands
{
    public record SetNameCommand(Guid Id, string Name); 
}