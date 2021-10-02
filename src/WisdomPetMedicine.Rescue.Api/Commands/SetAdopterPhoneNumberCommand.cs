using System;

namespace WisdomPetMedicine.Rescue.Api.Commands
{
    public record SetAdopterPhoneNumberCommand(Guid Id, string PhoneNumber);
}