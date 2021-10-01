using System;

namespace WisdomPetMedicine.Hospital.Api.Commands
{
    public record SetBloodTypeCommand (Guid Id, string BloodType);
}