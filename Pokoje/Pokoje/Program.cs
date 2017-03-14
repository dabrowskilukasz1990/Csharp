using System;
using System.Collections.Generic;

namespace Pokoje
{
    class Room
    {
        public int number;
        public List<Room> Connected = new List<Room>();

        public Room(int number)
        {
            this.number = number;
        }

        public void SetConnectedRooms(List<Room> AllRooms)
        {
            Console.WriteLine("Podaj ilość połączeń dla pokoju numer {0}:", number);
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Podaj numer połączonego pokoju numer #{0}: ", i + 1);
                int n = int.Parse(Console.ReadLine());
                foreach (Room R in AllRooms)
                {
                    if (R.number == n)
                        Connected.Add(R);
                }
            }
        }

        public void ShowRoom()
        {
            Console.Write(number + " - ");
            foreach (Room R in Connected)
            {
                Console.Write(R.number + ", ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void SetConnectedRoomsRandom(List<Room> AllRooms)
        {
            List<Room> UnusedRooms = new List<Room>();
            foreach (Room R in AllRooms)
            {
                UnusedRooms.Add(R);
            }
            Random rnd = new Random();
            for (int i = 0; i < AllRooms.Count - 1; i++)
            {
                foreach (Room R in UnusedRooms)
                {
                    if (R.number == i + 1)
                    {
                        UnusedRooms.Remove(R);
                        break;
                    }
                }
                int count = rnd.Next(1, 4);
                for (int j = 0; j < count; j++)
                {
                    int room = rnd.Next(0, (UnusedRooms.Count > 0) ? UnusedRooms.Count : AllRooms.Count);
                    AllRooms[i].Connected.Add((UnusedRooms.Count > 0) ? UnusedRooms[room] : AllRooms[room]);
                    if (UnusedRooms.Count > 0)
                        UnusedRooms.Remove(UnusedRooms[room]);
                }
                UnusedRooms.Add(AllRooms[i]);
            }
        }

        static void SetRooms(List<Room> Rooms)
        {
            Console.WriteLine("Podaj ilość pokoi: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Rooms.Add(new Room(i + 1));
            }
        }

        static void ShowRooms(List<Room> Rooms)
        {
            foreach (Room R in Rooms)
            {
                R.ShowRoom();
            }
        }

        static void Main(string[] args)
        {
            List<Room> Rooms = new List<Room>();
            SetRooms(Rooms);
            foreach (Room R in Rooms)
            {
                R.SetConnectedRooms(Rooms);
            }
            //SetConnectedRoomsRandom(Rooms);
            Console.Clear();
            ShowRooms(Rooms);
            Console.ReadLine();
        }
    }
}