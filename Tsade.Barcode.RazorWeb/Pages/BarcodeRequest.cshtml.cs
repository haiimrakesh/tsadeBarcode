using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tsade.Barcode.RazorWeb.Model;
using Tsade.Barcode.Web.Domain;

namespace Tsade.Barcode.RazorWeb.Pages
{
    public class BarcodeRequestModel : PageModel
    {
        [BindProperty]
        public BarcodeRequest? BarcodeRequest { get; set; }

        public IActionResult OnGet()
        {
            // Initialization code if needed
            BarcodeRequest = new BarcodeRequest();
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Process the BarcodeData here
            // For example, generate a barcode image or save the data to a database
            //IronBarCodeGenerator.Generate(BarcodeRequest.BarcodeText, "../wwwroot/images/barcode.png");

            return RedirectToPage("BarcodePrintLayout", "Print", new BarcodeResponse(BarcodeRequest, null)); // Redirect to a success page or another page
        }
    }
}