using Data;

namespace Core
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly DataContext _context;

        public ReservationRepository(DataContext context)
        {
            _context = context;
        }

        public List<Reservation> GetAll()
        {
            return _context.Reservations.ToList();
        }

        public Reservation? GetById(int id)
        {
            return _context.Reservations.FirstOrDefault(x => x.Id == id);
        }

        public Reservation Add(Reservation Reservation)
        {
            _context.Reservations.Add(Reservation);
            return Reservation;
        }

        public Reservation Update(Reservation reservation)
        {
            var existingReservation = GetById(reservation.Id);
            //if (existingReservation is null)
            //{
            //    throw new Exception("Reservation not found");
            //}

            existingReservation!.Status = reservation.Status; // Update status from the passed reservation

            // No need to update Id, as it should stay the same (assuming Id is immutable).
            return existingReservation;
        }


        public void Delete(int id)
        {
            var existingReservation = GetById(id);
            if (existingReservation is not null)
            {
                _context.Reservations.Remove(existingReservation);
            }
        }
    }
}