using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MegaDesk.Data;
using MegaDesk.Models;

namespace MegaDesk
{
    public class EditModel : PageModel
    {
        private readonly MegaDesk.Data.MegaDeskContext _context;

        public EditModel(MegaDesk.Data.MegaDeskContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Deskquote Deskquote { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Deskquote = await _context.Deskquote.FirstOrDefaultAsync(m => m.ID == id);

            if (Deskquote == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Deskquote).State = EntityState.Modified;

            try
            {
                Deskquote.Area = Deskquote.CalculateArea();
                Deskquote.AreaCost = Deskquote.CalculateAreaCost();
                Deskquote.Material = Request.Form["material"];
                Deskquote.MaterialCost = Deskquote.CalculateMaterialCost(Deskquote.Material);
                Deskquote.DrawerCost = Deskquote.Drawers * Deskquote.COST_PER_DRAWER;
                Deskquote.Rush = Request.Form["rush"];
                Deskquote.ShippingCost = Deskquote.CalculateShippingCost(Deskquote.Rush, Deskquote.Area);
                Deskquote.Quote = Deskquote.CalculateQuoteTotal();
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeskquoteExists(Deskquote.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DeskquoteExists(Guid id)
        {
            return _context.Deskquote.Any(e => e.ID == id);
        }
    }
}
