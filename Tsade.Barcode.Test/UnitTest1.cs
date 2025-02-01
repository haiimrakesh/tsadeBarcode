using Tsade.Barcode.Web;
namespace Tsade.Barcode.Test;

public class GenerateBarcodeTest
{
    [Fact]
    public void Generate_ShouldGenerateAnPngImage()
    {
        Barcode.Web.Domain.IronBarCodeGenerator.Generate("Saree128","image.png");
    }
}