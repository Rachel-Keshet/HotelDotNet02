namespace Core
{
    public interface IReservationRepository
    {
        List<Reservation> GetAll();

        Reservation? GetById(int id);

        Reservation Add(Reservation Reservation);

        Reservation Update(Reservation Reservation);

        void Delete(int id);
    }
}