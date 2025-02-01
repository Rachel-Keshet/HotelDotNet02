using System;

/// <summary>
/// Summary description for Class1
/// </summary>

        public class Room
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public string Type { get; set; } // Single, Double, Suite
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        // Constructor
        public Room(int id, string roomNumber, string type, double pricePerNight, bool isAvailable)
        {
            Id = id;
            RoomNumber = roomNumber;
            Type = type;
            PricePerNight = pricePerNight;
            IsAvailable = isAvailable;
        }
    }
