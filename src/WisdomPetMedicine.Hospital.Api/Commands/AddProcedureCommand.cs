using System;

namespace WisdomPetMedicine.Hospital.Api.Commands
{
    public record AddProcedureCommand(Guid Id, string Procedure);
}