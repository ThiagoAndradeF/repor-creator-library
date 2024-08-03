using DinkToPdf;
using DinkToPdf.Contracts;
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
                DocumentTitle = "Formal Document",
            },
            Objects = {
                new ObjectSettings() {
                    PagesCount = true,
                    HtmlContent = html,
                    WebSettings = { DefaultEncoding = "utf-8" },
                    HeaderSettings = { FontName = "Arial", FontSize = 12, Right = "Page [page] of [toPage]", Line = true },
                    FooterSettings = { FontName = "Arial", FontSize = 12, Line = true, Center = "Confidential" }
                }
            }
        };

        return _converter.Convert(doc);
    }
}
