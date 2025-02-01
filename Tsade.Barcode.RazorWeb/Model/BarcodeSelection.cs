using System;

namespace Tsade.Barcode.RazorWeb.Model
{
    /// <summary>
    /// Represents a barcode selection with text and image URL.
    /// </summary>
    public class BarcodeSelection
    {
        /// <summary>
        /// Gets or sets the text of the barcode.
        /// </summary>
        public string BarcodeText { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the URL of the barcode image.
        /// </summary>
        public string ImageUrl { get; set; } = string.Empty;
    }
}