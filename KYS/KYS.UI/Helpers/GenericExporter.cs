using OfficeOpenXml;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;

public static class GenericExporter
{
    // Excel'e Aktarma
    public static void ExportToExcel(IEnumerable<object> data, string filePath)
    {
        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("Data");

            // İlk satır için başlıkları al (Verilerin ilk elemanından alınır)
            var properties = data.First().GetType().GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                worksheet.Cells[1, i + 1].Value = properties[i].Name;
            }

            // Verileri yaz
            int rowIndex = 2;
            foreach (var item in data)
            {
                for (int j = 0; j < properties.Length; j++)
                {
                    worksheet.Cells[rowIndex, j + 1].Value = properties[j].GetValue(item);
                }
                rowIndex++;
            }

            // Dosyayı kaydet
            File.WriteAllBytes(filePath, package.GetAsByteArray());
        }
    }
}
