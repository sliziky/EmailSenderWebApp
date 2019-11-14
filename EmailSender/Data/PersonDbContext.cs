using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailSender.Data
{
    public class PersonDbContext : DbContext {
        public PersonDbContext( DbContextOptions<PersonDbContext> options )
            : base( options ) {
        }
        public DbSet<EmailSender.Models.Person> Person { get; set; }
    }
}
