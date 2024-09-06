using System.Configuration;

namespace Nike_Shop_Management.Config
{
    class ServiceConfig
    {
        public static readonly string CloudinaryCloudName = ConfigurationManager.AppSettings["CloudinaryCloudName"];
        public static readonly string CloudinaryApiKey = ConfigurationManager.AppSettings["CloudinaryApiKey"];
        public static readonly string CloudinaryApiSecret = ConfigurationManager.AppSettings["CloudinaryApiSecret"];
    }
}
