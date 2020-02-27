using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk.Data;
using MegaDesk.Models;

namespace MegaDesk
{
    public class IndexModel : PageModel
    {
        private readonly MegaDesk.Data.MegaDeskContext _context;

        public IndexModel(MegaDesk.Data.MegaDeskContext context)
        {
            _context = context;
        }
        public IList<Deskquote> Deskquote { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public string NameSort { get; set; }
        public string DateSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            //search
            var Quote = from m in _context.Deskquote
                        select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                Quote = Quote.Where(s => s.CustomerName.Contains(SearchString));
            }

            //sort
            NameSort = String.IsNullOrEmpty(sortOrder) ? "CustomerName_desc" : "";
            DateSort = sortOrder == "Date" ? "Date_desc" : "Date";


            switch (sortOrder)
            {
                case "CustomerName_desc":
                    Quote = Quote.OrderByDescending(s => s.CustomerName);
                    break;
                case "Date":
                    Quote = Quote.OrderBy(s => s.Date);
                    break;
                case "Date_desc":
                    Quote = Quote.OrderByDescending(s => s.Date);
                    break;
                default:
                    Quote = Quote.OrderBy(s => s.CustomerName);
                    break;
            }


            Deskquote = await Quote.ToListAsync();

        }
    }
}
