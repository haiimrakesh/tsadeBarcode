using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tsade.Barcode.RazorWeb.Model;

namespace Tsade.Barcode.RazorWeb.Pages
{
    public class BarcodePrintLayoutModel : PageModel
    {
        [BindProperty]
        public BarcodeRequest? BarcodeRequest { get; set; }

        public IActionResult OnGetPrint(BarcodeRequest barcodeRequest)
        {
            // Initialization code if needed
            BarcodeRequest = barcodeRequest;
            return Page();
        }
    }
}