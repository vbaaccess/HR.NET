using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.UserInterface.Helpers
{
    public static class ResourcesHelper
    {
        //private static string _closeButtonFullPath = @"C:\Users\pawel\source\repos\vbaaccess\HR.NET\Resources\close_16.png";
        public const string CloseButtonName = "close_wb.png";
        public static string ResourcesFilePath
            = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "Resources");
    }
}
