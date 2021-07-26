using System;

namespace Memento.Memento
{
   public class LEDTV
    {
        public LEDTV(string Size, string Price, bool USBSupport)
        {
            this.Size = Size;
            this.Price = Price;
            this.USBSupport = USBSupport;
        }

        public string Size { get; set; }
        public string Price { get; set; }
        public bool USBSupport { get; set; }

        public string GetDetails()
        {
            return "LEDTV [Size=" + Size + ", Price=" + Price + ", USBSupport=" + USBSupport + "]";
        }
    }
}
