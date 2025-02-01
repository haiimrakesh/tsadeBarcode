namespace Tsade.Barcode.RazorWeb.Model
{
    /// <summary>
    /// Represents a request to generate a barcode.
    /// </summary>
    public class BarcodeRequest
    {
        /// <summary>
        /// Gets or sets the text to be encoded in the barcode.
        /// </summary>
        public string BarcodeText { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        public string CompanyName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        public string ProductName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        public decimal Price { get; set; } = 0;
    }
}