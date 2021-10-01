using Microsoft.EntityFrameworkCore;
using WisdomPetMedicine.Hospital.Api.IntegrationEvents;

namespace WisdomPetMedicine.Hospital.Api.Infrastructure
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options) { }
        public DbSet<PetTransferredToHospitalIntegrationEvent> PatientsMetadata { get; set; }
    }
}