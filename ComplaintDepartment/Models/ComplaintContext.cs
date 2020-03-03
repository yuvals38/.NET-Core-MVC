
using Microsoft.EntityFrameworkCore;

namespace ComplaintDepartment.Models
{
    public class ComplaintContext : DbContext
    {
        public ComplaintContext(DbContextOptions<ComplaintContext> options)
         : base(options)
         {
         }

         public DbSet<ComplaintDepartment.Models.Complaint> Complaint{get; set;}
    }
}