using Microsoft.EntityFrameworkCore;

namespace WisdomPetMedicine.Hospital.Api.Infrastructure
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options) { }
    }
}