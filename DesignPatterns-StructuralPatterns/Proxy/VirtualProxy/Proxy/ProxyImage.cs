using VirtualProxy.RealObject;

namespace VirtualProxy.Proxy
{
    public class ProxyImage : IImage
    {
        private RealImage realImage = null;
        private string Filename { get;}

        public ProxyImage(string fileName)
        {
            this.Filename = fileName;
        }
        public void DisplayImage()
        {
            if (realImage == null)
            {
                realImage = new RealImage(Filename);
            }

            realImage.DisplayImage();
        }
    }
}
