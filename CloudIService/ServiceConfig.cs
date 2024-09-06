using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.CloudIService
{
    class ServiceConfig
    {
        public static readonly string CloudinaryCloudName = ConfigurationManager.AppSettings["CloudinaryCloudName"];
        public static readonly string CloudinaryApiKey = ConfigurationManager.AppSettings["CloudinaryApiKey"];
        public static readonly string CloudinaryApiSecret = ConfigurationManager.AppSettings["CloudinaryApiSecret"];
    }
}
