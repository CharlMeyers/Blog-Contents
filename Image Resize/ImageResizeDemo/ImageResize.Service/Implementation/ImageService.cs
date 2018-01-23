using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ImageResize.Service
{
    public class ImageService : IImageService
    {
        public byte[] GetImageByName(string imageName, int imageHeight, int imageWidth)
        {
            byte[] imageBytes;
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Content\\Images\\" + imageName;

            using (Image image = Image.FromFile(filePath))
            {
                Size size = new Size(imageWidth, imageHeight);   
                Bitmap imageBitmap = new Bitmap(image, size);
                imageBytes = ConvertImageToByteArray(imageBitmap, image.RawFormat);
            }

            return imageBytes;
        }

        public string GetProfilePicture(Guid userId, int imageHeight, int imageWidth)
        {
            throw new NotImplementedException();
        }

        private string ConvertImageToBase64(Bitmap image)
        {
            string base64 = "";
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                byte[] imageBytes = ms.ToArray();

                base64 = Convert.ToBase64String(imageBytes);
            }

            return base64;
        }

        private byte[] ConvertImageToByteArray(Bitmap image, ImageFormat imageFormat)
        {
            byte[] imageBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, imageFormat);
                imageBytes = ms.ToArray();                
            }

            return imageBytes;
        }
    }
}
