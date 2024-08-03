using Xceed.Words.NET;

public class HtmlToWordConverter
{
    public void ConvertHtmlToWord(string html, string filePath)
    {
        using (var document = DocX.Create(filePath))
        {
            var paragraph = document.InsertParagraph();
            paragraph.Font("Arial");
            paragraph.FontSize(12);
            paragraph.SpacingAfter(10);
            paragraph.AppendLine(html); 
            document.Save();
        }
    }
}
