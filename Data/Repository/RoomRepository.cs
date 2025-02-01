using Microsoft.Graph;
using Microsoft.Graph.Models;

namespace Data
{
    public class RoomRepository : IRoomRepository
    {
        private readonly DataContext _context;

        public RoomRepository(DataContext context)
        {
            _context = context;
        }

        public List<Room> GetAll()
        {
            return _context.Rooms.ToList();
        }

        public Room? GetById(int id)
        {
            return _context.Rooms.FirstOrDefault(x => x.Id == id);
        }

        public Room Add(Room Room)
        {
            _context.Rooms.Add(Room);
            return Room;
        }

        public Room Update(Room Room)
        {
            var existingRoom = GetById(Room.Id);
            if (existingRoom is null)
            {
                throw new Exception("Room not found");
            }
            existingRoom.Id = Room.Id;
            existingRoom.Type = Room.Type;
            return existingRoom;
        }

        public void Delete(int id)
        {
            var existingRoom = GetById(id);
            if (existingRoom is not null)
            {
                _context.Rooms.Remove(existingRoom);
            }
        }
    }

    public interface IRoomRepository
    {
    }
}