using System;
using System.IO;

namespace NrcTaskWeb.HelperMethods
{
    public static class DirectoryMethods
    {
        public static string GetPdfFileLocation()
        {
            try
            {
                string folderDirectory = Path.Combine(Directory.GetCurrentDirectory(), "PDF Files");

                if (!Directory.Exists(folderDirectory))
                {
                    Directory.CreateDirectory(folderDirectory);
                }

                string filePath = Path.Combine(folderDirectory, "Collected Data.pdf");
                return filePath;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
