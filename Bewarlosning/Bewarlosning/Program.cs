using System;
using System.Collections.Generic;
using System.Linq;

namespace Bewarlosning
{
    class Program
    {
        static void Main(string[] args)
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
            public double Size { get; set; }
            public bool IsTaken { get; set; }
        }



        class Hamn
        {
            public string Name { get; set; }
            public List<Slot> Slots { get; set; }
        }

        class Program1
        {
            static Hamn hamn = new Hamn();
            static List<Boat> boats = new List<Boat>();

            static List<Boat> boatsThatDidNotFit = new List<Boat>();

            static Random random = new Random();

            static int daysToSimulate = 30;

            static int boatsAday = 5;

            static int hamnSize = 64;

            static void Main(string[] args)
            {
                SetUpHamn("Port");

                for (int i = 0; i < daysToSimulate; i++)
                {
                    for (int b = 0; b < boatsAday; b++)
                    {

                        Boat newBoat = GetBoat((BoatType)random.Next(0, 4));

                        double sA = SlotsAvailable();

                        if ((sA + newBoat.SlotSize) < hamnSize)
                        {

                            boats.Add(newBoat);


                        }
                        else
                        {
                            boatsThatDidNotFit.Add(newBoat);
                        }

                    }

                    foreach (var boat in boats.ToList())
                    {
                        --boat.DockingDays;

                        if (boat.DockingDays == 0)
                        {
                            boats.Remove(boat);

                        }

                        // Console.WriteLine($"ID: {boat.ID} Weight: {boat.Weight} MaxSpeed: {boat.MaxSpeed} Dockingays: {boat.DockingDays} SlotSize: {boat.SlotSize} Type: {boat.Type}");
                    }

                }

                Console.WriteLine(boats.Count());

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


            static void SetUpHamn(string name)
            {
                hamn.Name = name;

                for (int i = 0; i < hamnSize; i++)
                {
                    hamn.Slots.Add(new Slot { ID = Guid.NewGuid().ToString(), Size = 1.0, IsTaken = false });
                }
            }


            static double SlotsAvailable()
            {
                double aS = 0.0;

                foreach (var slot in hamn.Slots)
                {
                    if (!slot.IsTaken)
                    {
                        aS += slot.Size;
                    }
                }

                return aS;
            }
        }
    }
}
