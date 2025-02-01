namespace Core
{
    public interface IGuestRepository
    {
        List<Guest> GetAll();

        Guest? GetById(int id);

        Guest Add(Guest Guest);

        Guest Update(Guest Guest);

        void Delete(int id);
    }
}