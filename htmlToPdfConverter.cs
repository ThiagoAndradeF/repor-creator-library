
using DinkToPdf;
using DinkToPdf.Contracts;
namespace repor_creator;
public class HtmlToPdfConverter
{
    private IConverter _converter;

    public HtmlToPdfConverter()
    {
        _converter = new SynchronizedConverter(new PdfTools());
    }

    public byte[] ConvertHtmlToPdf(string html)
    {
        var doc = new HtmlToPdfDocument()
        {
            GlobalSettings = {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
            },
            Objects = {
                new ObjectSettings() {
                    PagesCount = true,
                    HtmlContent = html,
                    WebSettings = { DefaultEncoding = "utf-8" }
                }
            }
        };

        return _converter.Convert(doc);
    }
}
