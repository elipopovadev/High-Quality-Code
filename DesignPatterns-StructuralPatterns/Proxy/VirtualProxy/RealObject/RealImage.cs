using System;

namespace VirtualProxy.RealObject
{
    public class RealImage : IImage
    {
        private string FileName;
        public RealImage(string fileName)
        {
            this.FileName = fileName;
            this.LoadImageFromDisk();
        }
        
        public void DisplayImage()
        {
            Console.WriteLine("Displaying Image : " + FileName);
        }

        public void LoadImageFromDisk()
        {
            Console.WriteLine("Loading Image : " + FileName);
        }

    }
}
