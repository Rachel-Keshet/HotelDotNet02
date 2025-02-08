using System.Collections.Generic;

namespace Core
{
    public interface IGuest
    {
        //IEnumerable<Guest> GetAllGuests();  // Get all guests
        Guest Add(Guest guest);          // Add a new guest
        //void RemoveGuest(Guest guest);       // Remove an existing guest
        Guest? GetById(int id);
        void Delete(int id);
        Guest Update(Guest guest);
        List<Guest> GetList();
    }
}
