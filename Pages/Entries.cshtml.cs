using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChickenSoup.Pages
{
    public class Entries : PageModel
    {
        private readonly ApplicationDbContext context;

        public List<Entry> EntryList { get; set; } = new List<Entry>();
        public string CategorySearch { get; set; } = string.Empty; // To hold the search query

        public Entries(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void OnGet(string categorySearch)
        {
            // Store the search term in the CategorySearch property
            CategorySearch = categorySearch ?? string.Empty;

            // If there is a search term, filter the entries by category
            if (!string.IsNullOrEmpty(CategorySearch))
            {
                EntryList = context.Entries
                    .Where(entry => entry.Category.Contains(CategorySearch)) // Filter by category
                    .ToList();
            }
            else
            {
                // If no search term is provided, show all entries
                EntryList = context.Entries.ToList();
            }
        }

        // Handler to delete an entry
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var entry = await context.Entries.FindAsync(id);
            if (entry != null)
            {
                context.Entries.Remove(entry);
                await context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
        
    }
}