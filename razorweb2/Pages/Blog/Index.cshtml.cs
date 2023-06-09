﻿using System;
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

        public const int ITEMS_PER_PAGE = 10;
        [BindProperty(SupportsGet =true, Name = "p")]
        public int currentPage { get; set; }
        public int countPages{get; set; }


        public async Task OnGetAsync(string SearchString)
        {
            // if (_context.articles != null)
            // {
            //     Article = await _context.articles.ToListAsync();
            // }
            // Sort Categories by DateTime
            
            int totalArticle = await _context.articles.CountAsync();
            countPages = (int)Math.Ceiling((double)totalArticle / ITEMS_PER_PAGE);

            if(currentPage <1){
                currentPage =1;
            }else if(currentPage > countPages){
                currentPage = countPages;
            }

            var qr = (from a in _context.articles
                    orderby a.Created descending
                    select a)
                    .Skip((currentPage -1) *ITEMS_PER_PAGE)
                    .Take(ITEMS_PER_PAGE);

           if(!string.IsNullOrEmpty(SearchString)){
            Article = qr.Where(a => a.Title.Contains(SearchString)).ToList();
           }
           else{
            
            Article = await qr.ToListAsync();
           }
        }
    }
}
