using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace ChickenSoup.Pages
{
    public class VisualEntriesModel : PageModel
    {
        // The context is used to interact with the database (ApplicationDbContext)
        private readonly ApplicationDbContext context;

        // Constructor
        public VisualEntriesModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        // List of entries with images
        public List<Entry> EntryList { get; set; }

        // Bind properties for file upload
        [BindProperty]
        public string ImageCaption { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

        // Method to display the images on page load
        public void OnGet()
        {
            // Retrieve only entries that have images
            EntryList = context.Entries.Where(e => !string.IsNullOrEmpty(e.ImagePath)).ToList();

            // Add fallback caption if none exists
            foreach (var entry in EntryList)
            {
                if (string.IsNullOrEmpty(entry.ImageCaption))
                {
                    entry.ImageCaption = "No caption available"; // Default caption
                }
            }
        }

        // Method to handle the image upload and saving to the database
        public async Task<IActionResult> OnPostAsync()
        {
            // Check if Image is null or empty 
            if (Image == null || Image.Length == 0)
            {
                ModelState.AddModelError("Image", "Please upload an image.");
                return Page();
            }

            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
            var fileExtension = Path.GetExtension(Image.FileName).ToLower();

            // Check for valid types
            if (!allowedExtensions.Contains(fileExtension))
            {
                ModelState.AddModelError("Image", "Invalid file type. Only JPG, PNG, and GIF files are allowed.");
                return Page();
            }

            // Check if caption is empty
            if (string.IsNullOrWhiteSpace(ImageCaption))
            {
                ModelState.AddModelError("ImageCaption", "Caption cannot be empty.");
                return Page();
            }

            // Store the image in the wwwroot/images folder
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", Image.FileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await Image.CopyToAsync(stream); // Asynchronously save the file
            }

            // Create a new Entry with the uploaded image
            var entry = new Entry
            {
                Name = "Visual Entry",  
                Category = "Image",  
                Description = "A visual entry",  
                ImagePath = "/images/" + Image.FileName,  
                ImageCaption = ImageCaption,  
                CreatedAt = DateTime.Now  
            };

            // Add the new entry to the database
            context.Entries.Add(entry);
            await context.SaveChangesAsync();

            return RedirectToPage("./VisualEntries");
        }
    }
}
