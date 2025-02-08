using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Core
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public string Type { get; set; } // Single, Double, Suite
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        // Constructor
        //public Room(int id, string roomNumber, string type, double pricePerNight, bool isAvailable)
        //{
        //    Id = id;
        //    RoomNumber = roomNumber;
        //    Type = type;
        //    PricePerNight = pricePerNight;
        //    IsAvailable = isAvailable;
        //}

        //IEnumerable<Room> IRoom.GetAllRooms()
        //{
        //    throw new NotImplementedException();
        //}

        //void IRoom.AddRoom(Room room)
        //{
        //    throw new NotImplementedException();
        //}

        //void IRoom.RemoveRoom(Room room)
        //{
        //    throw new NotImplementedException();
        //}

        //object IRoom.FirstOrDefault(Func<object, bool> value)
        //{
        //    throw new NotImplementedException();
        //}

        //object IRoom.GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //object IRoom.Update(Room room)
        //{
        //    throw new NotImplementedException();
        //}

        //void IRoom.Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //object IRoom.GetList()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
