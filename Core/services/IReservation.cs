namespace Core;

public interface IReservation
{
    IEnumerable<Reservation> GetAllReservations();  // Get all Reservations
    void AddReservation(Reservation guest); // Add a new guest
    void RemoveReservation(Reservation guest);
    object GetReservationById(int id);
    void UpdateReservation(int id, Reservation reservation);
    void DeleteReservation(int id);
}
