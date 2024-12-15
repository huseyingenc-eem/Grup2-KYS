using OfficeOpenXml;
using System.Reflection;

public static class GenericExporter
{
    // Excel'e Aktarma: Tüm Entity veya Data için
    public static void ExportToExcel<T>(IEnumerable<T> data, string filePath)
    {
        if (data == null || !data.Any())
            throw new ArgumentException("Veri boş veya null olamaz.", nameof(data));

        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add(typeof(T).Name + "_Data");

            // Başlıkları yaz
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            for (int i = 0; i < properties.Length; i++)
            {
                worksheet.Cells[1, i + 1].Value = properties[i].Name; // Property isimlerini al
            }

            // Verileri doldur
            int rowIndex = 2;
            foreach (var item in data)
            {
                for (int colIndex = 0; colIndex < properties.Length; colIndex++)
                {
                    var value = properties[colIndex].GetValue(item, null);
                    worksheet.Cells[rowIndex, colIndex + 1].Value = value?.ToString() ?? ""; // Null kontrolü
                }
                rowIndex++;
            }

            // Güzelleştirme
            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

            // Dosyayı kaydet
            File.WriteAllBytes(filePath, package.GetAsByteArray());
        }

    }
}
