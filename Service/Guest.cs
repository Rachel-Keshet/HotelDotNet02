using Core;
using System;

namespace Core
{
    public class GuestService : IGuest
    {
        private readonly IGuestRepository _GuestRepository;

        public GuestService(IGuestRepository GuestRepository)
        {
            _GuestRepository = GuestRepository;
        }

        public List<Guest> GetList()
        {
            return _GuestRepository.GetAll();
        }

        public Guest? GetById(int id)
        {
            return _GuestRepository.GetById(id);
        }

        public Guest Add(Guest Guest)
        {
            return _GuestRepository.Add(Guest);
        }

        public Guest Update(Guest Guest)
        {
            return _GuestRepository.Update(Guest);
        }

        public void Delete(int id)
        {
            _GuestRepository.Delete(id);
        }

        //public Guest AddGuest(Guest guest)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Guest> GetAllGuests()
        //{
        //    throw new NotImplementedException();
        //}

        //public void AddGuest(Guest guest)
        //{
        //    throw new NotImplementedException();
        //}

        //public void RemoveGuest(Guest guest)
        //{
        //    throw new NotImplementedException();
        //}

        //object IGuest.GetList()
        //{
        //    throw new NotImplementedException();
        //}

        //object IGuest.GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //object IGuest.Update(Guest guest)
        //{
        //    throw new NotImplementedException();
        //}
    }
}


