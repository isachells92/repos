using System;

namespace bwer2
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Runtime.InteropServices.ComTypes;
            using System.Threading;

namespace Hamnen
    {
        public enum BoatType
        {
            RoddBoat,
            MotorBoat,
            SegelBoat,
            LastFartyg
        }

        class Boat
        {
            public string ID { get; set; }
            public int Weight { get; set; }
            public int MaxSpeed { get; set; }
            public double SlotSize { get; set; }
            public int DockingDays { get; set; }
            public BoatType Type { get; set; }


        }

        class Slot
        {
            public string ID { get; set; }
            public double SlotSize { get; set; }
        }



        class Hamn
        {
            public string Name { get; set; }
            public double Slots { get; set; }
            public List<Slot> SlotBlocks { get; set; }
        }

        class Program
        {
            static Hamn hamn = new Hamn();

            static List<Boat> boats = new List<Boat>();

            static List<Boat> boatsThatDidNotFit = new List<Boat>();

            static Random random = new Random();

            static int daysToSimulate = 365;

            static int boatsAday = 5;

            static double slotsTaken = 0;

            static void Main(string[] args)
            {
                hamn.Name = "Port";
                hamn.Slots = 64.0;
                hamn.SlotBlocks = new List<Slot>();

                for (int i = 0; i < daysToSimulate; i++)
                {
                    Console.WriteLine($"DAY {i}");

                    for (int b = 0; b < boatsAday; b++)
                    {

                        Boat newBoat = GetBoat((BoatType)random.Next(0, 4));

                        Console.WriteLine($"Boat {newBoat.ID} of type {newBoat.Type} has arrived");

                        if ((slotsTaken + newBoat.SlotSize) < hamn.Slots)
                        {
                            slotsTaken += newBoat.SlotSize;

                            boats.Add(newBoat);

                            hamn.SlotBlocks.Add(new Slot { ID = Guid.NewGuid().ToString(), SlotSize = newBoat.SlotSize });

                            Console.WriteLine($"Boat {newBoat.ID} of type {newBoat.Type} did fit");
                        }
                        else
                        {
                            Console.WriteLine($"Boat {newBoat.ID} of type {newBoat.Type} did NOT fit !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                            boatsThatDidNotFit.Add(newBoat);
                        }

                    }

                    foreach (var boat in boats.ToList())
                    {
                        --boat.DockingDays;

                        if (boat.DockingDays == 0)
                        {
                            Console.WriteLine($"Boat {boat.ID} of type {boat.Type} has to leave");
                            boats.Remove(boat);
                            slotsTaken -= boat.SlotSize;
                            hamn.SlotBlocks.Remove(new Slot { ID = Guid.NewGuid().ToString(), SlotSize = boat.SlotSize });
                        }

                        // Console.WriteLine($"ID: {boat.ID} Weight: {boat.Weight} MaxSpeed: {boat.MaxSpeed} Dockingays: {boat.DockingDays} SlotSize: {boat.SlotSize} Type: {boat.Type}");
                    }

                    Console.WriteLine($"Slots taken this day {slotsTaken}");
                }

                Console.WriteLine(boats.Count());
                Console.WriteLine(slotsTaken);

            }

            static Boat GetBoat(BoatType type)
            {

                Boat boat = new Boat();

                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                string prefix = "";

                switch (type)
                {
                    case BoatType.RoddBoat:
                        prefix = "R-";
                        boat.Weight = random.Next(100, 300);
                        boat.MaxSpeed = random.Next(1, 3);
                        boat.DockingDays = 1;
                        boat.SlotSize = 0.5;
                        break;
                    case BoatType.MotorBoat:
                        prefix = "M-";
                        boat.Weight = random.Next(200, 3000);
                        boat.MaxSpeed = random.Next(1, 60);
                        boat.DockingDays = 3;
                        boat.SlotSize = 1.0;
                        break;
                    case BoatType.SegelBoat:
                        prefix = "S-";
                        boat.Weight = random.Next(800, 6000);
                        boat.MaxSpeed = random.Next(1, 12);
                        boat.DockingDays = 4;
                        boat.SlotSize = 2.0;
                        break;
                    case BoatType.LastFartyg:
                        prefix = "L-";
                        boat.Weight = random.Next(3000, 20000);
                        boat.MaxSpeed = random.Next(1, 20);
                        boat.DockingDays = 6;
                        boat.SlotSize = 4.0;
                        break;
                    default:
                        prefix = "D-";
                        break;
                }

                var list = Enumerable.Repeat(0, 3).Select(x => chars[random.Next(chars.Length)]);

                string result = string.Join("", list);

                boat.ID = prefix + result;
                boat.Type = type;

                return boat;

            }


        }
    }

}
    }
}
