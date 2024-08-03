using Xceed.Words.NET;
namespace repor_creator;
public class HtmlToWordConverter
{
    public void ConvertHtmlToWord(string html, string filePath)
    {
        using (var document = DocX.Create(filePath))
        {
            // Aqui você pode adicionar o HTML como texto simples, ou converter o HTML em elementos compatíveis com Word
            document.InsertParagraph(html);
            document.Save();

            
        }
    }
}
