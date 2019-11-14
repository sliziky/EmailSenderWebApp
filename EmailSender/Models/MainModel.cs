using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailSender.Models
{
    public class MainModel : PageModel
    {

        [BindProperty]
        public List<int> AreChecked { get; set; }
        private readonly EmailSender.Data.PersonDbContext _context;
        public MainModel( EmailSender.Data.PersonDbContext context ) {
            _context = context;
        }

        public IList<Person> Person { get; set; }

        public async Task OnGetAsync() {
            Person = await _context.Person.ToListAsync();
        }
    }
}
