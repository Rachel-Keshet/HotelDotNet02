namespace Core;

public interface IReservation
{
    //IEnumerable<Reservation> GetAllReservations();  // Get all Reservations
    Reservation Add(Reservation reservation); // Add a new guest
    //void RemoveReservation(Reservation guest);
    Reservation GetById(int id);
    Reservation Update( Reservation reservation);
    void Delete(int id);
    List<Reservation> GetList();

}
