namespace ShallowCopyOfEmployee
{
   public class Address
    {
        public Address(string address)
        {
            this.Adress = address;
        }
        public string Adress { get; set; }

        public Address GetClone()
        {
            return (Address) this.MemberwiseClone(); // NB!
        }
    }
}
