﻿using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace EmailSender.Pages
{
    public class IndexModel : PageModel
    {
 
        private readonly ILogger< IndexModel > _logger;

        public IndexModel( ILogger< IndexModel > logger ) {
            _logger = logger;
        }
    }
}
