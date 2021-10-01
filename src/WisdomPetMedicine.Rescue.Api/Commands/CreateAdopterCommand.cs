using System;

namespace WisdomPetMedicine.Rescue.Api.Commands
{
    public record CreateAdopterCommand (Guid Id, string Name, Questionnaire Questionnaire, Address Address);
    public record Questionnaire (bool IsActivePerson, bool DoYouRent, bool HasFencedYard, bool HasChildren);
    public record Address (string Street, string Number, string City, string PostalCode, string Country);
}