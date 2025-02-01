using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tsade.Barcode.RazorWeb.Model;

namespace Tsade.Barcode.RazorWeb.Pages
{
    public class BarcodeSelectionModel : PageModel
    {
        private IWebHostEnvironment _environment;
        public BarcodeSelectionModel(IWebHostEnvironment env)
        {
            this._environment = env;
        }
        [BindProperty]
        public List<BarcodeSelection> BarcodeSelections { get; set; } = new List<BarcodeSelection>();

        public IActionResult OnGet()
        {
            // Initialization code if needed
            BarcodeSelections = new List<BarcodeSelection>();
            var folderPath = String.Format("{0}{1}",_environment.WebRootPath, "\\images\\barcodes"); 
            if (Directory.Exists(folderPath))
            {
                var files = Directory.GetFiles(folderPath);
                foreach (var file in files)
                {
                    var filePath = string.Format("/images/barcodes/{0}", Path.GetFileName(file));
                    BarcodeSelections.Add(new BarcodeSelection { 
                        BarcodeText = Path.GetFileNameWithoutExtension(file),
                        ImageUrl = filePath});
                }
            }
            return Page();
        }
    }
}