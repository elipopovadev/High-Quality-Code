using FacadeHomework.Construction;
using System;

namespace FacadeHomework.CreatingFacade
{
   public class House
    {
        private HouseArea houseArea = new HouseArea();
        private FloorSlab floorSlab = new FloorSlab();
        private Roof roof = new Roof();
        private Door door = new Door();
        private Window window = new Window();

        public House(int doorsNumber, int windowsNumber)
        {
            this.HouseArea = houseArea;
            this.FloorSlab = floorSlab;
            this.Roof = roof;
            this.DoorsNumber = doorsNumber;
            this.WindowsNumber = windowsNumber;
        }

        public HouseArea HouseArea { get; private set; }

        public FloorSlab FloorSlab { get; private set; }

        public Roof Roof { get; private set; }

        public int DoorsNumber { get; private set; }

        public int WindowsNumber { get; private set; }

        public decimal CalculatePrice()
        {
            decimal sum = 0;
            sum += HouseArea.Price;
            sum += FloorSlab.Price;
            sum += Roof.Price;
            sum += DoorsNumber * door.Price;
            sum += WindowsNumber * window.Price;
            return sum;
        }

        public void MakePayment()
        {
            Console.WriteLine("Payment is succesful!");
        }
    }
}
