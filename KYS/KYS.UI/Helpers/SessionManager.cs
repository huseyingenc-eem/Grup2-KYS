using KYS.Entities.Models;
using System.Text.Json;

namespace KYS.UI.Helpers
{
    public static class SessionManager
    {
        private static readonly string SessionFilePath = "session.json";
        public static User? CurrentUser { get; set; }

        // Oturumu kaydet
        public static void SaveSession()
        {
            if (CurrentUser != null)
            {
                var json = JsonSerializer.Serialize(CurrentUser);
                File.WriteAllText(SessionFilePath, json);
            }
        }

        // Oturumu yükle
        public static void LoadSession()
        {
            if (File.Exists(SessionFilePath))
            {
                try
                {
                    var json = File.ReadAllText(SessionFilePath);
                    CurrentUser = JsonSerializer.Deserialize<User>(json);
                }
                catch (Exception ex)
                {
                    CurrentUser = null; // Bir hata olursa oturum yüklenemez
                    MessageBox.Show($"Session yüklenirken bir hata oluştu: {ex.Message}");
                }
            }
        }

        // Oturumu temizle (Çıkış yap)
        public static void ClearSession()
        {
            if (File.Exists(SessionFilePath))
            {
                File.Delete(SessionFilePath);
            }
            CurrentUser = null;
        }



    }
}