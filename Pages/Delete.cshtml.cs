using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChickenSoup.Pages
{
    public class DeleteModel : PageModel
    {
        // The context is used to interact with the database (ApplicationDbContext)
        private readonly ApplicationDbContext context;

        // Constructor that injects the ApplicationDbContext into this page model
        public DeleteModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        // Holds the Entry object that is being deleted
        [BindProperty]
        public Entry Entry { get; set; }

        // Handles the GET request for displaying the delete confirmation page
        public IActionResult OnGet(int id)
        {
            // Attempt to find the entry by its ID in the database
            Entry = context.Entries.FirstOrDefault(e => e.Id == id);

            if (Entry == null)
            {
                return NotFound();
            }

            return Page();
        }

        // Handles the POST request for actually deleting the entry
        public IActionResult OnPost()
        {
            if (Entry == null)
            {
                return NotFound();
            }

            context.Entries.Remove(Entry);
            context.SaveChanges();

            return RedirectToPage("./Index"); 
        }
    }
}
