namespace Tsade.Barcode.RazorWeb.Model
{    
    public class BarcodeResponse : BarcodeRequest
    {
        public BarcodeResponse()
        {
        }
        public BarcodeResponse(BarcodeRequest request, byte[] image)
        {
            BarcodeText = request.BarcodeText;
            CompanyName = request.CompanyName;
            ProductName = request.ProductName;
            Price = request.Price;
            Image = image;
        }
        public byte[] Image { get; set; }
    }
}