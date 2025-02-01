using System.Collections.Generic;

namespace Core
{
    public interface IGuest
    {
        IEnumerable<Guest> GetAllGuests();  // Get all guests
        void AddGuest(Guest guest);          // Add a new guest
        void RemoveGuest(Guest guest);       // Remove an existing guest
        object GetList();
        object GetById(int id);
        void Delete(int id);
        object Update(Guest guest);
    }
}
