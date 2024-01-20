using DibaHospital.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DibaHospital.Data
{
    public class DibaContext : IdentityDbContext
    {
        public DibaContext(DbContextOptions<DibaContext> options) : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
