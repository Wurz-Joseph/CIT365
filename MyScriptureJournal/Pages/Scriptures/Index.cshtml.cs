using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public string BookSort { get; set; }
        public string DateSort { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CurrentFilter { get; set; }
        public SelectList BooksFilter { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedBook { get; set; }
        public IList<Scripture> Scriptures { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            BookSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            CurrentFilter = searchString;

            IQueryable<Scripture> scriptureIQ = from s in _context.Scripture
                                             select s;

            IQueryable<string> BooksQuery = from s in _context.Scripture
                                                select s.Book;


            if (!String.IsNullOrEmpty(searchString))
            {
                scriptureIQ = scriptureIQ.Where(s => s.Note.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(SelectedBook))
            {
                scriptureIQ = scriptureIQ.Where(s => s.Book == SelectedBook);
            }

            switch (sortOrder)
            {
                case "name_desc":
                    scriptureIQ = scriptureIQ.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    scriptureIQ = scriptureIQ.OrderBy(s => s.DateCreated);
                    break;
                case "date_desc":
                    scriptureIQ = scriptureIQ.OrderByDescending(s => s.DateCreated);
                    break;
                default:
                    scriptureIQ = scriptureIQ.OrderBy(s => s.Book);
                    break;
            }
            var scriptures = from s in _context.Scripture
                         select s;

           
            BooksFilter = new SelectList(await BooksQuery.Distinct().ToListAsync());
            Scriptures = await scriptureIQ.AsNoTracking().ToListAsync();
            
        }

    }
}
