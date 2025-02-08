using Core;
using Data;

namespace netP
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DataContext _context;
        public IGuestRepository Guest { get; }

        public IReservationRepository Reservation { get; }

        public IRoomRepository Room { get; }


        public RepositoryManager(DataContext context, IGuestRepository guestRepository, IReservationRepository reservationRepository, IRoomRepository roomRepository)
        {
            _context = context;
            Guest = guestRepository;
            Reservation = reservationRepository;
            Room = roomRepository;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
