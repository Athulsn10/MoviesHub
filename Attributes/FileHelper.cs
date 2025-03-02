using Microsoft.AspNetCore.Hosting;

namespace MoviesHub.Helpers
{
    public static class FileHelper
    {
        public static async Task<string> UploadFile(IFormFile file, IWebHostEnvironment webHostEnvironment)
        {
            string uniqueFileName = null;
            Console.WriteLine("uniqueFileName:", file != null);
            if (file != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Uploads");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}