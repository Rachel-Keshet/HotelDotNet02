using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Core
{
    public class Reservation
    {
        public int Id { get; set; }
        public int GuestId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public double TotalPrice { get; set; }
        public string Status { get; set; } // Active, Cancelled, Completed

        // Constructor
        public Reservation(int id, int guestId, int roomId, DateTime checkInDate, DateTime checkOutDate, double totalPrice, string status)
        {
            Id = id;
            GuestId = guestId;
            RoomId = roomId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            TotalPrice = totalPrice;
            Status = status;
        }
    }
}