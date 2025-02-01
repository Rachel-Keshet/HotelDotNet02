namespace Core
{
    public interface IRoomRepository
    {
        List<Room> GetAll();

        Room? GetById(int id);

        Room Add(Room Room);

        Room Update(Room Room);

        void Delete(int id);
    }
}