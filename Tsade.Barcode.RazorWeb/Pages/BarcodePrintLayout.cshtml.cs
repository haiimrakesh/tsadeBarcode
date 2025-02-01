using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tsade.Barcode.RazorWeb.Model;

namespace Tsade.Barcode.RazorWeb.Pages
{
    public class BarcodePrintLayoutModel : PageModel
    {
        [BindProperty]
        public BarcodeResponse? BarcodeResponse { get; set; }

        public IActionResult OnGetPrint(BarcodeResponse barcodeResponse)
        {
            // Initialization code if needed
            BarcodeResponse = barcodeResponse;
            return Page();
        }
    }
}