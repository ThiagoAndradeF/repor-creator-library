using System.IO;
using Xceed.Words.NET;

public class HtmlToWordConverter
{
    public byte[] ConvertHtmlToWord(string html)
    {
        using (var memoryStream = new MemoryStream())
        {
            using (var document = DocX.Create(memoryStream))
            {
                var paragraph = document.InsertParagraph();
                paragraph.Font("Arial");
                paragraph.FontSize(12);
                paragraph.SpacingAfter(10);
                paragraph.AppendLine(html); 
                document.Save();
                memoryStream.Position = 0;
                return memoryStream.ToArray();
            }
        }
    }
}
