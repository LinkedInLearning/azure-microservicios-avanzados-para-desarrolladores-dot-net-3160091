using System;

namespace WisdomPetMedicine.Hospital.Api.Commands
{
    public record SetWeightCommand (Guid Id, decimal Weight);
}