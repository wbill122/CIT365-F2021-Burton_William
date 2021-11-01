﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        
        public SelectList Book { get; set; } 
        public SelectList Date { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ScriptureBook { get; set; }
        public string BookSort { get; set; }
        public string DateSort { get; set; }


        public async Task OnGetAsync(string sortOrder)
        {
           // using System 
            BookSort = String.IsNullOrEmpty(sortOrder) ? "book_desc" : "";
            BookSort = sortOrder == "Book" ? "book_desc" : "Book";
            DateSort = String.IsNullOrEmpty(sortOrder) ? "Date" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            IQueryable<Scripture> scriptureQuery = from s in _context.Scripture
                                                   select s;

            IQueryable<string> bookQuery = from m in _context.Scripture
                                           orderby m.Book
                                           select m.Book;
            

            var scriptures = from m in _context.Scripture
                             select m;

           

            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Notes.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(ScriptureBook))
            {
                scriptures = scriptures.Where(x => x.Book == ScriptureBook);
            }

                       
            switch (sortOrder)
            {
                case "book_desc":
                    scriptures = scriptures.OrderBy(s => s.Book);
                    break;
                case "Book":
                    scriptures = scriptures.OrderBy(s => s.Book);
                    break;
                case "Date":
                    scriptures = scriptures.OrderBy(s => Convert.ToDateTime(s.Date));
                    break;
                case "date_desc":
                    scriptures = scriptures.OrderBy(s => Convert.ToDateTime(s.Date));
                    break;
                default:
                    scriptures = scriptures.OrderBy(s => s.ID);
                    break;
            }

            Book = new SelectList(await bookQuery.Distinct().ToListAsync());//Book
           
            Scripture = await scriptures.ToListAsync();
        }
    }
   
}
