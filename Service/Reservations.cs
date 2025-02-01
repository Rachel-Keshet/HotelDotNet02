


using Core;

public class ReservationService : IReservation
{
    private readonly IReservationRepository _ReservationRepository;

    public ReservationService(IReservationRepository ReservationRepository)
    {
        _ReservationRepository = ReservationRepository;
    }

    public List<Reservation> GetList()
    {
        return _ReservationRepository.GetAll();
    }

    public Reservation? GetById(int id)
    {
        return _ReservationRepository.GetById(id);
    }

    public Reservation Add(Reservation Reservation)
    {
        return _ReservationRepository.Add(Reservation);
    }

    public Reservation Update(Reservation Reservation)
    {
        return _ReservationRepository.Update(Reservation);
    }

    public void Delete(int id)
    {
        _ReservationRepository.Delete(id);
    }

    public IEnumerable<Reservation> GetAllReservations()
    {
        throw new NotImplementedException();
    }

    public void AddReservation(Reservation guest)
    {
        throw new NotImplementedException();
    }

    public void RemoveReservation(Reservation guest)
    {
        throw new NotImplementedException();
    }

    public object GetReservationById(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateReservation(int id, Reservation reservation)
    {
        throw new NotImplementedException();
    }

    public void DeleteReservation(int id)
    {
        throw new NotImplementedException();
    }
}