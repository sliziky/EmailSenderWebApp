using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmailSender.Models
{
    public class MainModel : PageModel
    {
        private readonly Data.PersonDbContext _context;
        public MainModel( Data.PersonDbContext context ) {
            _context = context;
        }

        /// <summary>
        /// Represents a table of Persons
        /// </summary>
        public IList< Person > Person { get; set; }

        public async Task OnGetAsync() {
            Person = await _context.Person.ToListAsync();
        }
    }
}
