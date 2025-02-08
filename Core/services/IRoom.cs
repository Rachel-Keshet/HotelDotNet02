using System;
namespace Core;

public interface IRoom
{
    //IEnumerable<Room> GetAllRooms();  // Get all rooms
    Room Add(Room room); // Add a new guest
    //void RemoveRoom(Room room);
    //object FirstOrDefault(Func<object, bool> value);
    Room? GetById(int id);
    Room Update(Room room);
    void Delete(int id);
    List <Room> GetList();
}
