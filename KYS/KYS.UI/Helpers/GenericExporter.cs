using OfficeOpenXml;
using System.Reflection;
using System.Windows.Forms;

public static class GenericExporter
{
    // Excel'e Aktarma: Dosya yolu kullanıcıdan alınacak
    public static void ExportToExcel<T>(IEnumerable<T> data)
    {
        if (data == null || !data.Any())
            throw new ArgumentException("Veri boş veya null olamaz.", nameof(data));

        // SaveFileDialog ile dosya yolunu kullanıcıdan al
        var saveFileDialog = new SaveFileDialog
        {
            Title = "Excel Dosyası Kaydet",
            Filter = "Excel Files|*.xlsx",
            FileName = $"{typeof(T).Name}_Data.xlsx"
        };

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = saveFileDialog.FileName;

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

            MessageBox.Show("Veriler başarıyla Excel'e aktarıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
