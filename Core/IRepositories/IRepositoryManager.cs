namespace Core
{
public interface IRepositoryManager
{
    IGuestRepository Guest { get; }
    IReservationRepository Reservation { get; }
    IRoomRepository Room { get; }

        void Save();
}
}