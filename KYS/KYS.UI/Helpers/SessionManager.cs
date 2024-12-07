using KYS.Entities.Models;

namespace KYS.UI.Helpers
{
    public static class SessionManager
    {
        public static User? CurrentUser { get; set; }
    }
}