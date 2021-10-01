using System;
using WisdomPetMedicine.Hospital.Domain.Entities;
using WisdomPetMedicine.Hospital.Domain.Exceptions;
using WisdomPetMedicine.Hospital.Domain.ValueObjects;
using Xunit;

namespace WisdomPetMedicine.Hospital.Domain.Tests
{
    public class PatientTest
    {
        [Fact]
        public void PatientCannotBeAdmittedWithoutBloodTypeSet()
        {
            var patient = new Patient(PatientId.Create(Guid.NewGuid()));
            Assert.Throws<InvalidPatientStateException>(() =>
            {
                patient.AdmitPatient();
            });
        }

        [Fact]
        public void PatientCanBeAdmittedWithBloodTypeAndWeightSet()
        {
            var patient = new Patient(PatientId.Create(Guid.NewGuid()));
            patient.SetBloodType(PatientBloodType.Create("DEA-1.1"));
            patient.SetWeight(PatientWeight.Create(24));
            patient.AdmitPatient();
        }
    }
}
