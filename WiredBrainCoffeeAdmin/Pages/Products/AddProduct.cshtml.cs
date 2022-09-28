using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffeeAdmin.Data;

namespace WiredBrainCoffeeAdmin.Pages.Products
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
       public Product NewProdcut { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            // Save product to database
            var productName = NewProdcut.Name;
           
        }
    }
}
