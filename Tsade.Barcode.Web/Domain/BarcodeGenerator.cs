namespace Tsade.Barcode.Web.Domain;
using IronBarCode;

public static class IronBarCodeGenerator
{
    public static void Generate(string textToEncode, string filePath)
    {
        GeneratedBarcode barcode = BarcodeWriter.CreateBarcode(textToEncode, BarcodeEncoding.Code128);
        barcode.SaveAsPdf(filePath);
    }
}