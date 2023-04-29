using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorweb2.models;

namespace razorweb2.Pages.Blog
{
    public class IndexModel : PageModel
    {
        private readonly razorweb2.models.MyBlogContext _context;

        public IndexModel(razorweb2.models.MyBlogContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; } = default!;

        public async Task OnGetAsync()
        {
            // if (_context.articles != null)
            // {
            //     Article = await _context.articles.ToListAsync();
            // }
            // Sort Categories by DateTime
            var qr = from a in _context.articles
                    orderby a.Created descending
                    select a;

           Article = await qr.ToListAsync();
        }
    }
}
