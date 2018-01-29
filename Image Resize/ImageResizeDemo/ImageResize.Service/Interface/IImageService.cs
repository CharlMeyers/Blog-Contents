using System;

namespace ImageResize.Service
{
    public interface IImageService
    {
        byte[] GetImageByName(string imageName, int imageHeight, int imageWidth);
        byte[] GetProfilePicture(Guid userId, int imageHeight, int imageWidth);
        byte[] GetImage(Guid userId);
    }
}
