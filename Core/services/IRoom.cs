using System;
namespace Core;

public interface IRoom
{
    IEnumerable<Room> GetAllRooms();  // Get all rooms
    void AddRoom(Room room); // Add a new guest
    void RemoveRoom(Room room);
    object FirstOrDefault(Func<object, bool> value);
    object GetList();
    object GetById(int id);
    object Update(Room room);
    void Delete(int id);
}
