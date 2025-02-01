using Core;
using Microsoft.Extensions.Logging;
using System;


namespace Core
{
    public class Guests : IGuest
    {
        private readonly List<Guest> _guestList; // Internal list to store guests

        // Constructor
        public Guests() => _guestList = new List<Guest> // Initialize with some sample guests
            {
                new Guest(1, "John Doe", "123456789", "johndoe@example.com"),
                new Guest(2, "Jane Smith", "987654321", "janesmith@example.com")
            };

        public IEnumerable<Guest> GetAllGuests() => _guestList; // Get all guests

        public void AddGuest(Guest guest) => _guestList.Add(guest); // Add a new guest to the list

        public void RemoveGuest(Guest guest) => _guestList.Remove(guest); // Remove a guest from the list
    }
}


