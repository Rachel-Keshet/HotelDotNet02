using Core;
using Data;

namespace Core
{
    public class GuestRepository : IGuestRepository
    {
        private readonly DataContext _context;

        public GuestRepository(DataContext context)
        {
            _context = context;
        }

        public List<Guest> GetAll()
        {
            return _context.Guests.ToList();
        }

        public Guest? GetById(int id)
        {
            return _context.Guests.FirstOrDefault(x => x.Id == id);
        }

        public Guest Add(Guest Guest)
        {
            _context.Guests.Add(Guest);
            return Guest;
        }

        public Guest Update(Guest guest)
        {
            var existingGuest = GetById(guest.Id);
            //if (existingGuest is null)
            //{
            //    throw new Exception("Guest not found");
            //}

            existingGuest!.Name = guest.Name;
            existingGuest.Email = guest.Email;

            return existingGuest;
        }


        public void Delete(int id)
        {
            var existingGuest = GetById(id);
            if (existingGuest is not null)
            {
                _context.Guests.Remove(existingGuest);
            }
        }
    }
}