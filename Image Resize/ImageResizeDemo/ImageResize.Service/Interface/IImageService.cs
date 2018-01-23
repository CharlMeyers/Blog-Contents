using System;

namespace ImageResize.Service
{
    public interface IImageService
    {
        byte[] GetImageByName(string imageName, int imageHeight, int imageWidth);
        string GetProfilePicture(Guid userId, int imageHeight, int imageWidth);
    }
}
