using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using tournamaker.Areas.Identity.Data;
using tournamaker.Data;
using tournamaker.Models;



namespace tournamaker.Pages
{
    [Authorize]
    public class TournoiModel : PageModel
    {
        private readonly tournamaker.Data.tournamakerContext _context;

        public TournoiModel(tournamaker.Data.tournamakerContext context)
        {
            _context = context;
            
        }

        public IActionResult OnGet()
        {
            
            return Page();
        }
        
        
        [BindProperty]
        public Tournoi Tournoi { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }
            
            _context.Tournoi.Add(Tournoi);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
