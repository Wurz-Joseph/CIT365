﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDesk.Data;
using MegaDesk.Models;

namespace MegaDesk
{
    public class CreateModel : PageModel
    {
        private readonly MegaDesk.Data.MegaDeskContext _context;

        public CreateModel(MegaDesk.Data.MegaDeskContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Deskquote Deskquote { get; set; }
        

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Deskquote.Area = Deskquote.CalculateArea();
            Deskquote.AreaCost = Deskquote.CalculateAreaCost();

            Deskquote.Material = Request.Form["material"];
            Deskquote.MaterialCost = Deskquote.CalculateMaterialCost(Deskquote.Material);

            Deskquote.DrawerCost = Deskquote.Drawers * Deskquote.COST_PER_DRAWER;
            Deskquote.Rush = Request.Form["rush"];
            Deskquote.ShippingCost = Deskquote.CalculateShippingCost(Deskquote.Rush, Deskquote.Area);
            Deskquote.Quote = Deskquote.CalculateQuoteTotal();


            _context.Deskquote.Add(Deskquote);
            await _context.SaveChangesAsync();
            
            return RedirectToPage("./Index");
        }

        

    }
}
