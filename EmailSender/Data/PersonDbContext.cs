using Microsoft.EntityFrameworkCore;

namespace EmailSender.Data
{
    public class PersonDbContext : DbContext {
        public PersonDbContext( DbContextOptions<PersonDbContext> options )
            : base( options ) {
        }
        public DbSet<EmailSender.Models.Person> Person { get; set; }
    }
}
