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

        public byte[] GetImage(Guid userId)
        {
            byte[] imageBytes;
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Content\\Images\\" + userId.ToString() + ".jpg";

            using (Image image = Image.FromFile(filePath))
            {                
                imageBytes = ConvertImageToByteArray(image, image.RawFormat);
            }

            return imageBytes;
        }

        public string GetProfilePicture(Guid userId, int imageHeight, int imageWidth)
        {
            string imageBytes;
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Content\\Images\\" + userId.ToString() + ".jpg";

            using (Image image = Image.FromFile(filePath))
            {
                Size size = new Size(imageWidth, imageHeight);
                Bitmap imageBitmap = new Bitmap(image, size);
                imageBytes = ConvertImageToBase64(imageBitmap, image.RawFormat);
            }

            return imageBytes;
        }

        private string ConvertImageToBase64(Image image, ImageFormat imageFormat)
        {
            string base64 = "";
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, imageFormat);
                byte[] imageBytes = ms.ToArray();

                base64 = Convert.ToBase64String(imageBytes);
            }

            return base64;
        }

        private byte[] ConvertImageToByteArray(Image image, ImageFormat imageFormat)
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
