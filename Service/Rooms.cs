using Core;
using System;

namespace Service;
public class RoomService : IRoom
{
    private readonly IRoomRepository _RoomRepository;

    public RoomService(IRoomRepository RoomRepository)
    {
        _RoomRepository = RoomRepository;
    }

    public List<Room> GetList()
    {
        return _RoomRepository.GetAll();
    }

    public Room? GetById(int id)
    {
        return _RoomRepository.GetById(id);
    }

    public Room Add(Room Room)
    {
        return _RoomRepository.Add(Room);
    }

    public Room Update(Room Room)
    {
        return _RoomRepository.Update(Room);
    }

    public void Delete(int id)
    {
        _RoomRepository.Delete(id);
    }

    //public Room AddRoom(Room room)
    //{
    //    throw new NotImplementedException();
    //}

    //public IEnumerable<Room> GetAllRooms()
    //{
    //    throw new NotImplementedException();
    //}

    //public void AddRoom(Room room)
    //{
    //    throw new NotImplementedException();
    //}

    //public void RemoveRoom(Room room)
    //{
    //    throw new NotImplementedException();
    //}

    //public object FirstOrDefault(Func<object, bool> value)
    //{
    //    throw new NotImplementedException();
    //}

    //object IRoom.GetList()
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
}