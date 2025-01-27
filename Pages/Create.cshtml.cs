using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChickenSoup.Pages
{
    public class CreateModel : PageModel
    {
        // The context is used to interact with the database (ApplicationDbContext)
        private readonly ApplicationDbContext context;

        // Constructor
        public CreateModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        // Holds the data for the new entry, bound to the form fields
        [BindProperty]
        public Entry Entry { get; set; }

        // Handles the POST request
        public IActionResult OnPost()
        {
            // If the model state is not valid, 
            // return the page so the user can correct the input
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Set CreatedAt to now if not provided
            if (Entry.CreatedAt == DateTime.MinValue)
            {
                Entry.CreatedAt = DateTime.Now;
            }

            context.Entries.Add(Entry);
            context.SaveChanges();

            return RedirectToPage("./Entries"); // Redirect to the list of entries page
        }
    }
}
