using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    enum FuelType
    {
        benzin=1,
        neft
    }
    class Bus
    {
        public int NumOfSeats { get; set; }
        public string FuelType { get; set; }
        public string Company { get; set; }
        public int Id { get; set; }
        public int NumOfRavKav { get; set; }
        public int NumOfBell { get; set; }
        public bool Screen { get; set; }

        public Bus()
        {

        }

        public Bus(int numOfSeats, string fuelType, string company, int id, int numOfRavKav, int numOfBell, bool screen)
        {
            NumOfSeats = numOfSeats;
            FuelType = fuelType;
            Company = company;
            Id = id;
            NumOfRavKav = numOfRavKav;
            NumOfBell = numOfBell;
            Screen = screen;
        }

        public Bus(Bus b)
        {
            NumOfSeats = b.NumOfSeats;
            FuelType = b.FuelType;
            Company = b.Company;
            Id = b.Id;
            NumOfRavKav = b.NumOfRavKav;
            NumOfBell = b.NumOfBell;
            Screen = b.Screen;
        }

        public void Print()
        {
            Console.WriteLine(" NumOfSeats: "+NumOfSeats);
            Console.WriteLine(" FuelType: "+ FuelType);
            Console.WriteLine(" Company: "+ Company);
            Console.WriteLine(" Id: "+ Id);
            Console.WriteLine(" NumOfRavKav: "+ NumOfRavKav);
            Console.WriteLine(" NumOfBell: "+NumOfBell);
            Console.WriteLine(" Screen: "+ Screen);

        }

        public void GetDetails()
        {
            Console.WriteLine("Enter NumOfSeats");
            NumOfSeats=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter FuelType");
            FuelType = Console.ReadLine();
            Console.WriteLine("Enter Company");
            Company = Console.ReadLine();
            Console.WriteLine("Enter Id");
            Id =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter NumOfRavKav");
            NumOfRavKav = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter NumOfBell");
            NumOfBell = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Screen");
            Screen = bool.Parse(Console.ReadLine());


        }
    }
}
