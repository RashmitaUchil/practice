using EmployeeAdminPortal.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Data
{
    public class AuthenticateDbContext : IdentityDbContext
    {
        public AuthenticateDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
